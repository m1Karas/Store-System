namespace Store_System
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.goto_saleRep_listing = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.emp_list_show = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.New_emp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ssn = new System.Windows.Forms.TextBox();
            this.salery = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.emp_id = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.goto_saleRep_listing);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(398, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales Reports";
            // 
            // goto_saleRep_listing
            // 
            this.goto_saleRep_listing.Location = new System.Drawing.Point(97, 78);
            this.goto_saleRep_listing.Name = "goto_saleRep_listing";
            this.goto_saleRep_listing.Size = new System.Drawing.Size(179, 90);
            this.goto_saleRep_listing.TabIndex = 0;
            this.goto_saleRep_listing.Text = "Sales Reports";
            this.goto_saleRep_listing.UseVisualStyleBackColor = true;
            this.goto_saleRep_listing.Click += new System.EventHandler(this.goto_saleRep_listing_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.emp_list_show);
            this.tabPage2.Controls.Add(this.clear);
            this.tabPage2.Controls.Add(this.delete);
            this.tabPage2.Controls.Add(this.edit);
            this.tabPage2.Controls.Add(this.New_emp);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ssn);
            this.tabPage2.Controls.Add(this.salery);
            this.tabPage2.Controls.Add(this.phone);
            this.tabPage2.Controls.Add(this.address);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Controls.Add(this.emp_id);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees";
            // 
            // emp_list_show
            // 
            this.emp_list_show.Location = new System.Drawing.Point(241, 191);
            this.emp_list_show.Name = "emp_list_show";
            this.emp_list_show.Size = new System.Drawing.Size(100, 41);
            this.emp_list_show.TabIndex = 16;
            this.emp_list_show.Text = "Employee List";
            this.emp_list_show.UseVisualStyleBackColor = true;
            this.emp_list_show.Click += new System.EventHandler(this.emp_list_show_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(255, 142);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 15;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(255, 61);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(255, 34);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 13;
            this.edit.Text = "Update";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // New_emp
            // 
            this.New_emp.Location = new System.Drawing.Point(255, 7);
            this.New_emp.Name = "New_emp";
            this.New_emp.Size = new System.Drawing.Size(75, 23);
            this.New_emp.TabIndex = 12;
            this.New_emp.Text = "New Emp";
            this.New_emp.UseVisualStyleBackColor = true;
            this.New_emp.Click += new System.EventHandler(this.New_emp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "SSN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Id";
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(81, 142);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(100, 20);
            this.ssn.TabIndex = 5;
            this.ssn.TextChanged += new System.EventHandler(this.ssn_TextChanged);
            // 
            // salery
            // 
            this.salery.Location = new System.Drawing.Point(81, 116);
            this.salery.Name = "salery";
            this.salery.Size = new System.Drawing.Size(100, 20);
            this.salery.TabIndex = 4;
            this.salery.TextChanged += new System.EventHandler(this.salery_TextChanged);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(81, 86);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 3;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(81, 60);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 2;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(81, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // emp_id
            // 
            this.emp_id.Location = new System.Drawing.Point(81, 6);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(100, 20);
            this.emp_id.TabIndex = 0;
            this.emp_id.TextChanged += new System.EventHandler(this.emp_id_TextChanged);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(326, 376);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Store_System.Properties.Resources.Project_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 86);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(413, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button goto_saleRep_listing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.TextBox salery;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox emp_id;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button New_emp;
        private System.Windows.Forms.Button emp_list_show;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}