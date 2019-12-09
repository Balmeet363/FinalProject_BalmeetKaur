using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace Finalproject_BalmeetKaur
{

    // Creating class named listpages Christine I read pdf later that there should be class named database.cs but i made with named listpages.cs 
    // and after that it was difficult to change name everywhere
    public class listpages
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return ""; } }
        private static string Database { get { return "listpages"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        public void Addpage( page new_page)
        {
            //getting data into strings as Christine told in class
            // In database I have  table with column pagetitle and pagebody
            string query = "insert into page1  (pagetitle, pagebody) values ('{0}','{1}')";
            query = String.Format(query, new_page.Gettitle(), new_page.Getquote());

 
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public List<Dictionary<String, String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

           
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);
                //open the db connection
                Connect.Open();
                //give the connection a query
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();


                //for every row in the result set
                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    //for every column in the row
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }//end row
                resultset.Close();


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }


       //Creating method to delete page
        public void DeletePage(int pageid)
        {
            // delete everything from page1 table pageid matches
            string removepage = "delete from page1 where pageid ="+pageid;
            removepage = String.Format(removepage, pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            
            //This command removes the particular page from the table
            MySqlCommand cmd_removepage = new MySqlCommand(removepage, Connect);
            try
            {
                //try to execute both commands!
                Connect.Open();
              
                
                //then delete the main record
                cmd_removepage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removepage);
            }
            catch (Exception ex)
            {

                Debug.WriteLine("Something went wrong in the delete page Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void UpdatePage(int pageid, page new_page)
        {
            // getting data into query and updating respective fields
            string query = "update page1 set pagetitle='{0}', pagebody='{1}' where pageid="+pageid;
            query = String.Format(query, new_page.Gettitle(), new_page.Getquote(),pageid);
         

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {

                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {

                Debug.WriteLine("Something went wrong in the UpdateStudent Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

    }
}