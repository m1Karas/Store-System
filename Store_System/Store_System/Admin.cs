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
    public partial class Admin : Form
    {
        private int id;
        private float sal;
        private string na, add, phon, ss;
        
        public Admin()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goto_saleRep_listing_Click(object sender, EventArgs e)
        {
            Sales_reports sRep = new Sales_reports();
            sRep.Show();
        }

        private void emp_list_show_Click(object sender, EventArgs e)
        {
            Employee_List empL = new Employee_List();
            empL.Show();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            emp_id.Text = "";
            name.Text = "";
            address.Text = "";
            phone.Text = "";
            salery.Text = "";
            ssn.Text = "";
        }

        private void New_emp_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(emp_id.Text);
            na = name.Text;
            add = address.Text;
            phon = phone.Text;
            sal = float.Parse(salery.Text);
            ss = ssn.Text;
            
            Executive exec = new Executive();
            exec.newEmp(id, na, add, phon, sal, ss);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(emp_id.Text);
            na = name.Text;
            add = address.Text;
            phon = phone.Text;
            sal = float.Parse(salery.Text);
            ss = ssn.Text;
            
            Executive exec = new Executive();
            exec.updateEmp(id, na, add, phon, sal, ss);
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void emp_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void salery_TextChanged(object sender, EventArgs e)
        {

        }

        private void ssn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
