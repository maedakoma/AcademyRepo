using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMgr
{
    public class AcademyMgr
    {
        public List<Member> getMembers()
        {
            List<Member> members = new List<Member>();

            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=admin;password=admin;database=academy;persistsecurityinfo=True");
            MySql.Data.MySqlClient.MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from MEMBERS M left outer join members_payments MP on MP.MemberID = M.ID left outer join payments P on P.ID = MP.PaymentID ORDER BY lastname";
            try
            {
                dbConn.Open();
            }
            catch (Exception erro)
            {
                //MessageBox.Show("Erro" + erro);
                //this.Close();
            }

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            Member mem = new Member();
            while (reader.Read())
            {
                if ((mem.Firstname == reader["firstname"].ToString()) && (mem.Lastname == reader["lastname"].ToString()))
                {
                    Payment payment = new Payment();
                    payment.Amount = (int)reader["amount"];
                    payment.Type = reader["type"].ToString();
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
                        payment.Type = reader["type"].ToString();
                        mem.Payments.Add(payment);
                    }
                    members.Add(mem);
                }
            }
            
            return members;
        }
    }
}
