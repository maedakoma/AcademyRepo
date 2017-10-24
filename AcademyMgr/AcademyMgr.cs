using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AcademyMgr
{
    public class AcademyMgr
    {
        MySqlConnection dbConn;
        public void Open()
        {
            dbConn = new MySqlConnection("server=localhost;user id=admin;password=admin;database=academy;persistsecurityinfo=True");
            try
            {
                dbConn.Open();
            }
            catch (Exception erro)
            {
                //MessageBox.Show("Erro" + erro);
                //this.Close();
            }
        }

        public List<Member> getMembers()
        {
            List<Member> members = new List<Member>();

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from MEMBERS M left outer join members_payments MP on MP.MemberID = M.ID left outer join payments P on P.ID = MP.PaymentID ORDER BY lastname";

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            Member mem = new Member();
            while (reader.Read())
            {
                if ((mem.Firstname == reader["firstname"].ToString()) && (mem.Lastname == reader["lastname"].ToString()))
                {
                    Payment payment = new Payment();
                    payment.Amount = (int)reader["amount"];
                    payment.Debt = (int)reader["debt"];
                    payment.Type = reader["type"].ToString();
                    payment.Name = reader["name"].ToString();
                    mem.Payments.Add(payment);
                }
                else
                {
                    mem = new Member();
                    mem.ID = (int)reader["ID"];
                    mem.Firstname = reader["firstname"].ToString();
                    mem.Lastname = reader["lastname"].ToString();
                    mem.Belt = reader["belt"].ToString();
                    Payment payment = new Payment();
                    if (reader["amount"] != DBNull.Value)
                    {
                        payment.Amount = (int)reader["amount"];
                        payment.Debt = (int)reader["debt"];
                        payment.Name = reader["name"].ToString();
                        payment.Type = reader["type"].ToString();
                        mem.Payments.Add(payment);
                    }
                    members.Add(mem);
                }
            }
            
            return members;
        }
        public bool InsertMember(Member member)
        {
            MySqlCommand comm = dbConn.CreateCommand();
            comm.CommandText = "INSERT INTO MEMBERS(firstname, lastname, belt) VALUES(@firstname, @lastname, @belt)";
            comm.Parameters.Add("@firstname", member.Firstname);
            comm.Parameters.Add("@lastname", member.Lastname);
            comm.Parameters.Add("@belt", member.Belt);
            comm.ExecuteNonQuery();
            return true;
        }
    }
}
