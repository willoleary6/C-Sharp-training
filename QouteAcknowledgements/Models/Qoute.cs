using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

// importing mysql client
using MySql.Data.MySqlClient;


namespace QouteAcknowledgements.Models
{
    public class Qoute
    {
        public int QouteID { get; set; }
        public bool QuoteAcknowledment { get; set; }
        public string QouteText { get; set; }

    }

    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "127.0.0.1";
            database = "dotnettraining";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Debug.Write("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Debug.Write("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.Write(ex.Message);
                return false;
            }
        }


        public List<Qoute> getUnacknowledgedQuotes()
        {
            string query = "SELECT * FROM qoutes where acknowledged = 0";

            //Create a list to store the result
            List<Qoute> list = new List<Qoute>();
          

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    // temporary variable for readabilty
                    Qoute newQuote = new Qoute { 
                        QouteID = (int) dataReader["id"], 
                        QouteText = (string) dataReader["quote"], 
                        QuoteAcknowledment = (bool)dataReader["acknowledged"] 
                    };
                    list.Add(newQuote);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<Qoute> getAcknowledgedQuotes()
        {
            string query = "SELECT * FROM qoutes where acknowledged = 1";

            //Create a list to store the result
            List<Qoute> list = new List<Qoute>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    // temporary variable for readabilty
                    Qoute newQuote = new Qoute
                    {
                        QouteID = (int)dataReader["id"],
                        QouteText = (string)dataReader["quote"],
                        QuoteAcknowledment = (bool)dataReader["acknowledged"]
                    };
                    list.Add(newQuote);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public void resetQuotes()
        {
            string query = "UPDATE qoutes SET acknowledged = 0";

           

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                cmd.ExecuteReader();
              
                

                //close Connection
                this.CloseConnection();

                //return list to be displayed
               
            }
        }



        public void acknowledgeQuote(int id)
        {
            string query = "UPDATE qoutes SET acknowledged = 1 where id = "+id;



            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                cmd.ExecuteReader();

                //close Connection
                this.CloseConnection();

               

            }
        }

    }

        public class QouteDBContext: DbContext
        {
        private List<Qoute> unacknowledgedQoutes;
        private List<Qoute> acknowledgedQoutes;

        public List<Qoute> UnacknowledgedQoutes { get => unacknowledgedQoutes; set => unacknowledgedQoutes = value; }
        public List<Qoute> AcknowledgedQoutes { get => acknowledgedQoutes; set => acknowledgedQoutes = value; }

        /* constructor that populates the qoutes dbset */
        public QouteDBContext()
            {


            DBConnect connectionToDatabase = new DBConnect();
            List<Qoute> listOfUnAcknowledgedQoutes = connectionToDatabase.getUnacknowledgedQuotes();
            List<Qoute> listOfAcknowledgedQoutes = connectionToDatabase.getAcknowledgedQuotes();

            UnacknowledgedQoutes = listOfUnAcknowledgedQoutes;
            acknowledgedQoutes = listOfAcknowledgedQoutes;
                //UnacknowledgedQoutes.Add(TestQuote);
                this.SaveChanges();
            }

            public void reset()
            {
                DBConnect connectionToDatabase = new DBConnect();
                connectionToDatabase.resetQuotes();
            }

            public void acknowledgeQuote(int id)
            {
                DBConnect connectionToDatabase = new DBConnect();
                connectionToDatabase.acknowledgeQuote(id);
            }
    }
  

}
