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
    public partial class Employee_List : Form
    {
        public Employee_List()
        {
            InitializeComponent();
        }

        private void Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.storeDataSet.employee);

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
