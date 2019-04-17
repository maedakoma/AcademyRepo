using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AcademyMgr;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.Defaults;
using LiveCharts.Configurations;

namespace Academy
{
    public partial class MainForm : Form
    {
        List<Member> members;
        List<Private> privates;
        List<CoachPay> pays;
        List<Refund> refunds;
        List<Seminar> seminars;
        AcademyMgr.AcademyMgr manager;
        public MainForm()
        {
            InitializeComponent();
            manager = new AcademyMgr.AcademyMgr();
            manager.Initialize();
            this.Text = "Academy Cercle - " + manager.connectionString;
            MainForm_Load();
        }

        private void MainForm_Load()
        {

            //TODO TODO
            //Bug: Quand on modifie les paiements et ferme la fenetre, c'est encore en mémoire....
            // Faire des chiffres previsionels
            // Comment enregistrer des reports et lesquels?
            // faire une version web
            // faire un script de svg SQL
            // Mettre dans la grille une colonne paiement avec ($$$ ou 2 / 5 posés par ex)
            // Gerer les ouvertures fermetures de connection
            // Faire de payment.type une énumération??
        }

        public void FillFinancialResume()
        {
            decimal nLicencesAmount = manager.getLicencesAmount();
            txtLicencesAmount.Text = nLicencesAmount.ToString();
            decimal nLicencesDebt = manager.getLicencesDebt();
            txtLicencesDebt.Text = nLicencesDebt.ToString();
            txtLicencesBenef.Text = (nLicencesAmount - nLicencesDebt).ToString();
            decimal nPrivatesAmount = manager.getPrivatesAmount();
            txtPrivates.Text = nPrivatesAmount.ToString();
            decimal nSeminarsAmount = manager.getSeminarsAmount();
            txtSeminar.Text = nSeminarsAmount.ToString();
            decimal nSeminarsDebt = manager.getSeminarsDebt();
            txtSeminarDebt.Text = nSeminarsDebt.ToString();
            txtSeminarBenef.Text = (nSeminarsAmount - nSeminarsDebt).ToString();
            decimal nCoachsPaysAmount = manager.getCoachsPaysAmount();
            txtTeacherPays.Text = nCoachsPaysAmount.ToString();
            txtTotalDebt.Text = (nSeminarsDebt + nLicencesDebt).ToString();
            txtPaidDebt.Text = manager.getPaidDebt().ToString();
            txtDebt.Text = (nSeminarsDebt + nLicencesDebt - manager.getPaidDebt()).ToString();
            decimal nTotalBenef = nLicencesAmount - nLicencesDebt + nPrivatesAmount + nSeminarsAmount - nSeminarsDebt - nCoachsPaysAmount;
            txtTotalBenef.Text = nTotalBenef.ToString();
            //calcul d'un mensuel hypothétique:
            DateTime beginDate = new DateTime(2017,5,1);
            int nMonth = Math.Abs((beginDate.Month - DateTime.Now.Month) + 12 * (beginDate.Year - DateTime.Now.Year));
            txtBlackMonth.Text = (nTotalBenef / nMonth).ToString();
            txtOfficialMonth.Text = ((nTotalBenef * 75) / (nMonth * 100)).ToString();

            var dayConfig = Mappers.Xy<DateModel>()
                                  .X(dateModel => dateModel.DateTime.Ticks / (TimeSpan.FromDays(1).Ticks * 30.44))
                                  .Y(dateModel => (double) dateModel.Value);


            cartesianChart1.Series = new SeriesCollection(dayConfig)
            {
                new LineSeries
                {
                    Title = "Licences", Values = new ChartValues<DateModel>{},
                    Fill = System.Windows.Media.Brushes.Transparent
                },
                new LineSeries
                {
                    Title = "Stage", Values = new ChartValues<DateModel>{},
                    Fill = System.Windows.Media.Brushes.Transparent
                },
                new LineSeries
                {
                    Title = "Privates", Values = new ChartValues<DateModel>{},
                    Fill = System.Windows.Media.Brushes.Transparent
                }
            };
            List<Payment> payments = manager.getPayments();
            //aggregation des montants
            DateTime datetemp = DateTime.MinValue;
            decimal amounttemp = 0;
            foreach(Payment pay in payments)
            {
                //On n'affiche pas le mois courant car incomplet
                if (pay.ReceptionDate.Month != DateTime.Now.Month)
                {
                    if (amounttemp != 0 && pay.ReceptionDate.Month != datetemp.Month)
                    {
                        //on est sur un nouveau paiement on ajoute le précedent:
                        cartesianChart1.Series[0].Values.Add(new DateModel { DateTime = datetemp, Value = amounttemp });
                        amounttemp = 0;
                    }
                    datetemp = pay.ReceptionDate;
                    amounttemp += (pay.Amount - pay.Debt);
                }
            }
            cartesianChart1.Series[0].Values.Add(new DateModel { DateTime = datetemp, Value = amounttemp });

            seminars = manager.getSeminars();
            //aggregation des montants
            datetemp = DateTime.MinValue;
            amounttemp = 0;
            foreach (Seminar seminar in seminars)
            {
                if (amounttemp != 0 && seminar.Date.Month != datetemp.Month)
                {
                    //on est sur un nouveau paiement on ajoute le précedent:
                    cartesianChart1.Series[1].Values.Add(new DateModel { DateTime = datetemp, Value = amounttemp });
                    amounttemp = 0;
                }
                datetemp = seminar.Date;
                amounttemp += (seminar.Amount - seminar.Debt);
            }
            cartesianChart1.Series[1].Values.Add(new DateModel { DateTime = datetemp, Value = amounttemp });

            //List<Private> privates = manager.getPrivates();
            ////aggregation des montants
            //datetemp = DateTime.MinValue;
            //amounttemp = 0;
            //foreach (Private priv in privates)
            //{
            //    //On n'affiche pas le mois courant car incomplet
            //    if (priv.Date.Month != DateTime.Now.Month)
            //    {
            //        if (amounttemp != 0 && priv.Date.Month != datetemp.Month)
            //        {
            //            //on est sur un nouveau paiement on ajoute le précedent:
            //            cartesianChart1.Series[2].Values.Add(new DateModel { DateTime = datetemp, Value = amounttemp });
            //            amounttemp = 0;
            //        }
            //        datetemp = priv.Date;
            //        amounttemp += (priv.Amount);
            //    }
            //}
            //cartesianChart1.Series[2].Values.Add(new DateModel { DateTime = datetemp, Value = amounttemp });


            double minV = new DateTime(2017, 4, 1).Ticks / (TimeSpan.FromDays(1).Ticks * 30.44);
            double maxV = new DateTime(2018, 11, 1).Ticks / (TimeSpan.FromDays(1).Ticks * 30.44);
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks * 30.44)).ToString("M"),
                MinValue = minV,
                MaxValue = maxV,
                Separator = new Separator
                {
                    Step = (maxV - minV) / 12
                }
            });
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Montant",
                MinValue = 0
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

        }

        public void FillMembersResume()
        {
            int nTotal = manager.getActiveStudentsCount();
            int nWhite = manager.getActiveStudentsCount(Member.beltEnum.White);
            int nBlue = manager.getActiveStudentsCount(Member.beltEnum.Blue);
            int nPurple = manager.getActiveStudentsCount(Member.beltEnum.Purple);
            int nBrown = manager.getActiveStudentsCount(Member.beltEnum.Brown);
            int nBlack = manager.getActiveStudentsCount(Member.beltEnum.Black);
            int nCompetitors = manager.getActiveStudentsCompetitorCount();
            List<String> newStudents = manager.getNewStudents(dateTimeRef.Value);
            List<String> lostStudents = manager.getLostStudents(dateTimeRef.Value);

            txtMembersCount.Text = nTotal.ToString();
            txtWhite.Text = nWhite.ToString() + " (" + (((double)nWhite/ (double)nTotal)).ToString("P", CultureInfo.InvariantCulture)+")";
            txtBlue.Text = nBlue.ToString() + " (" + (((double)nBlue / (double)nTotal)).ToString("P", CultureInfo.InvariantCulture) + ")";
            txtPurple.Text = nPurple.ToString() + " (" + (((double)nPurple / (double)nTotal)).ToString("P", CultureInfo.InvariantCulture) + ")";
            txtBrown.Text = nBrown.ToString() + " (" + (((double)nBrown / (double)nTotal)).ToString("P", CultureInfo.InvariantCulture) + ")";
            txtBlack.Text = nBlack.ToString() + " (" + (((double)nBlack / (double)nTotal)).ToString("P", CultureInfo.InvariantCulture) + ")";
            txtCompetitor.Text = nCompetitors.ToString() + " (" + (((double)nCompetitors / (double)nTotal)).ToString("P", CultureInfo.InvariantCulture) + ")";
            txtNewStudents.Text = newStudents.Count.ToString();
            listNew.Items.Clear();
            foreach (String student in newStudents)
            {
                listNew.Items.Add(student);
            }
            txtLostStudents.Text = lostStudents.Count.ToString();
            listLost.Items.Clear();
            foreach (String student in lostStudents)
            {
                listLost.Items.Add(student);
            }

            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "White",
                    Values = new ChartValues<double> {nWhite},
                    PushOut = 15,
                    Fill  = System.Windows.Media.Brushes.White,
                    Stroke  = System.Windows.Media.Brushes.Black,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Blue",
                    Values = new ChartValues<double> {nBlue},
                    Fill  = System.Windows.Media.Brushes.Blue,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Purple",
                    Values = new ChartValues<double> {nPurple},
                    Fill  = System.Windows.Media.Brushes.Purple,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Brown",
                    Values = new ChartValues<double> {nBrown},
                    Fill  = System.Windows.Media.Brushes.Brown,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Black",
                    Values = new ChartValues<double> {nBlack},
                    Fill  = System.Windows.Media.Brushes.Black,
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;


            var dayConfig = Mappers.Xy<DateModel>()
                                  .X(dateModel => dateModel.DateTime.Ticks / (TimeSpan.FromDays(1).Ticks * 30.44))
                                  .Y(dateModel => (double) dateModel.Value);


            cartesianChart2.Series = new SeriesCollection(dayConfig)
            {
                new LineSeries
                {
                    Title = "Active students", Values = new ChartValues<DateModel>{},
                    Fill = System.Windows.Media.Brushes.Transparent
                }
            };

            List<DateTime> dates = manager.getMembersHistoriesDates();
            List<Member> students;
            int minVal = 100000;
            int maxVal = 0;
            foreach (DateTime date in dates)
            {
                students = manager.getMembersHistories(date);
                if (minVal > students.Count)
                {
                    minVal = students.Count;
                }
                if (maxVal < students.Count)
                {
                    maxVal = students.Count;
                }
                cartesianChart2.Series[0].Values.Add(new DateModel { DateTime = date, Value = students.Count });
            }

            double minV = dates[0].Ticks / (TimeSpan.FromDays(1).Ticks * 30.44);
            double maxV = dates[dates.Count - 1].Ticks / (TimeSpan.FromDays(1).Ticks * 30.44);
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisX.Add(new Axis
            {
                LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks * 30.44)).ToString("M"),
                MinValue = minV,
                MaxValue = maxV,
                Separator = new Separator
                {
                    Step = (maxV - minV) / 12
                }
            });
            cartesianChart2.AxisY.Clear();
            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Nombre",
                MinValue = minVal,
                MaxValue = maxVal
            });

            cartesianChart2.LegendLocation = LegendLocation.Right;
        }

        public void FillMembersGrid(int rowIndex = 0)
        {
            bool onlyActive = !chkInactive.Checked;
            members = manager.getMembers();
            //Create a New DataTable to store the Data
            DataTable People = new DataTable("People");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("alert");
            DataColumn c2 = new DataColumn("fullyear");
            DataColumn c3 = new DataColumn("lastname");
            DataColumn c4 = new DataColumn("firstname");
            DataColumn c5 = new DataColumn("creationdate");
            c5.DataType = typeof(DateTime);
            DataColumn c6 = new DataColumn("enddate");
            c6.DataType = typeof(DateTime);
            DataColumn c7 = new DataColumn("belt");
            DataColumn c8 = new DataColumn("stripe");
            DataColumn c9 = new DataColumn("gender");
            DataColumn c10 = new DataColumn("child");
            c10.DataType = typeof(bool);
            DataColumn c11 = new DataColumn("competitor");
            c11.DataType = typeof(bool);
            DataColumn c12 = new DataColumn("amount");
            DataColumn c13 = new DataColumn("debt");
            DataColumn c14 = new DataColumn("mail");
            DataColumn c15 = new DataColumn("comment");

            //Add the Created Columns to the Datatable
            People.Columns.Add(c0);
            People.Columns.Add(c1);
            People.Columns.Add(c2);
            People.Columns.Add(c3);
            People.Columns.Add(c4);
            People.Columns.Add(c5);
            People.Columns.Add(c6);
            People.Columns.Add(c7);
            People.Columns.Add(c8);
            People.Columns.Add(c9);
            People.Columns.Add(c10);
            People.Columns.Add(c11);
            People.Columns.Add(c12);
            People.Columns.Add(c13);
            People.Columns.Add(c14);
            People.Columns.Add(c15);

            foreach (Member mem in members)
            {
                if (!mem.Active && onlyActive)
                {
                    continue;
                }
                DataRow row = People.NewRow();
                row["ID"] = mem.ID;
                row["lastname"] = mem.Lastname;
                row["firstname"] = mem.Firstname;
                row["creationdate"] = mem.Creationdate;
                row["enddate"] = mem.Enddate;
                row["belt"] = mem.Belt;
                row["stripe"] = mem.Stripe;
                row["gender"] = mem.Gender;
                row["child"] = mem.Child;
                row["alert"] = mem.Alert;
                row["fullyear"] = mem.FullYear;
                decimal amount = 0;
                decimal debt = 0;
                foreach (Payment pay in mem.Payments)
                {
                    amount = amount + pay.Amount;
                    debt = debt + pay.Debt;
                }
                row["amount"] = amount;
                row["debt"] = debt;
                row["comment"] = mem.Comment;
                row["mail"] = mem.Mail;
                row["competitor"] = mem.Competitor;
                People.Rows.Add(row);
            }
            mainGrid.DataSource = People;
            mainGrid.Columns[0].Visible = false;
            mainGrid.Columns[1].Visible = false;
            mainGrid.Columns[2].Visible = false;
            mainGrid.RowHeadersVisible = false;
            mainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainGrid.AllowUserToAddRows = false;
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            mainGrid.Columns[mainGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mainGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            mainGrid.ReadOnly = true;
            if (rowIndex != 0)
            {
                mainGrid.CurrentCell = mainGrid.Rows[rowIndex].Cells[10];
                mainGrid.Rows[rowIndex].Selected = true;
            }
            else
            {
                mainGrid.CurrentCell = null;
            }

            mainGrid.BorderStyle = BorderStyle.Fixed3D;
            mainGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            mainGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            mainGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            mainGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            mainGrid.BackgroundColor = Color.White;
            mainGrid.EnableHeadersVisualStyles = false;
            mainGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            mainGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            mainGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            lblLines.Text = mainGrid.RowCount.ToString() +  " lignes affichées";
        }
        public void FillMoneyGrid()
        {

            // Arbres des montants reçus
            List<Payment> pays = manager.getPayments(false);
            trMoneyReceived.Nodes.Clear();
            trMoneyReceived.BeginUpdate();
            decimal nAmount = 0;
            foreach (Payment pay in pays)
            {
                string date = pay.ReceptionDate.ToShortDateString();
                if (!trMoneyReceived.Nodes.ContainsKey(date))
                {
                    trMoneyReceived.Nodes.Add(date, date);
                }
                if (!trMoneyReceived.Nodes[date].Nodes.ContainsKey(pay.Type.ToString()))
                {
                    trMoneyReceived.Nodes[date].Nodes.Add(pay.Type.ToString(), pay.Type.ToString());
                    nAmount = 0;
                }
                nAmount = nAmount + pay.Amount;
                if (!trMoneyReceived.Nodes[date].Nodes[pay.Type.ToString()].Nodes.ContainsKey(pay.ID.ToString()))
                {
                    trMoneyReceived.Nodes[date].Nodes[pay.Type.ToString()].Nodes.Add(pay.ID.ToString(), pay.Name + " - " + pay.Amount.ToString());
                }
                if (nAmount != 0)
                {
                    trMoneyReceived.Nodes[date].Nodes[pay.Type.ToString()].Text = pay.Type.ToString() + " ( " + nAmount.ToString() + " E )";
                }
                //----
                //if (!trMoneyReceived.Nodes[date].Nodes.ContainsKey(pay.Name))
                //{
                //    trMoneyReceived.Nodes[date].Nodes.Add(pay.Name, pay.Name);
                //}

                //trMoneyReceived.Nodes[date].Nodes[pay.Name].Nodes.Add(pay.Amount.ToString() + " - " + pay.Type + " - " + pay.Bank);
            }
            trMoneyReceived.EndUpdate();

            // Arbres des cheques déposés
            pays = manager.getPayments(true);
            trMoneyDepot.Nodes.Clear();
            trMoneyDepot.BeginUpdate();
            nAmount = 0;
            foreach (Payment pay in pays)
            {
                string date = pay.DepotDate.ToShortDateString();
                if (!trMoneyDepot.Nodes.ContainsKey(date))
                {
                    trMoneyDepot.Nodes.Add(date, date);
                }
                if (!trMoneyDepot.Nodes[date].Nodes.ContainsKey(pay.Bank.ToString()))
                {
                    trMoneyDepot.Nodes[date].Nodes.Add(pay.Bank.ToString(), pay.Bank.ToString());
                    nAmount = 0;
                }
                nAmount = nAmount + pay.Amount;

                if (!trMoneyDepot.Nodes[date].Nodes[pay.Bank.ToString()].Nodes.ContainsKey(pay.Name))
                {
                    trMoneyDepot.Nodes[date].Nodes[pay.Bank.ToString()].Nodes.Add(pay.Name, pay.Name + " - " + pay.Amount.ToString());
                }
                //trMoneyDepot.Nodes[date].Nodes[pay.Bank.ToString()].Nodes[pay.Name].Nodes.Add(pay.Amount.ToString() + " - " + pay.Type + " - " + pay.Bank);
                if (nAmount != 0)
                {
                    trMoneyDepot.Nodes[date].Nodes[pay.Bank.ToString()].Text = pay.Bank.ToString() + " ( " + nAmount.ToString() + " E )";
                }
            }
            trMoneyDepot.EndUpdate();

        }
        public void FillSeminarsGrid(int rowIndex = 0)
        {
            //AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            //manager.Open();
            seminars = manager.getSeminars();
            //Create a New DataTable to store the Data
            DataTable Seminar = new DataTable("Seminar");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("theme");
            DataColumn c2 = new DataColumn("date");
            c2.DataType = typeof(DateTime);
            DataColumn c3 = new DataColumn("webmembers");
            DataColumn c4 = new DataColumn("localmembers");
            DataColumn c5 = new DataColumn("amount");
            DataColumn c6 = new DataColumn("debt");
            DataColumn c7 = new DataColumn("comment");


            //Add the Created Columns to the Datatable
            Seminar.Columns.Add(c0);
            Seminar.Columns.Add(c1);
            Seminar.Columns.Add(c2);
            Seminar.Columns.Add(c3);
            Seminar.Columns.Add(c4);
            Seminar.Columns.Add(c5);
            Seminar.Columns.Add(c6);
            Seminar.Columns.Add(c7);

            foreach (Seminar seminar in seminars)
            {
                DataRow row = Seminar.NewRow();
                row["ID"] = seminar.ID;
                row["theme"] = seminar.Theme;
                row["date"] = seminar.Date;
                row["webmembers"] = seminar.WebMembers;
                row["localmembers"] = seminar.LocalMembers;
                row["amount"] = seminar.Amount;
                row["debt"] = seminar.Debt;
                row["comment"] = seminar.Comment;
                Seminar.Rows.Add(row);
            }
            gridSeminars.DataSource = Seminar;
            gridSeminars.Columns[0].Visible = false;
            gridSeminars.RowHeadersVisible = false;
            gridSeminars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSeminars.AllowUserToAddRows = false;
            gridSeminars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSeminars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridSeminars.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridSeminars.CurrentCell = gridSeminars.Rows[rowIndex].Cells[1];
                gridSeminars.Rows[rowIndex].Selected = true;
            }
            else
            {
                gridSeminars.CurrentCell = null;
            }
        }
        public void FillPrivatesGrid(int rowIndex = 0)
        {
            //AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            //manager.Open();
            privates = manager.getPrivates();
            //Create a New DataTable to store the Data
            DataTable Private = new DataTable("Private");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("name");
            DataColumn c2 = new DataColumn("date");
            c2.DataType = typeof(DateTime);
            DataColumn c3 = new DataColumn("bookedLessons");
            DataColumn c4 = new DataColumn("doneLessons");
            DataColumn c5 = new DataColumn("description");


            //Add the Created Columns to the Datatable
            Private.Columns.Add(c0);
            Private.Columns.Add(c1);
            Private.Columns.Add(c2);
            Private.Columns.Add(c3);
            Private.Columns.Add(c4);
            Private.Columns.Add(c5);

            foreach (Private priv in privates)
            {
                DataRow row = Private.NewRow();
                row["ID"] = priv.ID;
                row["name"] = priv.member.Lastname;
                row["date"] = priv.Date;
                row["bookedLessons"] = priv.BookedLessons;
                row["doneLessons"] = priv.DoneLessons;
                row["description"] = priv.Description;
                if (!chkCompleted.Checked)
                {
                    if (priv.BookedLessons== priv.DoneLessons)
                    {
                        continue;
                    }
                }
                Private.Rows.Add(row);
            }
            gridPrivates.DataSource = Private;
            gridPrivates.Columns[0].Visible = false;
            gridPrivates.RowHeadersVisible = false;
            gridPrivates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPrivates.AllowUserToAddRows = false;
            gridPrivates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridPrivates.Columns[gridPrivates.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridPrivates.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridPrivates.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridPrivates.CurrentCell = gridPrivates.Rows[rowIndex].Cells[1];
                gridPrivates.Rows[rowIndex].Selected = true;
            }
            else
            {
                gridPrivates.CurrentCell = null;
            }
        }
        public void FillPrivateMembersGrid()
        {
            members = manager.getMembers(null,null,true);
            //Create a New DataTable to store the Data
            DataTable People = new DataTable("People");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("alert");
            DataColumn c2 = new DataColumn("lastname");
            DataColumn c3 = new DataColumn("firstname");
            DataColumn c4 = new DataColumn("belt");
            DataColumn c5 = new DataColumn("mail");
            DataColumn c6 = new DataColumn("comment");
            DataColumn c7 = new DataColumn("abonnement");
            DataColumn c8 = new DataColumn("amount");
            DataColumn c9 = new DataColumn("tel");


            //Add the Created Columns to the Datatable
            People.Columns.Add(c0);
            People.Columns.Add(c1);
            People.Columns.Add(c2);
            People.Columns.Add(c3);
            People.Columns.Add(c4);
            People.Columns.Add(c5);
            People.Columns.Add(c6);
            People.Columns.Add(c7);
            People.Columns.Add(c8);
            People.Columns.Add(c9);


            foreach (Member mem in members)
            {
                DataRow row = People.NewRow();
                row["ID"] = mem.ID;
                row["alert"] = mem.Alert;
                row["lastname"] = mem.Lastname;
                row["firstname"] = mem.Firstname;
                row["belt"] = mem.Belt;
                row["mail"] = mem.Mail;
                row["comment"] = mem.Comment;
                row["abonnement"] = mem.PrivatePlan.Label;
                row["amount"] = mem.PrivatePlan.Amount;
                row["tel"] = mem.Phone;
                People.Rows.Add(row);
            }
            PrivateGrid.DataSource = People;
            PrivateGrid.Columns[0].Visible = false;
            PrivateGrid.Columns[1].Visible = false;
            PrivateGrid.RowHeadersVisible = false;
            PrivateGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PrivateGrid.AllowUserToAddRows = false;
            PrivateGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            PrivateGrid.Columns[PrivateGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrivateGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            PrivateGrid.ReadOnly = true;
            PrivateGrid.CurrentCell = null;

            PrivateGrid.BorderStyle = BorderStyle.Fixed3D;
            PrivateGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            PrivateGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PrivateGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            PrivateGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            PrivateGrid.BackgroundColor = Color.White;
            PrivateGrid.EnableHeadersVisualStyles = false;
            PrivateGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            PrivateGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            PrivateGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public void FillRefundsGrid(int rowIndex = 0)
        {
            //AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            //manager.Open();
            refunds = manager.getRefunds();
            //Create a New DataTable to store the Data
            DataTable Refund = new DataTable("Refund");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("label");
            DataColumn c2 = new DataColumn("amount");
            DataColumn c3 = new DataColumn("date");
            c3.DataType = typeof(DateTime);
            DataColumn c4 = new DataColumn("comment");


            //Add the Created Columns to the Datatable
            Refund.Columns.Add(c0);
            Refund.Columns.Add(c1);
            Refund.Columns.Add(c2);
            Refund.Columns.Add(c3);
            Refund.Columns.Add(c4);
            

            foreach (Refund refund in refunds)
            {
                DataRow row = Refund.NewRow();
                row["ID"] = refund.ID;
                row["label"] = refund.Label;
                row["amount"] = refund.Amount;
                row["date"] = refund.Date;
                row["comment"] = refund.Comment;
                Refund.Rows.Add(row);
            }
            gridRefunds.DataSource = Refund;
            gridRefunds.Columns[0].Visible = false;
            gridRefunds.RowHeadersVisible = false;
            gridRefunds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRefunds.AllowUserToAddRows = false;
            gridRefunds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridRefunds.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridRefunds.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridRefunds.CurrentCell = gridRefunds.Rows[rowIndex].Cells[1];
                gridRefunds.Rows[rowIndex].Selected = true;
            }
            else
            {
                gridRefunds.CurrentCell = null;
            }
        }
        public void FillCoachPayGrid(int rowIndex = 0)
        {
            //AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            //manager.Open();
            pays = manager.getCoachPays();
            //Create a New DataTable to store the Data
            DataTable Coachpay = new DataTable("Coachpay");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("Month");
            DataColumn c2 = new DataColumn("Coach");
            DataColumn c3 = new DataColumn("Lessons");
            DataColumn c4 = new DataColumn("Pay");
            DataColumn c5 = new DataColumn("Amount");
            DataColumn c6 = new DataColumn("Date");
            c6.DataType = typeof(DateTime);
            DataColumn c7 = new DataColumn("comment");


            //Add the Created Columns to the Datatable
            Coachpay.Columns.Add(c0);
            Coachpay.Columns.Add(c1);
            Coachpay.Columns.Add(c2);
            Coachpay.Columns.Add(c3);
            Coachpay.Columns.Add(c4);
            Coachpay.Columns.Add(c5);
            Coachpay.Columns.Add(c6);
            Coachpay.Columns.Add(c7);

            foreach (CoachPay pay in pays)
            {
                DataRow row = Coachpay.NewRow();
                row["ID"] = pay.ID;
                row["Month"] = pay.Month;
                row["Coach"] = pay.Coach.Fullname;
                row["Lessons"] = pay.Lessons;
                row["Pay"] = pay.Pay;
                row["Amount"] = pay.Amount;
                row["date"] = pay.Date;
                row["comment"] = pay.Comment;
                Coachpay.Rows.Add(row);
            }
            gridCoachPay.DataSource = Coachpay;
            gridCoachPay.Columns[0].Visible = false;
            gridCoachPay.RowHeadersVisible = false;
            gridCoachPay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCoachPay.AllowUserToAddRows = false;
            gridCoachPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCoachPay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridCoachPay.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridCoachPay.CurrentCell = gridCoachPay.Rows[rowIndex].Cells[1];
                gridCoachPay.Rows[rowIndex].Selected = true;
            }
            else
            {
                gridCoachPay.CurrentCell = null;
            }
        }

        private void mainGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MemberForm mf = new MemberForm(this, manager);
                mf.Show();
                int currentMemberID = Convert.ToInt32(mainGrid.Rows[e.RowIndex].Cells[0].Value);
                Member member = members.Where(x => x.ID == currentMemberID).ToList<Member>()[0];
                mf.Populate(member, e.RowIndex);
            }
        }
        private void gridPrivates_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                PrivateForm pf = new PrivateForm(this, manager);
                pf.Show();
                int currentPrivateID = Convert.ToInt32(gridPrivates.Rows[e.RowIndex].Cells[0].Value);
                Private priv = privates.Where(x => x.ID == currentPrivateID).ToList<Private>()[0];
                pf.Populate(priv, e.RowIndex);
            }
        }
        private void gridCoachPay_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CoachPayForm cpf = new CoachPayForm(this, manager);
                cpf.Show();
                int currentCoachPayID = Convert.ToInt32(gridCoachPay.Rows[e.RowIndex].Cells[0].Value);
                CoachPay pay = pays.Where(x => x.ID == currentCoachPayID).ToList<CoachPay>()[0];
                cpf.Populate(pay, e.RowIndex);
            }
        }
        private void bntNewMember_Click(object sender, EventArgs e)
        {
            MemberForm mf = new MemberForm(this, manager);
            mf.Show();
        }
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opération irreversible, etes vous bien sur?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int currentMemberID = Convert.ToInt32(mainGrid.SelectedRows[0].Cells[0].Value);
                manager.DeleteMember(currentMemberID);
                FillMembersGrid();
            }
        }

        private void mainGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in mainGrid.Rows)
            {
                bool bAlert = Convert.ToBoolean(row.Cells[1].Value);
                bool bFullyear = Convert.ToBoolean(row.Cells[2].Value);
                if (!bFullyear)
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                if (bAlert)
                {
                    row.DefaultCellStyle.BackColor = Color.BlueViolet;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                DateTime endDate = Convert.ToDateTime(row.Cells[6].Value);
                if (endDate != DateTime.MinValue)
                {
                    int daydiff = (int)(DateTime.Now - endDate).TotalDays;
                    if (daydiff > 10)
                    {
                        if (daydiff < 30)
                        {
                            row.DefaultCellStyle.BackColor = Color.Orange;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                        else if(daydiff < 50)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.Black;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private void privateGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gridPrivates.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[5].Value != null)
                {
                    if (row.Cells[4].Value.ToString() == row.Cells[5].Value.ToString())
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        //row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btnAddCoachPayment_Click(object sender, EventArgs e)
        {
            CoachPayForm cpf = new CoachPayForm(this, manager);
            cpf.Show();
        }

        private void btnAddPrivate_Click(object sender, EventArgs e)
        {
            PrivateForm pf = new PrivateForm(this, manager);
            pf.Show();
        }

        private void btnDelPrivate_Click(object sender, EventArgs e)
        {
            int currentPrivateID = Convert.ToInt32(gridPrivates.SelectedRows[0].Cells[0].Value);
            if (currentPrivateID != 0)
            {
                Private priv = privates.Where(x => x.ID == currentPrivateID).ToList<Private>()[0];
                manager.DeletePrivate(currentPrivateID);
                FillPrivatesGrid();
            }
            else
            {
                gridPrivates.Rows.Remove(gridPrivates.SelectedRows[0]);
            }
        }

        private void tabResume_Enter(object sender, EventArgs e)
        {
            FillFinancialResume();
        }

        private void tabMembersResume_Enter(object sender, EventArgs e)
        {
            FillMembersResume();
        }

        private void tabSeminars_Enter(object sender, EventArgs e)
        {
            FillSeminarsGrid();
        }

        private void tabRefunds_Enter(object sender, EventArgs e)
        {
            FillRefundsGrid();
        }

        private void tabPrivates_Enter(object sender, EventArgs e)
        {
            FillPrivatesGrid();
            FillPrivateMembersGrid();
        }

        private void tabCoachPay_Enter(object sender, EventArgs e)
        {
            FillCoachPayGrid();
        }

        private void tabMembers_Enter(object sender, EventArgs e)
        {
            FillMembersGrid();
        }

        private void tabMoney_Enter(object sender, EventArgs e)
        {
            FillMoneyGrid();
        }

        private void btnAddRefund_Click(object sender, EventArgs e)
        {
            RefundForm rf = new RefundForm(this, manager);
            rf.Show();
        }

        private void btnDelRefund_Click(object sender, EventArgs e)
        {
            int currentRefundID = Convert.ToInt32(gridRefunds.SelectedRows[0].Cells[0].Value);
            manager.DeleteRefund(currentRefundID);
            FillRefundsGrid();
        }

        private void gridRefunds_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                RefundForm rf = new RefundForm(this, manager);
                rf.Show();
                int currentRefundID = Convert.ToInt32(gridRefunds.Rows[e.RowIndex].Cells[0].Value);
                Refund refund = refunds.Where(x => x.ID == currentRefundID).ToList<Refund>()[0];
                rf.Populate(refund, e.RowIndex);
            }
        }

        private void chkInactive_CheckedChanged(object sender, EventArgs e)
        {
            FillMembersGrid();
        }

        private void chkExternal_CheckedChanged(object sender, EventArgs e)
        {
            FillMembersGrid();
        }

        private void chkDepot_CheckedChanged(object sender, EventArgs e)
        {
            FillMoneyGrid();
        }

        private void btnAddSeminar_Click(object sender, EventArgs e)
        {
            SeminarForm sf = new SeminarForm(this, manager);
            sf.Show();
        }

        private void gridSeminars_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SeminarForm sf = new SeminarForm(this, manager);
                sf.Show();
                int currentSeminarID = Convert.ToInt32(gridSeminars.Rows[e.RowIndex].Cells[0].Value);
                Seminar seminar = seminars.Where(x => x.ID == currentSeminarID).ToList<Seminar>()[0];
                sf.Populate(seminar, e.RowIndex);
            }
        }

        private void dateTimeRef_ValueChanged(object sender, EventArgs e)
        {
            List<String> newStudents = manager.getNewStudents(dateTimeRef.Value);
            List<String> lostStudents = manager.getLostStudents(dateTimeRef.Value);
            txtNewStudents.Text = newStudents.Count.ToString();
            listNew.Items.Clear();
            foreach (String student in newStudents)
            {
                listNew.Items.Add(student);
            }
            txtLostStudents.Text = lostStudents.Count.ToString();
            listLost.Items.Clear();
            foreach (String student in lostStudents)
            {
                listLost.Items.Add(student);
            }
        }

        private void chkCompleted_CheckedChanged(object sender, EventArgs e)
        {
            FillPrivatesGrid();
        }
    }

    public class DateModel
    {
        public System.DateTime DateTime { get; set; }
        public decimal Value { get; set; }
    }
}
