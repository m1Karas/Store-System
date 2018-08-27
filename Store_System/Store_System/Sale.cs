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
    class Sale : Inventory
    {
        public float price;
        
        public float priceCheck(int prod_id, int quant)
        {
            price = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();

                conn.Open();

                command.CommandText = "SELECT Price FROM product WHERE ID_Product = '" + prod_id + "';";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   price = (float)reader["Price"];//int of quantity                   
                }

                price = price * quant;

                reader.Close();

                conn.Close();

                return price;
            }
            catch (Exception ex)
            {
                throw new Exception("Error MySQLConnection: " + ex.Message);
            }
        }
    
    }
}
