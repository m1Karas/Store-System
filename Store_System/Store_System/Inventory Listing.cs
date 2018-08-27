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
    public partial class Inventory_Listing : Form
    {
        public Inventory_Listing()
        {
            InitializeComponent();
        }

        private void Inventory_Listing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.storeDataSet1.product);
            // TODO: This line of code loads data into the 'storeDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.storeDataSet.product);

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inventory_Listing_Load_2(object sender, EventArgs e)
        {

        }
    }
}
