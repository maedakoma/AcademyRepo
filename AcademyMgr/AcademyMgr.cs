﻿using System;
using System.Collections.Generic;
using System.Globalization;
using MySql.Data.MySqlClient;
using RestSharp;

namespace AcademyMgr
{
    public class AcademyMgr
    {
        public static double CoefDebt = 0.6;
        public static int PlanAboDay = 7;
        public static int PlanPrivateDay = 5;
        MySqlConnection dbConn;
        public string apiKey = "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";
        public string apiURL = "https://api.sendinblue.com/v3/contacts";
        public static int ListCercle = 2;
        public static int ListStudentCercle = 8;
        public string activeStudentsMetric = "activeStudents";
        public string activeWhiteStudentsMetric = "activeWhiteStudents";
        public string activeBlueStudentsMetric = "activeBlueStudents";
        public string activePurpleStudentsMetric = "activePurpleStudents";
        public string activeBrownStudentsMetric = "activeBrownStudents";
        public string activeBlackStudentsMetric = "activeBlackStudents";

        //public string connectionString = "server=localhost;user id=root;password=iimg4jek;database=cercle";
        //public string connectionString = "server=ot22457-001.dbaas.ovh.net;port=35443;user id=cercle;password=iimg666JEK;database=CERCLE;connection timeout=600";
        public string connectionString = "server=35.205.127.92; user id=root;password=iimg4jek;database=cercle;connection timeout=300000";

        public void Initialize()
        {
            dbConn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            dbConn.Open();
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                //On verifie si il y a eu des prevelements a prendre en compte:
                DateTime lastConnectionDate = getLastConnectionDate();
                //Combien de fois on a passé le 5 du mois et pour chaque fois on ajoute un paiement
                //On part de la last connection date on increment le jour et à chaque 5 du mois, on ajoute les prelevements:
                lastConnectionDate = lastConnectionDate.AddDays(1);

                while (lastConnectionDate.Date <= DateTime.Now.Date)
                {
                    if (lastConnectionDate.Day == PlanAboDay)
                    {
                        //Ajout des prelevements pour les personnes concernées:
                        List<Member> members = getMembers(null, true);
                        foreach (Member member in members)
                        {
                            if (member.Active)
                            {
                                Payment pay = new Payment();
                                pay.Amount = (decimal)(member.AboPlan.Amount * 99) / 100;
                                pay.Debt = (decimal)(member.AboPlan.DebtPercentage * pay.Amount) / 100;
                                pay.Name = member.Fullname;
                                pay.Type = Payment.typeEnum.Prelev;
                                pay.prestationType = Payment.PrestationTypeEnum.Abo;
                                pay.ReceptionDate = lastConnectionDate;
                                pay.Bank = Payment.bankEnum.Academy;
                                pay.DepotDate = lastConnectionDate;
                                member.Payments.Add(pay);
                                UpdateMember(member, true);
                            }
                        }
                    }
                    if (lastConnectionDate.Day == PlanPrivateDay)
                    {
                        //Ajout des prelevements pour les personnes concernées:
                        List<Member> members = getMembers(null, null, true);
                        foreach (Member member in members)
                        {
                            Payment pay = new Payment();
                            pay.DepotDate = DateTime.Now;
                            pay.ReceptionDate = DateTime.Now;
                            decimal debt = (decimal)(member.PrivatePlan.Amount * 1) / 100;
                            if (debt > 2) debt = 2;
                            pay.Amount = (decimal)(member.PrivatePlan.Amount - debt);
                            pay.Debt = 0;
                            pay.Type = Payment.typeEnum.Prelev;
                            pay.Bank = Payment.bankEnum.Academy;
                            pay.Name = member.Fullname;
                            pay.prestationType = Payment.PrestationTypeEnum.Private;
                            member.Payments.Add(pay);
                            DeletePayments(member.ID);
                            InsertPayments(member);
                        }
                    }

                    lastConnectionDate = lastConnectionDate.AddDays(1);
                }
                //On met à jour la date de connection:
                updateLastConnectionDate();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public DateTime getLastConnectionDate()
        {
            DateTime date = DateTime.Now;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from SETTINGS WHERE keysettings=?key";
            cmd.Parameters.AddWithValue("key", "LastConnectDate");
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            date = Convert.ToDateTime(reader["Value"]);
            reader.Close();
            return date;
        }
        public void updateLastConnectionDate()
        {
            DateTime date = DateTime.Now;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "UPDATE SETTINGS SET Value=?value where keysettings=?key";
            cmd.Parameters.AddWithValue("key", "LastConnectDate");
            cmd.Parameters.AddWithValue("value", DateTime.Now.ToString());
            cmd.ExecuteNonQuery();
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
                refund.Amount = (decimal)reader["amount"];
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
            cmd.CommandText = "SELECT * from COACHSPAYMENTS C INNER JOIN MEMBERS M on M.ID=C.MemberID order by date desc";
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
                pay.Amount = (decimal)reader["Amount"];
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
            cmd.CommandText = "SELECT * from SEMINARS order by date";

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Seminar seminar = new Seminar();
                seminar.ID = (int)reader["ID"];
                seminar.Theme = reader["Theme"].ToString();
                seminar.Date = Convert.ToDateTime(reader["Date"]);
                seminar.WebMembers = (int)reader["WebMembers"];
                seminar.LocalMembers = (int)reader["LocalMembers"];
                seminar.Amount = (decimal)reader["amount"];
                seminar.Debt = (decimal)reader["Debt"];
                seminar.Comment = reader["comment"].ToString();

                seminars.Add(seminar);
            }
            reader.Close();
            return seminars;
        }
        public List<Plan> getPlans(Plan.typeEnum type)
        {
            List<Plan> plans = new List<Plan>();

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.Parameters.AddWithValue("?type", type.ToString());
            cmd.CommandText = "SELECT * from PLANS WHERE type=?type order by ID";

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Plan plan = new Plan();
                plan.ID = (int)reader["ID"];
                plan.Label = reader["label"].ToString();
                plan.Amount = (int)reader["amount"];
                plan.DebtPercentage = (int)reader["debtPercentage"];
                String sType = reader["type"].ToString();
                if (sType != String.Empty)
                {
                    plan.Type = (Plan.typeEnum)Enum.Parse(typeof(Plan.typeEnum), sType, true);
                }

                plans.Add(plan);
            }
            reader.Close();
            return plans;
        }
        public List<Private> getPrivates()
        {
            List<Private> privates = new List<Private>();

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT *, M.ID AS memberID from PRIVATES P inner join MEMBERS M on M.ID = P.memberID order by Lastname, date desc";

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Private priv = new Private();
                priv.ID = (int)reader["ID"];
                Member member = new Member();
                member.ID = (int)reader["MemberID"];
                member.Firstname = reader["Firstname"].ToString();
                member.Lastname = reader["Lastname"].ToString();
                priv.member = member;
                priv.Date = Convert.ToDateTime(reader["Date"]);
                priv.BookedLessons = (int)reader["bookedLessons"];
                priv.DoneLessons = (int)reader["doneLessons"];
                priv.Description = reader["description"].ToString();
                privates.Add(priv);
            }
            reader.Close();
            return privates;
        }
        public List<Member> getMembers(bool? coach = null, bool? planAbo = null, bool? planPriv = null)
        {
            List<Member> members = new List<Member>();

            MySqlCommand cmd = dbConn.CreateCommand();

            cmd.CommandText = "SELECT *, P.ID as paymentID, MS.Active as active, ABO.ID as aboid, ABO.amount as aboamount, " +
                "ABO.Label as abolabel, ABO.debtPercentage as abodebtPercentage, PRIVATE.ID as privateid, PRIVATE.amount as privateamount, PRIVATE.Label as privatelabel, " +
                "PRIVATE.debtPercentage as privatedebtPercentage from MEMBERS M inner join MEMBERS_STATUS MS on MS.MemberID = M.ID AND MS.Current=1 " +
                                "left outer join MEMBERS_PAYMENTS MP on MP.MemberID = M.ID " +
                                "left outer join PAYMENTS P on P.ID = MP.PaymentID " +
                                "left outer join PLANS ABO on ABO.ID = M.AboID " +
                                "left outer join PLANS PRIVATE on PRIVATE.ID = M.PrivateID";
            if (coach != null)
            {
                cmd.CommandText += " WHERE M.coach=?coach";
                int nCoach = 0;
                if (coach == true)
                {
                    nCoach = 1;
                }
                cmd.Parameters.AddWithValue("?coach", nCoach);
            }
            if (planAbo != null && planAbo == true)
            {
                cmd.CommandText += " WHERE M.aboID is not null";
            }
            if (planPriv != null && planPriv == true)
            {
                cmd.CommandText += " WHERE M.privateID is not null";
            }

            cmd.CommandText += " ORDER BY lastname, P.ID";
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            Member mem = new Member();
            while (reader.Read())
            {
                if ((mem.Firstname == reader["firstname"].ToString()) && (mem.Lastname == reader["lastname"].ToString()))
                {
                        Payment payment = new Payment();
                        payment.ID = (int)reader["paymentID"]; ;
                        payment.Amount = (decimal)reader["amount"];
                        payment.Debt = (decimal)reader["debt"];
                        String sType = reader["type"].ToString();
                        if (sType != String.Empty)
                        {
                            payment.Type = (Payment.typeEnum)Enum.Parse(typeof(Payment.typeEnum), sType, true);
                        }
                        String sprestationType = reader["prestationtype"].ToString();
                        if (sprestationType != String.Empty)
                        {
                            payment.prestationType = (Payment.PrestationTypeEnum)Enum.Parse(typeof(Payment.PrestationTypeEnum), sprestationType, true);
                        }
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
                    if (reader["creationdate"] != DBNull.Value)
                    {
                        mem.Creationdate = Convert.ToDateTime(reader["creationdate"]);
                    }
                    String sBelt = reader["belt"].ToString();
                    if (sBelt != String.Empty)
                    {
                        mem.Belt = (Member.beltEnum)Enum.Parse(typeof(Member.beltEnum), sBelt, true);
                    }
                    mem.Stripe = Convert.ToByte(reader["stripe"]);
                    String sGender = reader["gender"].ToString();
                    if (sGender != String.Empty)
                    {
                        mem.Gender = (Member.genderEnum)Enum.Parse(typeof(Member.genderEnum), sGender, true);
                    }
                    mem.Child = Convert.ToBoolean(reader["Child"]);
                    mem.Alert = Convert.ToBoolean(reader["Alert"]);
                    mem.FullYear = Convert.ToBoolean(reader["FullYear"]);
                    mem.Competitor = Convert.ToBoolean(reader["Competitor"]);
                    mem.Coach = Convert.ToBoolean(reader["Coach"]);
                    mem.Active = Convert.ToBoolean(reader["active"]);
                    mem.Comment = reader["comment"].ToString();
                    mem.Job = reader["job"].ToString();
                    mem.Mail = reader["mail"].ToString();
                    mem.Phone = reader["phone"].ToString();
                    mem.Address = reader["address"].ToString();
                    mem.Facebook = reader["facebook"].ToString();
                    if (reader["enddate"] != DBNull.Value && mem.AboPlan == null)
                    {
                        mem.Enddate = Convert.ToDateTime(reader["enddate"]);
                    }
                    Payment payment = new Payment();
                    if (reader["amount"] != DBNull.Value)
                    {
                        payment.ID = (int)reader["paymentID"];
                        payment.Amount = (decimal) reader["amount"];
                        payment.Debt = (decimal)reader["debt"];
                        payment.Name = reader["name"].ToString();
                        String sType = reader["type"].ToString();
                        if (sType != String.Empty)
                        {
                            payment.Type = (Payment.typeEnum)Enum.Parse(typeof(Payment.typeEnum), sType, true);
                        }
                        String sprestationType = reader["prestationtype"].ToString();
                        if (sprestationType != String.Empty)
                        {
                            payment.prestationType = (Payment.PrestationTypeEnum)Enum.Parse(typeof(Payment.PrestationTypeEnum), sprestationType, true);
                        }
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
                    if (reader["aboID"] != DBNull.Value)
                    {
                        Plan aboPlan = new Plan();
                        aboPlan.ID = (int)reader["aboID"];
                        aboPlan.Amount = (int)reader["aboamount"];
                        aboPlan.DebtPercentage = (int)reader["abodebtPercentage"];
                        aboPlan.Label = reader["abolabel"].ToString();
                        mem.AboPlan = aboPlan;
                    }
                    if (reader["privateID"] != DBNull.Value)
                    {
                        Plan privatePlan = new Plan();
                        privatePlan.ID = (int)reader["privateID"];
                        privatePlan.Amount = (int)reader["privateamount"];
                        privatePlan.DebtPercentage = (int)reader["privatedebtPercentage"];
                        privatePlan.Label = reader["privatelabel"].ToString();
                        mem.PrivatePlan = privatePlan;
                    }
                    members.Add(mem);
                }
            }
            reader.Close();
            return members;
        }
        public List<DateTime> getMembersHistoriesDates()
        {
            List<DateTime> dates = new List<DateTime>();
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT distinct date from MEMBERS_STATUS order by date";
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dates.Add(Convert.ToDateTime(reader["date"]));
            }
            reader.Close();
            return dates;
        }

        public List<Member> getMembersHistories(DateTime date, bool? coach = null)
        {
            List<Member> members = new List<Member>();

            MySqlCommand cmd = dbConn.CreateCommand();

            cmd.CommandText = "SELECT *, MS.Active as active from MEMBERS M " +
                                "inner join MEMBERS_STATUS MS on MS.MemberID = M.ID";

            if (coach != null)
            {
                cmd.CommandText += " WHERE M.coach=?coach";
                int nCoach = 0;
                if (coach == true)
                {
                    nCoach = 1;
                }
                cmd.Parameters.AddWithValue("?coach", nCoach);
            }

            cmd.CommandText += " order by lastname, firstname, MS.Date DESC";
            //dbConn.Open();
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            //dbConn.Close();
            Member mem = new Member();
            bool added = false;
            while (reader.Read())
            {
                if (Convert.ToDateTime(reader["date"]) > date)
                {
                    continue;
                }
                if ((mem.Firstname == reader["firstname"].ToString()) && (mem.Lastname == reader["lastname"].ToString()))
                {
                    if (added)
                    {
                        continue;
                    }
                }
                else
                {
                    added = false;
                }
                mem = new Member();
                mem.ID = (int)reader["ID"];
                mem.Firstname = reader["firstname"].ToString();
                mem.Lastname = reader["lastname"].ToString();
                if (Convert.ToBoolean(reader["active"]) == false)
                {
                    added = true;
                    continue;
                }
                mem.Active = Convert.ToBoolean(reader["active"]);
                members.Add(mem);
                added = true;
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
                cmd.CommandText = "SELECT * FROM PAYMENTS WHERE Bank<>'None' and type ='Check' ORDER BY depotdate DESC, type, bank, name";
            }
            else
            {
                cmd.CommandText = "SELECT * FROM PAYMENTS ORDER BY receptiondate DESC, type, name";
            }
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            Payment pay = new Payment();
            while (reader.Read())
            {
                Payment payment = new Payment();
                payment.ID = (int)reader["ID"];
                payment.Amount = (decimal)reader["amount"];
                payment.Debt = (decimal)reader["debt"];
                String sType = reader["type"].ToString();
                if (sType != String.Empty)
                {
                    payment.Type = (Payment.typeEnum)Enum.Parse(typeof(Payment.typeEnum), sType, true);
                }
                String sprestationType = reader["prestationtype"].ToString();
                if (sprestationType != String.Empty)
                {
                    payment.prestationType = (Payment.PrestationTypeEnum)Enum.Parse(typeof(Payment.PrestationTypeEnum), sprestationType, true);
                }
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

        public List<String> getNewStudents(DateTime sinceDate)
        {
            List<String> newStudents = new List<string>();
            MySqlCommand cmd = dbConn.CreateCommand();
            //dbConn.Open();
            cmd.CommandText = "SELECT DISTINCT FirstName, LastName from MEMBERS_STATUS MS INNER JOIN MEMBERS M on MS.memberID=M.ID where MS.current = 1 " +
                                "and MS.active=1 and MS.Date>?date and M.Coach=?coach and (M.fullyear=?fullyear OR M.aboID is not null)";
            cmd.Parameters.AddWithValue("?date", sinceDate);
            cmd.Parameters.AddWithValue("?coach", 0);
            cmd.Parameters.AddWithValue("?fullyear", 1);
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                newStudents.Add(reader["FirstName"].ToString() + " " + reader["LastName"].ToString());
            }
            reader.Close();
            return newStudents;
        }
        public List<String> getLostStudents(DateTime sinceDate)
        {
            List<String> lostStudents = new List<string>();
            MySqlCommand cmd = dbConn.CreateCommand();
            //dbConn.Open();
            cmd.CommandText = "SELECT DISTINCT FirstName, LastName from MEMBERS_STATUS MS INNER JOIN MEMBERS M on MS.memberID=M.ID " +
                "where MS.current = 1 and M.fullyear=1 and MS.active=0 and MS.Date>?date";
            cmd.Parameters.AddWithValue("?date", sinceDate);
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lostStudents.Add(reader["FirstName"].ToString() + " " + reader["LastName"].ToString());
            }
            reader.Close();
            return lostStudents;
        }

        public int getActiveStudentsCount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            //dbConn.Open();
            cmd.CommandText = "SELECT count(*) from MEMBERS_STATUS MS INNER JOIN MEMBERS M on MS.memberID=M.ID where MS.current = 1 and MS.active=1";
            object result = cmd.ExecuteScalar();
            int nCount = 0;
            if (result != DBNull.Value)
            {
                nCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return nCount;
        }
        public int getActiveStudentsCount(Member.beltEnum belt)
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT count(*) from MEMBERS M inner join MEMBERS_STATUS MS on MS.memberID=M.ID and MS.current = 1 where MS.active=1 and belt=?belt";
            cmd.Parameters.AddWithValue("?belt", belt.ToString());
            object result = cmd.ExecuteScalar();
            int nCount = 0;
            if (result != DBNull.Value)
            {
                nCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return nCount;
        }
        public int getActiveStudentsCompetitorCount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT count(*) from MEMBERS M inner join MEMBERS_STATUS MS on MS.memberID=M.ID and MS.current = 1 where MS.active=1 and competitor=?competitor";
            cmd.Parameters.AddWithValue("?competitor", true);
            object result = cmd.ExecuteScalar();
            int nCount = 0;
            if (result != DBNull.Value)
            {
                nCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return nCount;
        }
        public int getActiveStudentsFullYearCount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT count(*) from MEMBERS M inner join MEMBERS_STATUS MS on MS.memberID=M.ID and MS.current = 1 where MS.active=1 and fullyear=?fullyear";
            cmd.Parameters.AddWithValue("?fullyear", true);
            object result = cmd.ExecuteScalar();
            int nCount = 0;
            if (result != DBNull.Value)
            {
                nCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return nCount;
        }
        public int getActiveStudentsChildCount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT count(*) from MEMBERS M inner join MEMBERS_STATUS MS on MS.memberID=M.ID and MS.current = 1 where MS.active=1 and child=?child";
            cmd.Parameters.AddWithValue("?child", true);
            object result = cmd.ExecuteScalar();
            int nCount = 0;
            if (result != DBNull.Value)
            {
                nCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return nCount;
        }
        public decimal getLicencesAmount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from PAYMENTS WHERE prestationType=?prestationType";
            cmd.Parameters.AddWithValue("?prestationType", Payment.PrestationTypeEnum.Abo.ToString());
            object result = cmd.ExecuteScalar();
            decimal nAmount = 0;
            if (result != DBNull.Value)
            {
                nAmount = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return nAmount;
        }
        public decimal getLicencesDebt()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(debt) from PAYMENTS  WHERE prestationType=?prestationType";
            cmd.Parameters.AddWithValue("?prestationType", Payment.PrestationTypeEnum.Abo.ToString());
            object result = cmd.ExecuteScalar();
            decimal nAmount = 0;
            if (result != DBNull.Value)
            {
                nAmount = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return nAmount;
        }
        public decimal getPrivatesAmount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from PAYMENTS WHERE prestationType=?prestationType";
            cmd.Parameters.AddWithValue("?prestationType", Payment.PrestationTypeEnum.Private.ToString());
            object result = cmd.ExecuteScalar();
            decimal nAmount = 0;
            if (result != DBNull.Value)
            {
                nAmount = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return nAmount;
        }
        public decimal getSeminarsAmount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from SEMINARS";
            object result = cmd.ExecuteScalar();
            decimal nAmount = 0;
            if (result != DBNull.Value)
            {
                nAmount = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return nAmount;
        }
        public decimal getSeminarsDebt()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(debt) from SEMINARS";
            object result = cmd.ExecuteScalar();
            decimal nAmount = 0;
            if (result != DBNull.Value)
            {
                nAmount = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return nAmount;
        }
        public decimal getPaidDebt()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from REFUNDS";
            object result = cmd.ExecuteScalar();
            decimal nAmount = 0;
            if (result != DBNull.Value)
            {
                nAmount = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return nAmount;
        }
        public decimal getCoachsPaysAmount()
        {
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT SUM(amount) from COACHSPAYMENTS";
            object result = cmd.ExecuteScalar();
            decimal nAmount = 0;
            if (result != DBNull.Value)
            {
                nAmount = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return nAmount;
        }

        public void InsertMember(Member member)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                MySqlCommand comm = dbConn.CreateCommand();
                comm.Prepare();
                comm.CommandText = "INSERT INTO MEMBERS(firstname, lastname, enddate, creationDate, belt, stripe, gender, " +
                    "fullyear, child, alert, comment, job, mail, phone, address, facebook, coach, competitor, aboid, privateid) " +
                    "VALUES(?firstname, ?lastname, ?enddate, ?creationdate, ?belt, ?stripe, ?gender, ?fullyear, ?child, ?alert, " +
                    "?comment, ?job, ?mail, ?phone, ?address, ?facebook, ?coach, ?competitor, ?aboid, ?privateid)";
                comm.Parameters.AddWithValue("?firstname", CultureInfo.InvariantCulture.TextInfo.ToTitleCase(member.Firstname.ToLower()));
                comm.Parameters.AddWithValue("?lastname", member.Lastname.ToUpper());
                comm.Parameters.AddWithValue("?creationdate", DateTime.Now);
                comm.Parameters.AddWithValue("?belt", member.Belt.ToString());
                comm.Parameters.AddWithValue("?stripe", member.Stripe);
                comm.Parameters.AddWithValue("?gender", member.Gender.ToString());
                comm.Parameters.AddWithValue("?child", member.Child);
                comm.Parameters.AddWithValue("?alert", member.Alert);
                comm.Parameters.AddWithValue("?comment", member.Comment);
                comm.Parameters.AddWithValue("?job", member.Job);
                comm.Parameters.AddWithValue("?mail", member.Mail);
                comm.Parameters.AddWithValue("?phone", member.Phone);
                comm.Parameters.AddWithValue("?address", member.Address);
                comm.Parameters.AddWithValue("?facebook", member.Facebook);
                comm.Parameters.AddWithValue("?coach", member.Coach);
                comm.Parameters.AddWithValue("?competitor", member.Competitor);
                if (member.AboPlan != null)
                {
                    comm.Parameters.AddWithValue("?aboid", member.AboPlan.ID);
                    comm.Parameters.AddWithValue("?fullyear", true);
                    comm.Parameters.AddWithValue("?enddate", DateTime.MinValue);
                    member.Enddate = DateTime.MinValue;
                }
                else
                {
                    comm.Parameters.AddWithValue("?aboid", DBNull.Value);
                    comm.Parameters.AddWithValue("?fullyear", member.FullYear);
                    comm.Parameters.AddWithValue("?enddate", member.Enddate);
                }
                if (member.PrivatePlan != null)
                {
                    comm.Parameters.AddWithValue("?privateid", member.PrivatePlan.ID);
                }
                else
                {
                    comm.Parameters.AddWithValue("?privateid", DBNull.Value);
                }

                comm.ExecuteNonQuery();
                comm = dbConn.CreateCommand();
                comm.CommandText = "SELECT LAST_INSERT_ID();";
                MySql.Data.MySqlClient.MySqlDataReader reader = comm.ExecuteReader();
                int id = 0;
                reader.Read();
                id = Convert.ToInt32(reader[0]);
                reader.Close();
                member.ID = id;
                InsertStatus(member);
                InsertPayments(member);
                if (member.Mail != string.Empty && member.Active)
                {
                    InsertMailingList(member);
                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void UpdateMember(Member member, bool inTransaction = false)
        {
            MySqlTransaction transaction = null;
            if (!inTransaction) transaction= dbConn.BeginTransaction();
            try
            {
                if (!member.Active)
                {
                    bool bNotpaid = false;
                    //On verifie que tout a bien été encaissé:
                    foreach (Payment pay in member.Payments)
                    {
                        if ((pay.Type == Payment.typeEnum.Check) && (pay.Bank == Payment.bankEnum.None))
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
                comm.CommandText = "UPDATE MEMBERS SET firstname=?firstname, lastname=?lastname, enddate=?enddate, belt=?belt, stripe=?stripe, gender=?gender, " +
                    "child=?child, alert=?alert, fullyear=?fullyear, comment=?comment, job=?job, mail=?mail, " +
                    "phone=?phone, address=?address, facebook=?facebook, competitor=?competitor, coach=?coach, " +
                    "aboid=?aboid, privateid=?privateid  WHERE ID=?ID";

                comm.Parameters.AddWithValue("?firstname", CultureInfo.InvariantCulture.TextInfo.ToTitleCase(member.Firstname.ToLower()));
                comm.Parameters.AddWithValue("?lastname", member.Lastname.ToUpper());
                comm.Parameters.AddWithValue("?belt", member.Belt.ToString());
                comm.Parameters.AddWithValue("?stripe", member.Stripe);
                comm.Parameters.AddWithValue("?gender", member.Gender.ToString());
                comm.Parameters.AddWithValue("?child", member.Child);
                comm.Parameters.AddWithValue("?alert", member.Alert);
                comm.Parameters.AddWithValue("?comment", member.Comment);
                comm.Parameters.AddWithValue("?job", member.Job);
                comm.Parameters.AddWithValue("?mail", member.Mail);
                comm.Parameters.AddWithValue("?phone", member.Phone);
                comm.Parameters.AddWithValue("?address", member.Address);
                comm.Parameters.AddWithValue("?facebook", member.Facebook);
                comm.Parameters.AddWithValue("?competitor", member.Competitor);
                comm.Parameters.AddWithValue("?coach", member.Coach);

                if (member.AboPlan != null)
                {
                    comm.Parameters.AddWithValue("?aboid", member.AboPlan.ID);
                    comm.Parameters.AddWithValue("?fullyear", true);
                    comm.Parameters.AddWithValue("?enddate", DateTime.MinValue);
                }
                else if (member.Coach == true)
                {
                    comm.Parameters.AddWithValue("?aboid", DBNull.Value);
                    comm.Parameters.AddWithValue("?fullyear", true);
                    comm.Parameters.AddWithValue("?enddate", DateTime.MinValue);
                }
                else
                {
                    comm.Parameters.AddWithValue("?aboid", DBNull.Value);
                    comm.Parameters.AddWithValue("?fullyear", member.FullYear);
                    comm.Parameters.AddWithValue("?enddate", member.Enddate);
                }
                if (member.PrivatePlan != null)
                {
                    comm.Parameters.AddWithValue("?privateid", member.PrivatePlan.ID);
                }
                else
                {
                    comm.Parameters.AddWithValue("?privateid", DBNull.Value);
                }
                comm.Parameters.AddWithValue("?ID", member.ID);
                comm.ExecuteNonQuery();

                //On delete tous les paiements et on les rajoute tous:
                DeletePayments(member.ID);
                InsertPayments(member);

                //On met à jour le status si il a changé
                UpdateStatus(member);
                if (!inTransaction) transaction.Commit();
            }
            catch
            {
                if (!inTransaction) transaction.Rollback();
                throw;
            }
        }
        public void DeleteMember(int memberID)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                //On delete d'abord les paiements associés:
                DeletePayments(memberID);
                //On delete son status:
                DeleteStatus(memberID);
                //On delete le member
                MySqlCommand comm = dbConn.CreateCommand();
                comm.CommandText = "DELETE FROM MEMBERS WHERE ID=?ID";
                comm.Parameters.AddWithValue("?ID", memberID);
                comm.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        private void InsertStatus(Member member)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "UPDATE MEMBERS_STATUS SET Current = 0 WHERE MemberID= ?MemberID";
            comm.Parameters.AddWithValue("?MemberID", member.ID);
            comm.ExecuteNonQuery();
            comm = dbConn.CreateCommand();
            comm.CommandText = "INSERT INTO MEMBERS_STATUS(MemberID, Active, Date, Current ) VALUES(?MemberID, ?Active, ?Date, ?Current)";
            comm.Parameters.AddWithValue("?MemberID", member.ID);
            comm.Parameters.AddWithValue("?active", member.Active);
            comm.Parameters.AddWithValue("?Date", DateTime.Now);
            comm.Parameters.AddWithValue("?current", 1);
            comm.ExecuteNonQuery();
        }
        private void UpdateStatus(Member member)
        {
            //le status a t'il changé?
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT Active from MEMBERS_STATUS where memberID=?memberID and current = 1";
            cmd.Parameters.AddWithValue("?MemberID", member.ID);
            bool nCurrentActive = Convert.ToBoolean(cmd.ExecuteScalar());

            if (nCurrentActive != member.Active)
            {
                //Si oui:
                MySqlCommand comm = dbConn.CreateCommand();
                comm.CommandText = "UPDATE MEMBERS_STATUS SET Current = 0 WHERE MemberID=?MemberID";
                comm.Parameters.AddWithValue("?MemberID", member.ID);
                comm.ExecuteNonQuery();

                comm = dbConn.CreateCommand();
                comm.CommandText = "INSERT INTO MEMBERS_STATUS(MemberID, Active, Date, Current ) VALUES(?MemberID, ?Active, ?Date, ?Current)";
                comm.Parameters.AddWithValue("?MemberID", member.ID);
                comm.Parameters.AddWithValue("?active", member.Active);
                comm.Parameters.AddWithValue("?Date", DateTime.Now);
                comm.Parameters.AddWithValue("?current", 1);
                comm.ExecuteNonQuery();
            }
        }
        private void DeleteStatus(int memberID)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "DELETE FROM MEMBERS_STATUS WHERE MemberID=?MemberID";
            comm.Parameters.AddWithValue("?MemberID", memberID);
            comm.ExecuteNonQuery();
        }

        private void InsertMailingList(Member member)
        {
            //On test si le contact existe déja:
            int numericStatusCode;
            var client = new RestClient(apiURL + "/" + member.Mail);
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "application/json");
            request.AddHeader("api-key", apiKey);
            IRestResponse response = client.Execute(request);
            String parameters = "{\"listIds\":[" + ListCercle + ", " + ListStudentCercle +
                "],\"updateEnabled\":false,\"attributes\":{\"PRENOM\":\"" +
                member.Firstname + "\",\"NOM\":\"" + member.Lastname + "\"";

            if (member.Enddate != DateTime.MinValue)
            {
                parameters += ",\"FIN_ABO\":\"" + member.Enddate.ToString("yyyy-MM-dd") + "\"";
            }
            parameters += "}";

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //Le contact existe on maj les lists et les attributs:
                request = new RestRequest(Method.PUT);
                parameters += "}";
            }
            else
            {
                //le contact n'existe pas, on l'ajoute a la base et aux listes
                client = new RestClient(apiURL);
                request = new RestRequest(Method.POST);
                parameters += ",\"email\":\"" + member.Mail + "\"}";
            }
            request.AddParameter("application/json", parameters, ParameterType.RequestBody);
            request.AddHeader("api-key", apiKey);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            response = client.Execute(request);
            numericStatusCode = (int)response.StatusCode;
            if (200 > (numericStatusCode) || (numericStatusCode) >= 400)
            {
                throw new Exception(response.Content);
            }
        }

        private void InsertPayments(Member member)
        {

            MySqlCommand comm;
            foreach (Payment pay in member.Payments)
            {
                comm = dbConn.CreateCommand();
                comm.CommandText = "INSERT INTO PAYMENTS(Amount, Type, prestationType, receptionDate, Name, Debt, Bank, DepotDate ) VALUES(?amount, ?type, ?prestationtype, ?receptionDate, ?name, ?debt, ?Bank, ?DepotDate)";
                comm.Parameters.AddWithValue("?amount", pay.Amount);
                comm.Parameters.AddWithValue("?type", pay.Type.ToString());
                comm.Parameters.AddWithValue("?prestationType", pay.prestationType.ToString());
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
        }
        private void DeletePayments(int memberID)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "DELETE FROM MEMBERS_PAYMENTS WHERE MemberID=?MemberID";
            comm.Parameters.AddWithValue("?MemberID", memberID);
            comm.ExecuteNonQuery();

            //on supprime tous les paiements non liés a un membre
            comm = dbConn.CreateCommand();
            comm.CommandText = "DELETE P FROM PAYMENTS AS P WHERE P.ID NOT IN (SELECT PaymentID from MEMBERS_PAYMENTS)";
            comm.ExecuteNonQuery();
        }

        public void InsertPrivate(Private priv, bool inTransaction = false)
        {
            MySqlTransaction transaction = null;
            if (!inTransaction) transaction = dbConn.BeginTransaction();
            try
            {
                MySqlCommand comm = dbConn.CreateCommand();
                comm.Prepare();
                comm.CommandText = "INSERT INTO PRIVATES(memberID, date, bookedLessons, donelessons, description) VALUES(?memberID, ?date, ?bookedLessons, ?donelessons, ?description)";
                comm.Parameters.AddWithValue("?memberID", priv.member.ID);
                comm.Parameters.AddWithValue("?date", priv.Date);
                comm.Parameters.AddWithValue("?bookedLessons", priv.BookedLessons);
                comm.Parameters.AddWithValue("?donelessons", priv.DoneLessons);
                comm.Parameters.AddWithValue("?description", priv.Description);

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
                if (!inTransaction) transaction.Commit();
            }
            catch
            {
                if (!inTransaction) transaction.Rollback();
                throw;
            }
        }
        public void UpdatePrivate(Private priv)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                MySqlCommand comm = dbConn.CreateCommand();
                comm.CommandText = "UPDATE PRIVATES SET memberID=?memberID, date=?date, bookedLessons=?bookedLessons, donelessons=?donelessons, description=?description WHERE ID=?ID";
                comm.Parameters.AddWithValue("?memberID", priv.member.ID);
                comm.Parameters.AddWithValue("?date", priv.Date);
                comm.Parameters.AddWithValue("?bookedLessons", priv.BookedLessons);
                comm.Parameters.AddWithValue("?donelessons", priv.DoneLessons);
                comm.Parameters.AddWithValue("?description", priv.Description);
                comm.Parameters.AddWithValue("?ID", priv.ID);
                comm.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void DeletePrivate(int privID)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                //On delete le virement
                MySqlCommand comm = dbConn.CreateCommand();
                comm.CommandText = "DELETE FROM PRIVATES WHERE ID=?ID";
                comm.Parameters.AddWithValue("?ID", privID);
                comm.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void InsertSeminar(Seminar seminar)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                MySqlCommand comm = dbConn.CreateCommand();
                comm.Prepare();
                comm.CommandText = "INSERT INTO SEMINARS(theme, date, webMembers, LocalMembers, Amount, Debt, Comment) VALUES(?theme, ?date, ?webMembers, ?LocalMembers, ?Amount, ?Debt, ?Comment)";
                comm.Parameters.AddWithValue("?theme", seminar.Theme);
                comm.Parameters.AddWithValue("?date", seminar.Date);
                comm.Parameters.AddWithValue("?webmembers", seminar.WebMembers);
                comm.Parameters.AddWithValue("?localmembers", seminar.LocalMembers);
                comm.Parameters.AddWithValue("?amount", seminar.Amount);
                comm.Parameters.AddWithValue("?debt", seminar.Debt);
                comm.Parameters.AddWithValue("?comment", seminar.Comment);

                comm.ExecuteNonQuery();

                comm = dbConn.CreateCommand();
                comm.CommandText = "SELECT LAST_INSERT_ID();";
                MySql.Data.MySqlClient.MySqlDataReader reader = comm.ExecuteReader();
                int id = 0;
                reader.Read();
                id = Convert.ToInt32(reader[0]);
                reader.Close();
                //dbConn.Open();
                seminar.ID = id;
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void UpdateSeminar(Seminar seminar)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                MySqlCommand comm = dbConn.CreateCommand();
                comm.CommandText = "UPDATE SEMINARS SET theme=?theme, date=?date, webMembers=?webMembers, LocalMembers=?LocalMembers, Amount=?Amount, Debt=?Debt, Comment=?Comment WHERE ID=?ID";
                comm.Parameters.AddWithValue("?theme", seminar.Theme);
                comm.Parameters.AddWithValue("?date", seminar.Date);
                comm.Parameters.AddWithValue("?webmembers", seminar.WebMembers);
                comm.Parameters.AddWithValue("?localmembers", seminar.LocalMembers);
                comm.Parameters.AddWithValue("?amount", seminar.Amount);
                comm.Parameters.AddWithValue("?debt", seminar.Debt);
                comm.Parameters.AddWithValue("?comment", seminar.Comment);
                comm.Parameters.AddWithValue("?ID", seminar.ID);
                comm.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void DeleteSeminar(int seminarID)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                //On delete le virement
                MySqlCommand comm = dbConn.CreateCommand();
                comm.CommandText = "DELETE FROM SEMINARS WHERE ID=?ID";
                comm.Parameters.AddWithValue("?ID", seminarID);
                comm.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void InsertRefund(Refund refund)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
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
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void UpdateRefund(Refund refund)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                MySqlCommand comm = dbConn.CreateCommand();
                comm.CommandText = "UPDATE REFUNDS SET label=?label, amount=?amount, date=?date, comment=?comment WHERE ID=?ID";
                comm.Parameters.AddWithValue("?label", refund.Label);
                comm.Parameters.AddWithValue("?date", refund.Date);
                comm.Parameters.AddWithValue("?amount", refund.Amount);
                comm.Parameters.AddWithValue("?comment", refund.Comment);
                comm.Parameters.AddWithValue("?ID", refund.ID);
                comm.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void DeleteRefund(int refundID)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                //On delete le virement
                MySqlCommand comm = dbConn.CreateCommand();
                comm.CommandText = "DELETE FROM REFUNDS WHERE ID=?ID";
                comm.Parameters.AddWithValue("?ID", refundID);
                comm.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void InsertCoachPayment(CoachPay pay)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                MySqlCommand comm = dbConn.CreateCommand();
                comm.Prepare();
                comm.CommandText = "INSERT INTO COACHSPAYMENTS(month, memberID, lessons, pay, amount, date, comment) VALUES(?month, ?memberID, ?lessons, ?pay, ?amount, ?date, ?comment)";
                comm.Parameters.AddWithValue("?month", pay.Month);
                comm.Parameters.AddWithValue("?memberID", pay.Coach.ID);
                comm.Parameters.AddWithValue("?lessons", pay.Lessons);
                comm.Parameters.AddWithValue("?pay", pay.Pay);
                comm.Parameters.AddWithValue("?amount", pay.Amount);
                comm.Parameters.AddWithValue("?date", pay.Date);
                comm.Parameters.AddWithValue("?comment", pay.Comment);

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
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void UpdateCoachPayment(CoachPay pay)
        {
            MySqlTransaction transaction = dbConn.BeginTransaction();
            try
            {
                MySqlCommand comm = dbConn.CreateCommand();
                comm.CommandText = "UPDATE COACHSPAYMENTS SET month=?month, memberID=?memberID, lessons=?lessons, pay=?pay, amount=?amount, date=?date, comment=?comment WHERE ID=?ID";
                comm.Parameters.AddWithValue("?month", pay.Month);
                comm.Parameters.AddWithValue("?memberID", pay.Coach.ID);
                comm.Parameters.AddWithValue("?lessons", pay.Lessons);
                comm.Parameters.AddWithValue("?pay", pay.Pay);
                comm.Parameters.AddWithValue("?amount", pay.Amount);
                comm.Parameters.AddWithValue("?date", pay.Date);
                comm.Parameters.AddWithValue("?comment", pay.Comment);
                comm.Parameters.AddWithValue("?ID", pay.ID);
                comm.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

    }
}
