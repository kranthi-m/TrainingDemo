using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient; //sql server
using System.Data.OleDb; // oracle // access
using System.Configuration;
using System.Data.SqlClient;
//TFS - source repository - version..
//ADO - Active Data Object .. System.Data.SqlClient to talk to SQL database
/// <summary>
/// for SQL Sever DB, we need to use System.Data.SqlClient; where it contains SqlConnection, SqlCommand, SQLDataAdapator, SQLDataReader
/// for Oracle Server DB, we need to use System.Data.OleDb; where it contains OledbConnection, OledbCommand, OledbDataAdapator, OledbDataReader
/// </summary>

/// <summary>
/// 1. Connection to connect to DB
/// 2. query/command to SQL server
/// 3. Execute/run at the Database.
/// 4. we may fetch data for select , we will use DataSet (like mini database..it contains tables and relations) or DataReader
/// We have Connected And Disconnected Architecture in ADO.NET
/// -(Connected)DataReader- sequentially reads the data from db..only when db conn is open.
/// -(Disconnected)Dataset to get data from db and close db connection, later u can use dataset to filter or read and showcase results in app.
/// </summary>
namespace ADO.NetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                //string constr = ConfigurationManager.ConnectionStrings["MYDBConnection"].ConnectionString.ToString();
                //using (SqlConnection sqlcon = new SqlConnection(constr))
                //{

                //    sqlcon.Open();// conn open

                //    //hardcode to demo
                //    Console.WriteLine("Enter your EMP ID");
                //    int EmpID = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Enter your age");
                //    int age = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Enter your name");
                //    string name = Console.ReadLine();
                //    string address = "Hyderabad 500008 India";
                //    string cmdtext = "Insert into Employee (EmpID, Name, Age, Address) values (   " + EmpID + ",'" + name + "', " + age + ",'" + address + "' )";
                //    SqlCommand sqlcmd = new SqlCommand(cmdtext, sqlcon);

                //    sqlcmd.ExecuteNonQuery(); //executing the cmd..

                //    sqlcon.Close(); //closing the conn
                //}
                //Console.WriteLine("Record inserted successfully..");
                //Console.ReadLine();


                //-----------------------------

                string constr = ConfigurationManager.ConnectionStrings["MYDBConnection"].ConnectionString.ToString();
                SqlConnection SqlCon = new SqlConnection(constr); // cerate connection
                SqlCon.Open(); // open connection
                string cmdtext = "Select Age, Name , address from Employee order by name desc";
                SqlCommand SqlCmd = new SqlCommand(cmdtext,SqlCon);

                // Connected Database.........................
                SqlDataReader dr = SqlCmd.ExecuteReader();
                while (dr.Read())//sequential data fetching..
                {
                    Console.WriteLine(dr[0] + "," + dr[1] + "," + dr[2]);
                }
                SqlCon.Close();

                //--------Disconnected Model--------------------
                //    string connetionString = null;
                //    SqlConnection connection;
                //    SqlDataAdapter adapter = new SqlDataAdapter();
                //    DataSet ds = new DataSet();
                //    int i = 0;
                //    connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
                //    connection = new SqlConnection(connetionString);
                //    try
                //    {
                //        connection.Open();
                //        adapter.SelectCommand = new SqlCommand("Select Name from Employee", connection);
                //        adapter.Fill(ds); // fill dataset ..
                //        connection.Close();
                //        //after closing conn..reading data
                //        for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                //        {
                //          Console.WriteLine(ds.Tables[0].Rows[0].ItemArray[1].ToString());
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //      //  MessageBox.Show(ex.ToString());
                //    }
                //}
                //catch
                //{
                //    Console.WriteLine("Error Occured..");
                //}

            }

            catch (Exception ex)
            { }
}
    }
}