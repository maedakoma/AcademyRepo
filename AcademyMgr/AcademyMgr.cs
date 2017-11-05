using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;




namespace AcademyMgr
{
    public class AcademyMgr
    {
        MySqlConnection dbConn;
        //public string connectionString = "server=localhost;user id=admin;password=admin;database=academy";
        public string connectionString = "server=jjbcercle.fr;user id=baugm_thibaut;password=iimg4jek;database=baugma143158com32659_cercle_academy";
        public void Open()
        {
            //dbConn = new MySqlConnection("server=jjbcercle.fr;user id=baugm_thibaut;password=iimg4jek;database=baugma143158com32659_cercle_academy");
            dbConn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            dbConn.Open();
        }
        public List<Refund> getRefunds()
        {
            List<Refund> refunds = new List<Refund>();

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from REFUNDS";

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Refund refund = new Refund();
                refund.ID = (int)reader["ID"];
                refund.Label = reader["label"].ToString();
                refund.Amount = (int)reader["amount"];
                refund.Comment = reader["comment"].ToString();
                refund.Date = Convert.ToDateTime(reader["Date"]);
                refunds.Add(refund);
            }
            reader.Close();
            return refunds;
        }
        public List<CoachPay> getCoachPays()
        {
            List<CoachPay> CoachPays = new List<CoachPay>();
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from COACHSPAYMENTS";
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                CoachPay pay = new CoachPay();
                pay.ID = (int)reader["ID"];
                pay.Month = reader["Month"].ToString();
                pay.Coach = reader["Coach"].ToString();
                pay.Lessons = (int)reader["Lessons"];
                pay.Pay= (int)reader["Pay"];
                pay.Amount = (int)reader["Amount"];
                pay.Date = Convert.ToDateTime(reader["Date"]);
                pay.Comment = reader["comment"].ToString();
                CoachPays.Add(pay);
            }
            reader.Close();
            return CoachPays;
        }
        public List<Seminar> getSeminars()
        {
            List<Seminar> seminars = new List<Seminar>();

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from SEMINARS";

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Seminar seminar = new Seminar();
                seminar.ID = (int)reader["ID"];
                seminar.Theme = reader["Theme"].ToString();
                seminar.Date = Convert.ToDateTime(reader["Date"]);
                seminar.WebMembers = (int)reader["WebMembers"];
                seminar.LocalMembers = (int)reader["LocalMembers"];
                seminar.Amount = (int)reader["amount"];
                seminar.Debt = (int)reader["Debt"];
                seminar.Comment = reader["comment"].ToString();
                
                seminars.Add(seminar);
            }
            reader.Close();
            return seminars;
        }
        public List<Private> getPrivates()
        {
            List<Private> privates = new List<Private>();

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from PRIVATES";

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Private priv = new Private();
                priv.ID = (int)reader["ID"];
                priv.Name = reader["Name"].ToString();
                priv.Amount = (int)reader["amount"];
                priv.Date = Convert.ToDateTime(reader["Date"]);
                priv.BookedLessons = (int)reader["bookedLessons"];
                priv.DoneLessons = (int)reader["doneLessons"];
                privates.Add(priv);
            }
            reader.Close();
            return privates;
        }
        public List<Member> getMembers()
        {
            List<Member> members = new List<Member>();

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT *, P.ID as paymentID from MEMBERS M left outer join MEMBERS_PAYMENTS MP on MP.MemberID = M.ID left outer join PAYMENTS P on P.ID = MP.PaymentID ORDER BY lastname";
            //dbConn.Open();
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            //dbConn.Close();
            Member mem = new Member();
            while (reader.Read())
            {
                if ((mem.Firstname == reader["firstname"].ToString()) && (mem.Lastname == reader["lastname"].ToString()))
                {
                    Payment payment = new Payment();
                    payment.ID = (int)reader["paymentID"];
                    payment.Amount = (int)reader["amount"];
                    payment.Debt = (int)reader["debt"];
                    payment.Type = reader["type"].ToString();
                    payment.Name = reader["name"].ToString();
                    payment.ReceptionDate = Convert.ToDateTime(reader["ReceptionDate"]);
                    payment.depotBank = Convert.ToBoolean(reader["DepotBank"]);
                    if (reader["DepotDate"] != DBNull.Value)
                    {
                        payment.DepotDate = Convert.ToDateTime(reader["DepotDate"]);
                    }
                    mem.Payments.Add(payment);
                }
                else
                {
                    mem = new Member();
                    mem.ID = (int)reader["ID"];
                    mem.Firstname = reader["firstname"].ToString();
                    mem.Lastname = reader["lastname"].ToString();
                    if (reader["enddate"] != DBNull.Value)
                    {
                        mem.Enddate = Convert.ToDateTime(reader["enddate"]);
                        //int result = DateTime.Compare(DateTime.Now, mem.Enddate);
                        int daydiff =(int)(DateTime.Now - mem.Enddate).TotalDays;
                        if (daydiff > 30)
                        {
                            mem.MembershipOK = false;
                        }
                    }
                    String sBelt = reader["belt"].ToString();
                    if (sBelt != String.Empty)
                    {
                        mem.Belt = (Member.beltEnum)Enum.Parse(typeof(Member.beltEnum), sBelt, true);
                    }
                    String sGender = reader["gender"].ToString();
                    if (sGender != String.Empty)
                    {
                        mem.Gender = (Member.genderEnum)Enum.Parse(typeof(Member.genderEnum), sGender, true);
                    }
                    mem.Child = Convert.ToBoolean(reader["Child"]);
                    mem.Alert = Convert.ToBoolean(reader["Alert"]);
                    mem.Active = Convert.ToBoolean(reader["active"]);
                    mem.Comment = reader["comment"].ToString();
                    mem.Job = reader["job"].ToString();
                    Payment payment = new Payment();
                    if (reader["amount"] != DBNull.Value)
                    {
                        payment.ID = (int)reader["paymentID"];
                        payment.Amount = (int)reader["amount"];
                        payment.Debt = (int)reader["debt"];
                        payment.Name = reader["name"].ToString();
                        payment.Type = reader["type"].ToString();
                        payment.ReceptionDate = Convert.ToDateTime(reader["ReceptionDate"]);
                        payment.depotBank = Convert.ToBoolean(reader["DepotBank"]);
                        if (reader["DepotDate"] != DBNull.Value)
                        {
                            payment.DepotDate = Convert.ToDateTime(reader["DepotDate"]);
                        }
                        mem.Payments.Add(payment);
                    }
                    members.Add(mem);
                }
            }
            reader.Close();
            return members;
        }

        public int getActiveMembersCount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            //dbConn.Open();
            cmd.CommandText = "SELECT count(*) from MEMBERS where active=1";
            int nMemberCount = Convert.ToInt32(cmd.ExecuteScalar());
            return nMemberCount;
        }
        public int getLicencesAmount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from PAYMENTS";
            int nAmount = Convert.ToInt32(cmd.ExecuteScalar());
            return nAmount;
        }
        public int getLicencesDebt()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(debt) from PAYMENTS";
            int nDebt = Convert.ToInt32(cmd.ExecuteScalar());
            return nDebt;
        }
        public int getPrivatesAmount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from PRIVATES";
            int nAmount = Convert.ToInt32(cmd.ExecuteScalar());
            return nAmount;
        }
        public int getSeminarsAmount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from SEMINARS";
            int nAmount = Convert.ToInt32(cmd.ExecuteScalar());
            return nAmount;
        }
        public int getSeminarsDebt()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(debt) from SEMINARS";
            int nDebt = Convert.ToInt32(cmd.ExecuteScalar());
            return nDebt;
        }
        public int getPaidDebt()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from REFUNDS";
            int nDebt = Convert.ToInt32(cmd.ExecuteScalar());
            return nDebt;
        }
        public int getCoachsPaysAmount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from COACHSPAYMENTS";
            int nAmount = Convert.ToInt32(cmd.ExecuteScalar());
            return nAmount;
        }

        public bool InsertMember(Member member)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.Prepare();
            comm.CommandText = "INSERT INTO MEMBERS(firstname, lastname, enddate, belt, gender, active, child, alert, comment, job) VALUES(?firstname, ?lastname, ?enddate, ?belt, ?gender, ?active, ?child, ?alert, ?comment, ?job)";
            comm.Parameters.AddWithValue("?firstname", member.Firstname);
            comm.Parameters.AddWithValue("?lastname", member.Lastname);
            comm.Parameters.AddWithValue("?enddate", member.Enddate);
            comm.Parameters.AddWithValue("?belt", member.Belt.ToString());
            comm.Parameters.AddWithValue("?gender", member.Gender.ToString());
            comm.Parameters.AddWithValue("?child", member.Child);
            comm.Parameters.AddWithValue("?active", member.Active);
            comm.Parameters.AddWithValue("?alert", member.Alert);
            comm.Parameters.AddWithValue("?comment", member.Comment);
            comm.Parameters.AddWithValue("?job", member.Job);

            comm.ExecuteNonQuery();

            comm = dbConn.CreateCommand();
            comm.CommandText = "SELECT LAST_INSERT_ID();";
            MySql.Data.MySqlClient.MySqlDataReader reader = comm.ExecuteReader();
            int id = 0;
            reader.Read();
            id = Convert.ToInt32(reader[0]);
            reader.Close();
            //dbConn.Open();
            member.ID = id;

            InsertPayments(member);
            return true;
        }
        public bool InsertPayments(Member member)
        {
            MySqlCommand comm;
            foreach (Payment pay in member.Payments)
            {
                comm = dbConn.CreateCommand();
                comm.CommandText = "INSERT INTO PAYMENTS(Amount, Type, receptionDate, Name, Debt, DepotBank, DepotDate ) VALUES(?amount, ?type, ?receptionDate, ?name, ?debt, ?DepotBank, ?DepotDate)";
                comm.Parameters.AddWithValue("?amount", pay.Amount);
                comm.Parameters.AddWithValue("?type", pay.Type);
                comm.Parameters.AddWithValue("?receptionDate", pay.ReceptionDate);
                comm.Parameters.AddWithValue("?name", pay.Name);
                comm.Parameters.AddWithValue("?debt", pay.Debt);
                comm.Parameters.AddWithValue("?DepotBank", pay.depotBank);
                comm.Parameters.AddWithValue("?DepotDate", pay.DepotDate);
                comm.ExecuteNonQuery();

                comm = dbConn.CreateCommand();
                comm.CommandText = "SELECT LAST_INSERT_ID();";
                MySql.Data.MySqlClient.MySqlDataReader reader = comm.ExecuteReader();
                int id = 0;
                reader.Read();
                id = Convert.ToInt32(reader[0]);
                reader.Close();
                //dbConn.Open();

                comm = dbConn.CreateCommand();
                comm.CommandText = "INSERT INTO MEMBERS_PAYMENTS(MemberID, PaymentID) VALUES(?MemberID, ?PaymentID)";
                comm.Parameters.AddWithValue("?MemberID", member.ID);
                comm.Parameters.AddWithValue("?PaymentID", id);
                comm.ExecuteNonQuery();
            }
            return true;
        }
        public bool DeletePayments(int memberID)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "DELETE FROM MEMBERS_PAYMENTS WHERE MemberID=?MemberID";
            comm.Parameters.AddWithValue("?MemberID", memberID);
            comm.ExecuteNonQuery();

            //on supprime tous les paiements non liés a un membre
            comm = dbConn.CreateCommand();
            comm.CommandText = "DELETE P FROM PAYMENTS AS P WHERE P.ID NOT IN (SELECT PaymentID from MEMBERS_PAYMENTS)";
            comm.ExecuteNonQuery();
            return true;
        }
        public bool UpdateMember(Member member)
        {
            if (!member.Active)
            {
                bool bNotpaid = false;
                //On verifie que tout a bien été encaissé:
                foreach(Payment pay in member.Payments)
                {
                    if ((pay.Type == "check") && (pay.depotBank == false))
                    {
                        bNotpaid = true;
                        break;
                    }
                }
                if (bNotpaid)
                {
                    throw new Exception("Unable to inactive a member with pending payments ");
                }
            }

            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "UPDATE MEMBERS SET firstname=?firstname, lastname=?lastname, enddate=?enddate, belt=?belt, gender=?gender, child=?child, alert=?alert, active=?active, comment=?comment, job=?job WHERE ID=?ID";
            comm.Parameters.AddWithValue("?firstname", member.Firstname);
            comm.Parameters.AddWithValue("?lastname", member.Lastname);
            comm.Parameters.AddWithValue("?enddate", member.Enddate);
            comm.Parameters.AddWithValue("?belt", member.Belt.ToString());
            comm.Parameters.AddWithValue("?gender", member.Gender.ToString());
            comm.Parameters.AddWithValue("?child", member.Child);
            comm.Parameters.AddWithValue("?alert", member.Alert);
            comm.Parameters.AddWithValue("?active", member.Active);
            comm.Parameters.AddWithValue("?comment", member.Comment);
            comm.Parameters.AddWithValue("?job", member.Job);
            comm.Parameters.AddWithValue("?ID", member.ID);
            comm.ExecuteNonQuery();

            //On delete tous les paiements et on les rajoute tous:
            DeletePayments(member.ID);
            InsertPayments(member);

            return true;
        }
        public bool DeleteMember(int memberID)
        {
            //On delete d'abord les paiements associés:
            DeletePayments(memberID);
            //On delete le member
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "DELETE FROM MEMBERS WHERE ID=?ID";
            comm.Parameters.AddWithValue("?ID", memberID);
            comm.ExecuteNonQuery();
            return true;
        }
    }
}
