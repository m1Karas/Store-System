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
    public partial class Sales_reports : Form
    {
        public Sales_reports()
        {
            InitializeComponent();
        }

        private void Sales_reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.sellhasproduct' table. You can move, or remove it, as needed.
            this.sellhasproductTableAdapter.Fill(this.storeDataSet.sellhasproduct);
            // TODO: This line of code loads data into the 'storeDataSet.sell' table. You can move, or remove it, as needed.
            this.sellTableAdapter.Fill(this.storeDataSet.sell);

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
