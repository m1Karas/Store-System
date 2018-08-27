using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.Common;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace Store_System
{
    class Account
    {
         /*login proceedure*/
        
        public string UserName,connString = "host=localhost;user=root;password=r0drig0;database=store;";        
        public int accLevel;     
        public bool accountVerify =  false;
        
        private string pwd;

        public bool accountQuery(string name, string password)//method takes inputs and compares to list of known accounts to those inputs
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();                
                
                conn.Open();                               

                command.CommandText = "SELECT Password_User FROM account WHERE Name_User = '" + name + "';";//look on the row of the id for the password and level                

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    pwd = (string)reader["Password_User"];//int of password
                }

                conn.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Error MySQLConnection: " + ex.Message);
            }                      

            if (password == pwd)
            {
                UserName = name;//Defines the UserName variable so that other classes can use it. This method will allways go first when program runs to do this.
                accountVerify = true;
                return accountVerify;//return true
            }
            else
            {
                accountVerify = false;
                return accountVerify;//return false
            }
        }
        public int accountLevel(string name)//check the account level
        {
           
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();

                conn.Open();
                
                command.CommandText = "SELECT Lvl FROM account WHERE Name_User = '" + name + "';";

                MySqlDataReader reader = command.ExecuteReader();                               

                while (reader.Read())
                {
                    accLevel = (int)reader["Lvl"];//int of account level
                }
                conn.Close();
                return accLevel;
                
                
            }

            catch (Exception ex)
            {
                throw new Exception("Error MySQLConnection: " + ex.Message);
            }
           
        }
               
    }
}
