﻿namespace InventorySystem
{
    partial class Vendors
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VendorsGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsUpdated = new InventorySystem.VendorsUpdated();
            this.vendorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsDataSet = new InventorySystem.VendorsDataSet();
            this.vendorsTableAdapter1 = new InventorySystem.VendorsDataSetTableAdapters.VendorsTableAdapter();
            this.AddNewVendor = new System.Windows.Forms.Button();
            this.test_DatabaseDataSet1 = new InventorySystem.Test_DatabaseDataSet1();
            this.vendorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new InventorySystem.Test_DatabaseDataSet1TableAdapters.VendorsTableAdapter();
            this.vendorsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter2 = new InventorySystem.VendorsUpdatedTableAdapters.VendorsTableAdapter();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.vendorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 559);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::InventorySystem.Properties.Resources.DashboardIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "DASHBOARD";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::InventorySystem.Properties.Resources.ProductsIcon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "           PRODUCTS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::InventorySystem.Properties.Resources.StockIcon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = " STOCKS";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.StockButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::InventorySystem.Properties.Resources.VendorsIcon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "        VENDORS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::InventorySystem.Properties.Resources.CustomersIcon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "CUSTOMERS";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::InventorySystem.Properties.Resources.ProductsIcon;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 368);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(206, 67);
            this.button7.TabIndex = 20;
            this.button7.Text = "     TRENDS\r\n    (GRAPHS)";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::InventorySystem.Properties.Resources.LogOutIcon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 441);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 69);
            this.button6.TabIndex = 5;
            this.button6.Text = "      LOGOUT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 64);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "VENDORS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.Admin_Img;
            this.pictureBox1.Location = new System.Drawing.Point(1106, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1034, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // VendorsGridView
            // 
            this.VendorsGridView.AutoGenerateColumns = false;
            this.VendorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendorsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Stocks,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.addressDataGridViewTextBoxColumn});
            this.VendorsGridView.DataSource = this.vendorsBindingSource5;
            this.VendorsGridView.Location = new System.Drawing.Point(349, 164);
            this.VendorsGridView.Name = "VendorsGridView";
            this.VendorsGridView.Size = new System.Drawing.Size(645, 325);
            this.VendorsGridView.TabIndex = 4;
            this.VendorsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vendor Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vendor Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Stocks
            // 
            this.Stocks.DataPropertyName = "Stocks";
            this.Stocks.HeaderText = "Stocks";
            this.Stocks.Name = "Stocks";
            this.Stocks.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // vendorsBindingSource5
            // 
            this.vendorsBindingSource5.DataMember = "Vendors";
            this.vendorsBindingSource5.DataSource = this.vendorsUpdated;
            // 
            // vendorsUpdated
            // 
            this.vendorsUpdated.DataSetName = "VendorsUpdated";
            this.vendorsUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource2
            // 
            this.vendorsBindingSource2.DataMember = "Vendors";
            this.vendorsBindingSource2.DataSource = this.vendorsDataSet;
            // 
            // vendorsDataSet
            // 
            this.vendorsDataSet.DataSetName = "VendorsDataSet";
            this.vendorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsTableAdapter1
            // 
            this.vendorsTableAdapter1.ClearBeforeFill = true;
            // 
            // AddNewVendor
            // 
            this.AddNewVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewVendor.ForeColor = System.Drawing.Color.Gray;
            this.AddNewVendor.Image = global::InventorySystem.Properties.Resources.Plus_math_961;
            this.AddNewVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewVendor.Location = new System.Drawing.Point(731, 533);
            this.AddNewVendor.Name = "AddNewVendor";
            this.AddNewVendor.Size = new System.Drawing.Size(263, 54);
            this.AddNewVendor.TabIndex = 5;
            this.AddNewVendor.Text = "Add New Vendor";
            this.AddNewVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewVendor.UseVisualStyleBackColor = true;
            this.AddNewVendor.Click += new System.EventHandler(this.AddNewVendor_Click);
            // 
            // test_DatabaseDataSet1
            // 
            this.test_DatabaseDataSet1.DataSetName = "Test_DatabaseDataSet1";
            this.test_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource3
            // 
            this.vendorsBindingSource3.DataMember = "Vendors";
            this.vendorsBindingSource3.DataSource = this.test_DatabaseDataSet1;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsBindingSource4
            // 
            this.vendorsBindingSource4.DataMember = "Vendors";
            this.vendorsBindingSource4.DataSource = this.test_DatabaseDataSet1;
            // 
            // vendorsTableAdapter2
            // 
            this.vendorsTableAdapter2.ClearBeforeFill = true;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.ForeColor = System.Drawing.Color.Gray;
            this.Refreshbutton.Image = global::InventorySystem.Properties.Resources.Refresh;
            this.Refreshbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refreshbutton.Location = new System.Drawing.Point(385, 533);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(177, 54);
            this.Refreshbutton.TabIndex = 8;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click_1);
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            // 
            // Vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 704);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.AddNewVendor);
            this.Controls.Add(this.VendorsGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Vendors";
            this.Text = "Vendors";
            this.Load += new System.EventHandler(this.Vendors_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VendorsGridView;
        // private TestDevPDataSet1 testDevPDataSet1;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        // private TestDevPDataSet1TableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vendorsBindingSource1;
        private VendorsDataSet vendorsDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource2;
        private VendorsDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter1;
        private System.Windows.Forms.Button AddNewVendor;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.Button button7;
        private Test_DatabaseDataSet1 test_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource vendorsBindingSource3;
        private Test_DatabaseDataSet1TableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.BindingSource vendorsBindingSource4;
        private VendorsUpdated vendorsUpdated;
        private System.Windows.Forms.BindingSource vendorsBindingSource5;
        private VendorsUpdatedTableAdapters.VendorsTableAdapter vendorsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}