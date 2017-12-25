using System;
using System.Collections.Generic;
using System.Globalization;
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
            cmd.CommandText = "SELECT * from COACHSPAYMENTS C INNER JOIN MEMBERS M on M.ID=C.MemberID";
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                CoachPay pay = new CoachPay();
                pay.ID = (int)reader["ID"];
                pay.Month = reader["Month"].ToString();
                Member coach = new Member();
                coach.ID = (int)reader["MemberID"];
                coach.Firstname = reader["Firstname"].ToString();
                coach.Lastname = reader["Lastname"].ToString();
                pay.Coach = coach;
                pay.Lessons = (int)reader["Lessons"];
                pay.Pay = (int)reader["Pay"];
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
            cmd.CommandText = "SELECT *, M.ID AS memberID from PRIVATES P inner join MEMBERS M on M.ID = P.memberID";

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Private priv = new Private();
                priv.ID = (int)reader["ID"];
                Member member = new Member();
                member.ID = (int)reader["MemberID"];
                member.Firstname = reader["Firstname"].ToString();
                member.Lastname = reader["Lastname"].ToString();
                priv.member= member;
                priv.Amount = (int)reader["amount"];
                priv.Date = Convert.ToDateTime(reader["Date"]);
                priv.BookedLessons = (int)reader["bookedLessons"];
                priv.DoneLessons = (int)reader["doneLessons"];
                privates.Add(priv);
            }
            reader.Close();
            return privates;
        }
        public List<Member> getMembers(bool? coach = false)
        {
            List<Member> members = new List<Member>();

            MySqlCommand cmd = dbConn.CreateCommand();

            cmd.CommandText = "SELECT *, P.ID as paymentID from MEMBERS M left outer join MEMBERS_PAYMENTS MP on MP.MemberID = M.ID left outer join PAYMENTS P on P.ID = MP.PaymentID";
            if (coach!= null)
            {
                cmd.CommandText += " WHERE M.coach=?coach";
                int nCoach = 0;
                if (coach == true)
                {
                    nCoach = 1;
                }
                cmd.Parameters.AddWithValue("?coach", nCoach);
            }
                cmd.CommandText += " ORDER BY lastname";
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
                    String sBank = reader["bank"].ToString();
                    if (sBank != String.Empty)
                    {
                        payment.Bank = (Payment.bankEnum)Enum.Parse(typeof(Payment.bankEnum), sBank, true);
                    }
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
                        int daydiff = (int)(DateTime.Now - mem.Enddate).TotalDays;
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
                    mem.Mail = reader["mail"].ToString();
                    mem.Phone = reader["phone"].ToString();
                    mem.Address = reader["address"].ToString();
                    mem.Facebook = reader["facebook"].ToString();
                    Payment payment = new Payment();
                    if (reader["amount"] != DBNull.Value)
                    {
                        payment.ID = (int)reader["paymentID"];
                        payment.Amount = (int)reader["amount"];
                        payment.Debt = (int)reader["debt"];
                        payment.Name = reader["name"].ToString();
                        payment.Type = reader["type"].ToString();
                        payment.ReceptionDate = Convert.ToDateTime(reader["ReceptionDate"]);
                        String sBank = reader["bank"].ToString();
                        if (sBank != String.Empty)
                        {
                            payment.Bank = (Payment.bankEnum)Enum.Parse(typeof(Payment.bankEnum), sBank, true);
                        }
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
        public List<Payment> getPayments(bool bydepot = false)
        {
            List<Payment> payments = new List<Payment>();

            MySqlCommand cmd = dbConn.CreateCommand();

            if (bydepot)
            {
                cmd.CommandText = "SELECT * FROM PAYMENTS WHERE Bank <>'None' ORDER BY depotdate, name";
            }
            else
            {
                cmd.CommandText = "SELECT * FROM PAYMENTS ORDER BY receptiondate, name";
            }
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            Payment pay = new Payment();
            while (reader.Read())
            {
                    Payment payment = new Payment();
                    payment.ID = (int)reader["ID"];
                    payment.Amount = (int)reader["amount"];
                    payment.Debt = (int)reader["debt"];
                    payment.Type = reader["type"].ToString();
                    payment.Name = reader["name"].ToString();
                    payment.ReceptionDate = Convert.ToDateTime(reader["ReceptionDate"]);
                    String sBank = reader["bank"].ToString();
                    if (sBank != String.Empty)
                    {
                        payment.Bank = (Payment.bankEnum)Enum.Parse(typeof(Payment.bankEnum), sBank, true);
                    }
                    if (reader["DepotDate"] != DBNull.Value)
                    {
                        payment.DepotDate = Convert.ToDateTime(reader["DepotDate"]);
                    }
                    payments.Add(payment);
            }
            reader.Close();
            return payments;
        }

        public int getStudentsCount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            //dbConn.Open();
            cmd.CommandText = "SELECT count(*) from MEMBERS where active=1";
            int nMemberCount = Convert.ToInt32(cmd.ExecuteScalar());
            return nMemberCount;
        }
        public int getStudentsCount(Member.beltEnum belt)
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT count(*) from MEMBERS where active=1 and belt=?belt";
            cmd.Parameters.AddWithValue("?belt", belt.ToString());
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
            comm.CommandText = "INSERT INTO MEMBERS(firstname, lastname, enddate, belt, gender, active, child, alert, comment, job, mail, phone, address, facebook, coach) VALUES(?firstname, ?lastname, ?enddate, ?belt, ?gender, ?active, ?child, ?alert, ?comment, ?job, ?mail, ?phone, ?address, ?facebook, ?coach)";
            comm.Parameters.AddWithValue("?firstname", CultureInfo.InvariantCulture.TextInfo.ToTitleCase(member.Firstname));
            comm.Parameters.AddWithValue("?lastname", member.Lastname.ToUpper());
            comm.Parameters.AddWithValue("?enddate", member.Enddate);
            comm.Parameters.AddWithValue("?belt", member.Belt.ToString());
            comm.Parameters.AddWithValue("?gender", member.Gender.ToString());
            comm.Parameters.AddWithValue("?child", member.Child);
            comm.Parameters.AddWithValue("?active", member.Active);
            comm.Parameters.AddWithValue("?alert", member.Alert);
            comm.Parameters.AddWithValue("?comment", member.Comment);
            comm.Parameters.AddWithValue("?job", member.Job);
            comm.Parameters.AddWithValue("?mail", member.Mail);
            comm.Parameters.AddWithValue("?phone", member.Phone);
            comm.Parameters.AddWithValue("?address", member.Address);
            comm.Parameters.AddWithValue("?facebook", member.Facebook);
            comm.Parameters.AddWithValue("?coach", 0);

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
        public bool UpdateMember(Member member)
        {
            if (!member.Active)
            {
                bool bNotpaid = false;
                //On verifie que tout a bien été encaissé:
                foreach (Payment pay in member.Payments)
                {
                    if ((pay.Type == "check") && (pay.Bank == Payment.bankEnum.None))
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
            comm.CommandText = "UPDATE MEMBERS SET firstname=?firstname, lastname=?lastname, enddate=?enddate, belt=?belt, gender=?gender, child=?child, alert=?alert, active=?active, comment=?comment, job=?job, mail=?mail, phone=?phone, address=?address, facebook=?facebook WHERE ID=?ID";
            comm.Parameters.AddWithValue("?firstname", CultureInfo.InvariantCulture.TextInfo.ToTitleCase(member.Firstname));
            comm.Parameters.AddWithValue("?lastname", member.Lastname.ToUpper());
            comm.Parameters.AddWithValue("?enddate", member.Enddate);
            comm.Parameters.AddWithValue("?belt", member.Belt.ToString());
            comm.Parameters.AddWithValue("?gender", member.Gender.ToString());
            comm.Parameters.AddWithValue("?child", member.Child);
            comm.Parameters.AddWithValue("?alert", member.Alert);
            comm.Parameters.AddWithValue("?active", member.Active);
            comm.Parameters.AddWithValue("?comment", member.Comment);
            comm.Parameters.AddWithValue("?job", member.Job);
            comm.Parameters.AddWithValue("?mail", member.Mail);
            comm.Parameters.AddWithValue("?phone", member.Phone);
            comm.Parameters.AddWithValue("?address", member.Address);
            comm.Parameters.AddWithValue("?facebook", member.Facebook);
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

        public bool InsertPayments(Member member)
        {
            MySqlCommand comm;
            foreach (Payment pay in member.Payments)
            {
                comm = dbConn.CreateCommand();
                comm.CommandText = "INSERT INTO PAYMENTS(Amount, Type, receptionDate, Name, Debt, Bank, DepotDate ) VALUES(?amount, ?type, ?receptionDate, ?name, ?debt, ?Bank, ?DepotDate)";
                comm.Parameters.AddWithValue("?amount", pay.Amount);
                comm.Parameters.AddWithValue("?type", pay.Type);
                comm.Parameters.AddWithValue("?receptionDate", pay.ReceptionDate);
                comm.Parameters.AddWithValue("?name", pay.Name);
                comm.Parameters.AddWithValue("?debt", pay.Debt);
                comm.Parameters.AddWithValue("?Bank", pay.Bank.ToString());
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

        public bool InsertPrivate(Private priv)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.Prepare();
            comm.CommandText = "INSERT INTO PRIVATES(memberID, amount, date, bookedLessons, donelessons) VALUES(?memberID, ?amount, ?date, ?bookedLessons, ?donelessons)";
            comm.Parameters.AddWithValue("?memberID", priv.member.ID);
            comm.Parameters.AddWithValue("?date", priv.Date);
            comm.Parameters.AddWithValue("?amount", priv.Amount);
            comm.Parameters.AddWithValue("?bookedLessons", priv.BookedLessons);
            comm.Parameters.AddWithValue("?donelessons", priv.DoneLessons);

            comm.ExecuteNonQuery();

            comm = dbConn.CreateCommand();
            comm.CommandText = "SELECT LAST_INSERT_ID();";
            MySql.Data.MySqlClient.MySqlDataReader reader = comm.ExecuteReader();
            int id = 0;
            reader.Read();
            id = Convert.ToInt32(reader[0]);
            reader.Close();
            //dbConn.Open();
            priv.ID = id;
            return true;
        }
        public bool UpdatePrivate(Private priv)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "UPDATE PRIVATES SET memberID=?memberID, amount=?amount, date=?date, bookedLessons=?bookedLessons, donelessons=?donelessons WHERE ID=?ID";
            comm.Parameters.AddWithValue("?memberID", priv.member.ID);
            comm.Parameters.AddWithValue("?date", priv.Date);
            comm.Parameters.AddWithValue("?amount", priv.Amount);
            comm.Parameters.AddWithValue("?bookedLessons", priv.BookedLessons);
            comm.Parameters.AddWithValue("?donelessons", priv.DoneLessons);
            comm.Parameters.AddWithValue("?ID", priv.ID);
            comm.ExecuteNonQuery();

            return true;
        }
        public bool DeletePrivate(int privID)
        {
            //On delete le virement
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "DELETE FROM PRIVATES WHERE ID=?ID";
            comm.Parameters.AddWithValue("?ID", privID);
            comm.ExecuteNonQuery();
            return true;
        }

        public bool InsertRefund(Refund refund)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.Prepare();
            comm.CommandText = "INSERT INTO REFUNDS(label, amount, date, comment) VALUES(?label, ?amount, ?date, ?comment)";
            comm.Parameters.AddWithValue("?label", refund.Label);
            comm.Parameters.AddWithValue("?date", refund.Date);
            comm.Parameters.AddWithValue("?amount", refund.Amount);
            comm.Parameters.AddWithValue("?comment", refund.Comment);

            comm.ExecuteNonQuery();

            comm = dbConn.CreateCommand();
            comm.CommandText = "SELECT LAST_INSERT_ID();";
            MySql.Data.MySqlClient.MySqlDataReader reader = comm.ExecuteReader();
            int id = 0;
            reader.Read();
            id = Convert.ToInt32(reader[0]);
            reader.Close();
            //dbConn.Open();
            refund.ID = id;
            return true;
        }
        public bool UpdateRefund(Refund refund)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "UPDATE REFUNDS SET label=?label, amount=?amount, date=?date, comment=?comment WHERE ID=?ID";
            comm.Parameters.AddWithValue("?label", refund.Label);
            comm.Parameters.AddWithValue("?date", refund.Date);
            comm.Parameters.AddWithValue("?amount", refund.Amount);
            comm.Parameters.AddWithValue("?comment", refund.Comment);
            comm.Parameters.AddWithValue("?ID", refund.ID);
            comm.ExecuteNonQuery();

            return true;
        }
        public bool DeleteRefund(int refundID)
        {
            //On delete le virement
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "DELETE FROM REFUNDS WHERE ID=?ID";
            comm.Parameters.AddWithValue("?ID", refundID);
            comm.ExecuteNonQuery();
            return true;
        }

        public bool InsertCoachPayment(CoachPay pay)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.Prepare();
            comm.CommandText = "INSERT INTO COACHSPAYMENTS(month, memberID, lessons, pay, amount, date) VALUES(?month, ?memberID, ?lessons, ?pay, ?amount, ?date)";
            comm.Parameters.AddWithValue("?month", pay.Month);
            comm.Parameters.AddWithValue("?memberID", pay.Coach.ID);
            comm.Parameters.AddWithValue("?lessons", pay.Lessons);
            comm.Parameters.AddWithValue("?pay", pay.Pay);
            comm.Parameters.AddWithValue("?amount", pay.Amount);
            comm.Parameters.AddWithValue("?date", pay.Date);

            comm.ExecuteNonQuery();

            comm = dbConn.CreateCommand();
            comm.CommandText = "SELECT LAST_INSERT_ID();";
            MySql.Data.MySqlClient.MySqlDataReader reader = comm.ExecuteReader();
            int id = 0;
            reader.Read();
            id = Convert.ToInt32(reader[0]);    
            reader.Close();
            //dbConn.Open();
            pay.ID = id;
            return true;
        }
        public bool UpdateCoachPayment(CoachPay pay)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "UPDATE COACHSPAYMENTS SET month=?month, memberID=?memberID, lessons=?lessons, pay=?pay, amount=?amount, date=?date WHERE ID=?ID";
            comm.Parameters.AddWithValue("?month", pay.Month);
            comm.Parameters.AddWithValue("?memberID", pay.Coach.ID);
            comm.Parameters.AddWithValue("?lessons", pay.Lessons);
            comm.Parameters.AddWithValue("?pay", pay.Pay);
            comm.Parameters.AddWithValue("?amount", pay.Amount);
            comm.Parameters.AddWithValue("?date", pay.Date);
            comm.Parameters.AddWithValue("?ID", pay.ID);
            comm.ExecuteNonQuery();

            return true;
        }
    }
}
