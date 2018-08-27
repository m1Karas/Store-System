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
    class Inventory : Account
    {
       /*inventory proceedures*/
        
        public void New_Item(int prod_id, string prod_name, string cat, int quant, float price, string desc)//creates a new listing on the database
        {
            
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();

                conn.Open();

                string insert = "INSERT INTO product VALUES("+ prod_id +", '" + cat + "', '" + prod_name + "', '"+ price + "', '"+ quant + "', '"+ desc +"' )";

                command = new MySqlCommand(insert, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error MySQLConnection: " + ex.Message);
            }
        }
        public void Add_item(int prod_id, int quant)//adds to the count of an already existing item in database
        {
            int Quantity = 0;
                    
            try
            {
               
                
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();

                conn.Open();

                command.CommandText = "SELECT Quantity_Product FROM product WHERE ID_Product = '" + prod_id + "';";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Quantity = (int)reader["Quantity_Product"];//int of quantity
                    Quantity += quant;
                }

                reader.Close();

                command.CommandText = "UPDATE product SET Quantity_Product = '" + Quantity + "' WHERE ID_Product = '" + prod_id + "';";
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error MySQLConnection: " + ex.Message);
            }
        }
        public void Remove_Item(int prod_id, int quant)//subtracts from the count of an already existing item in database
        {
            int Quantity = 0;

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();

                conn.Open();

                command.CommandText = "SELECT Quantity_Product FROM product WHERE ID_Product = '" + prod_id + "';";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Quantity = (int)reader["Quantity_Product"];//int of quantity
                    Quantity -= quant;
                }

                reader.Close();

                command.CommandText = "UPDATE product SET Quantity_Product = '" + Quantity + "' WHERE ID_Product = '" + prod_id + "';";
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
