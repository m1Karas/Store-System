namespace Store_System
{
    partial class MainSystem
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Show_Inventory = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Add_Item = new System.Windows.Forms.Button();
            this.New_Item = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Name_Product = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.ID_Product = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Checkout_3 = new System.Windows.Forms.ListBox();
            this.Checkout_2 = new System.Windows.Forms.ListBox();
            this.Price_Check = new System.Windows.Forms.Button();
            this.item_sale_cancel = new System.Windows.Forms.Button();
            this.total_output = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tally = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clear_2 = new System.Windows.Forms.Button();
            this.make_sale = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.prod_id = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 573);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.Show_Inventory);
            this.tabPage2.Controls.Add(this.Remove);
            this.tabPage2.Controls.Add(this.Clear);
            this.tabPage2.Controls.Add(this.Add_Item);
            this.tabPage2.Controls.Add(this.New_Item);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Quantity);
            this.tabPage2.Controls.Add(this.Description);
            this.tabPage2.Controls.Add(this.Price);
            this.tabPage2.Controls.Add(this.Name_Product);
            this.tabPage2.Controls.Add(this.Category);
            this.tabPage2.Controls.Add(this.ID_Product);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Input Item";
            // 
            // Show_Inventory
            // 
            this.Show_Inventory.Location = new System.Drawing.Point(94, 421);
            this.Show_Inventory.Name = "Show_Inventory";
            this.Show_Inventory.Size = new System.Drawing.Size(167, 69);
            this.Show_Inventory.TabIndex = 16;
            this.Show_Inventory.Text = "Show Inventory";
            this.Show_Inventory.UseVisualStyleBackColor = true;
            this.Show_Inventory.Click += new System.EventHandler(this.Show_Inventory_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(13, 351);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 15;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(257, 351);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add_Item
            // 
            this.Add_Item.Location = new System.Drawing.Point(175, 351);
            this.Add_Item.Name = "Add_Item";
            this.Add_Item.Size = new System.Drawing.Size(75, 23);
            this.Add_Item.TabIndex = 13;
            this.Add_Item.Text = "Add Item";
            this.Add_Item.UseVisualStyleBackColor = true;
            this.Add_Item.Click += new System.EventHandler(this.Add_Item_Click);
            // 
            // New_Item
            // 
            this.New_Item.Location = new System.Drawing.Point(94, 351);
            this.New_Item.Name = "New_Item";
            this.New_Item.Size = new System.Drawing.Size(75, 23);
            this.New_Item.TabIndex = 12;
            this.New_Item.Text = "New Item";
            this.New_Item.UseVisualStyleBackColor = true;
            this.New_Item.Click += new System.EventHandler(this.New_Item_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Catagory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Id";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(94, 96);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 20);
            this.Quantity.TabIndex = 5;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(94, 148);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(236, 166);
            this.Description.TabIndex = 4;
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(94, 122);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 3;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // Name_Product
            // 
            this.Name_Product.Location = new System.Drawing.Point(94, 44);
            this.Name_Product.Name = "Name_Product";
            this.Name_Product.Size = new System.Drawing.Size(236, 20);
            this.Name_Product.TabIndex = 2;
            this.Name_Product.TextChanged += new System.EventHandler(this.Name_Product_TextChanged);
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(94, 70);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(236, 20);
            this.Category.TabIndex = 1;
            this.Category.TextChanged += new System.EventHandler(this.Category_TextChanged);
            // 
            // ID_Product
            // 
            this.ID_Product.Location = new System.Drawing.Point(94, 18);
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Size = new System.Drawing.Size(100, 20);
            this.ID_Product.TabIndex = 0;
            this.ID_Product.TextChanged += new System.EventHandler(this.ID_Product_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.Checkout_3);
            this.tabPage3.Controls.Add(this.Checkout_2);
            this.tabPage3.Controls.Add(this.Price_Check);
            this.tabPage3.Controls.Add(this.item_sale_cancel);
            this.tabPage3.Controls.Add(this.total_output);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tally);
            this.tabPage3.Controls.Add(this.Checkout);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.clear_2);
            this.tabPage3.Controls.Add(this.make_sale);
            this.tabPage3.Controls.Add(this.value);
            this.tabPage3.Controls.Add(this.amount);
            this.tabPage3.Controls.Add(this.prod_id);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(386, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sale";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Id";
            // 
            // Checkout_3
            // 
            this.Checkout_3.FormattingEnabled = true;
            this.Checkout_3.Location = new System.Drawing.Point(246, 187);
            this.Checkout_3.Name = "Checkout_3";
            this.Checkout_3.Size = new System.Drawing.Size(91, 264);
            this.Checkout_3.TabIndex = 15;
            this.Checkout_3.SelectedIndexChanged += new System.EventHandler(this.Checkout_3_SelectedIndexChanged);
            // 
            // Checkout_2
            // 
            this.Checkout_2.FormattingEnabled = true;
            this.Checkout_2.Location = new System.Drawing.Point(141, 187);
            this.Checkout_2.Name = "Checkout_2";
            this.Checkout_2.Size = new System.Drawing.Size(98, 264);
            this.Checkout_2.TabIndex = 14;
            this.Checkout_2.SelectedIndexChanged += new System.EventHandler(this.Checkout_2_SelectedIndexChanged);
            // 
            // Price_Check
            // 
            this.Price_Check.Location = new System.Drawing.Point(223, 24);
            this.Price_Check.Name = "Price_Check";
            this.Price_Check.Size = new System.Drawing.Size(114, 33);
            this.Price_Check.TabIndex = 13;
            this.Price_Check.Text = "Price Check";
            this.Price_Check.UseVisualStyleBackColor = true;
            this.Price_Check.Click += new System.EventHandler(this.Price_Check_Click);
            // 
            // item_sale_cancel
            // 
            this.item_sale_cancel.Location = new System.Drawing.Point(223, 102);
            this.item_sale_cancel.Name = "item_sale_cancel";
            this.item_sale_cancel.Size = new System.Drawing.Size(114, 41);
            this.item_sale_cancel.TabIndex = 12;
            this.item_sale_cancel.Text = "Cancel";
            this.item_sale_cancel.UseVisualStyleBackColor = true;
            this.item_sale_cancel.Click += new System.EventHandler(this.item_sale_cancel_Click);
            // 
            // total_output
            // 
            this.total_output.Location = new System.Drawing.Point(116, 464);
            this.total_output.Name = "total_output";
            this.total_output.Size = new System.Drawing.Size(123, 20);
            this.total_output.TabIndex = 11;
            this.total_output.TextChanged += new System.EventHandler(this.total_output_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total";
            // 
            // tally
            // 
            this.tally.Location = new System.Drawing.Point(223, 63);
            this.tally.Name = "tally";
            this.tally.Size = new System.Drawing.Size(115, 33);
            this.tally.TabIndex = 9;
            this.tally.Text = "input";
            this.tally.UseVisualStyleBackColor = true;
            this.tally.Click += new System.EventHandler(this.tally_Click);
            // 
            // Checkout
            // 
            this.Checkout.FormattingEnabled = true;
            this.Checkout.Location = new System.Drawing.Point(48, 187);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(87, 264);
            this.Checkout.TabIndex = 8;
            this.Checkout.SelectedIndexChanged += new System.EventHandler(this.Checkout_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Product Id";
            // 
            // clear_2
            // 
            this.clear_2.Location = new System.Drawing.Point(262, 509);
            this.clear_2.Name = "clear_2";
            this.clear_2.Size = new System.Drawing.Size(75, 23);
            this.clear_2.TabIndex = 4;
            this.clear_2.Text = "Clear";
            this.clear_2.UseVisualStyleBackColor = true;
            this.clear_2.Click += new System.EventHandler(this.clear_2_Click);
            // 
            // make_sale
            // 
            this.make_sale.Location = new System.Drawing.Point(48, 509);
            this.make_sale.Name = "make_sale";
            this.make_sale.Size = new System.Drawing.Size(75, 23);
            this.make_sale.TabIndex = 3;
            this.make_sale.Text = "Sale";
            this.make_sale.UseVisualStyleBackColor = true;
            this.make_sale.Click += new System.EventHandler(this.make_sale_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(116, 100);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(100, 20);
            this.value.TabIndex = 2;
            this.value.TextChanged += new System.EventHandler(this.value_TextChanged);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(116, 63);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 1;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // prod_id
            // 
            this.prod_id.Location = new System.Drawing.Point(116, 24);
            this.prod_id.Name = "prod_id";
            this.prod_id.Size = new System.Drawing.Size(100, 20);
            this.prod_id.TabIndex = 0;
            this.prod_id.TextChanged += new System.EventHandler(this.prod_id_TextChanged);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(307, 660);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Store_System.Properties.Resources.Project_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 82);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(418, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainSystem";
            this.Text = "Main System";
            this.Load += new System.EventHandler(this.MainSystem_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Name_Product;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox ID_Product;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Add_Item;
        private System.Windows.Forms.Button New_Item;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear_2;
        private System.Windows.Forms.Button make_sale;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox prod_id;
        private System.Windows.Forms.Button Show_Inventory;
        private System.Windows.Forms.ListBox Checkout;
        private System.Windows.Forms.Button tally;
        private System.Windows.Forms.TextBox total_output;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button item_sale_cancel;
        private System.Windows.Forms.Button Price_Check;
        private System.Windows.Forms.ListBox Checkout_3;
        private System.Windows.Forms.ListBox Checkout_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

