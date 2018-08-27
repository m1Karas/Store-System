using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Store_System
{
    public partial class MainSystem : Form
    {
        private int id, quant;
        private string prodName, cat, desc;
        private float price, convPrice, total, totalConvert;
        
        public MainSystem()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainSystem_Load(object sender, EventArgs e)
        {
         
        }

        private void ID_Product_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Name_Product_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Category_TextChanged(object sender, EventArgs e)
        {
            
        }             

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            
        } 
        
        private void New_Item_Click(object sender, EventArgs e)//creates a new listing on the database
        {
            id = Convert.ToInt32(ID_Product.Text);
            prodName = Name_Product.Text;
            cat = Category.Text;
            quant = Convert.ToInt32(Quantity.Text);
            price = float.Parse(Price.Text);
            desc = Description.Text;
            
            Inventory inv = new Inventory();
            inv.New_Item(id, prodName, cat, quant, price, desc);
        }

        private void Add_Item_Click(object sender, EventArgs e)//adds to the count of an already existing item in database
        {
            id = Convert.ToInt32(ID_Product.Text);           
            quant = Convert.ToInt32(Quantity.Text);        

            Inventory inv = new Inventory();
            inv.Add_item(id,quant);
        }

        private void Remove_Click(object sender, EventArgs e)//subtracts from the count of an already existing item in database
        {
            id = Convert.ToInt32(ID_Product.Text);
            quant = Convert.ToInt32(Quantity.Text);


            Inventory inv = new Inventory();
            inv.Remove_Item(id, quant);
        }
        
        private void Clear_Click(object sender, EventArgs e)
        {
            ID_Product.Text = "";
            Name_Product.Text = "";
            Category.Text = "";
            Quantity.Text = "";
            Price.Text = "";
            Description.Text = "";

        }

        private void Show_Inventory_Click(object sender, EventArgs e)
        {
            Inventory_Listing lfrm = new Inventory_Listing();
            lfrm.Show();
        }

        private void prod_id_TextChanged(object sender, EventArgs e)
        {

        }//sale product id

        private void amount_TextChanged(object sender, EventArgs e)
        {

        }//sale product quantity

        private void value_TextChanged(object sender, EventArgs e)//single product*quantity price
        {

        }
 
        private void Checkout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }        
        private void Checkout_2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Checkout_3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void total_output_TextChanged_1(object sender, EventArgs e)
        {

        }      
        
        private void make_sale_Click(object sender, EventArgs e)//makes the sales report
        {

        }        
        private void Price_Check_Click(object sender, EventArgs e)//check the price of item and quajntity
        {
            id = Convert.ToInt32(prod_id.Text);
            quant = Convert.ToInt32(amount.Text);
                        
            Sale sa = new Sale();

            price = sa.priceCheck(id, quant);

            convPrice = price;

            value.Text = Convert.ToString(convPrice);
        }
        private void tally_Click(object sender, EventArgs e)//add's items on check out
        {                                   
            id = Convert.ToInt32(prod_id.Text);
            quant = Convert.ToInt32(amount.Text);

            if (id == 0)
            {
                Sale_eror_1 saleEr1 = new Sale_eror_1();
                saleEr1.Show();
            }
            else 
            {
                Inventory inv = new Inventory();
                inv.Remove_Item(id, quant);

                total += price;
                totalConvert = total;

                total_output.Text = Convert.ToString(totalConvert);

                Checkout.Items.Add(id);
                Checkout_2.Items.Add(quant);
                Checkout_3.Items.Add(price);

                prod_id.Text = "";
                amount.Text = "";
                value.Text = "";
            }
            
        }
        
        private void clear_2_Click(object sender, EventArgs e)
        {
            prod_id.Text = "";
            amount.Text = "";
            value.Text = "";
            total_output.Text = "";
        }
        private void item_sale_cancel_Click(object sender, EventArgs e)
        {
            prod_id.Text = "";
            amount.Text = "";
            value.Text = "";
        }





       

        
    }
}
