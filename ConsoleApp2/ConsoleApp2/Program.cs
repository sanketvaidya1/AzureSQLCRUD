using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn;
            string strConn = "Server = tcp:azuresqlserverdev1.database.windows.net,1433; Initial Catalog = db1; Persist Security Info = False; User ID = sanket; Password = Learn@123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";

            conn = new SqlConnection(strConn);

            try 
            {
                conn.Open();

                string strCmd = "INSERT INTO Employee " +
                    "(EmpID, EmpName, Designation, Department, JoiningDate) " +
                    "VALUES" +
                    "(7, 'Sanket', 'Tech Lead', 'IT', GETDATE())";


                SqlCommand comm = new SqlCommand(strCmd, conn);
                comm.ExecuteNonQuery();
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            


        }
    }
}
