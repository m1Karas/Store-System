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
    class Executive : Account
    {
        //One is access to this class
        public void newEmp(int emp_id, string name, string address, string phone, float salery, string ssn)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();

                conn.Open();

                string insert = "INSERT INTO employee VALUES(" + emp_id + ", '" + name + "', '" + address + "', '" + phone + "', '" + salery + "', '" + ssn + "' )";

                command = new MySqlCommand(insert, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error MySQLConnection: " + ex.Message);
            }
        }
        public void updateEmp(int emp_id, string name, string address, string phone, float salery, string ssn)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();

                conn.Open();

                command.CommandText = "UPDATE employee SET Name_Employee = '" + name + ",' Address = '" + address + ",'  Phone = '" + phone + ",' Salary = '" + salery + ",' SSN = '" + ssn + "' WHERE ID_Employee = '" + emp_id + "';";
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error MySQLConnection: " + ex.Message);
            }
        }
    
    }
}
