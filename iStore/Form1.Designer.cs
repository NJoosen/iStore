namespace iStore
{
    partial class Form1
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
            this.listViewProductOverview = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonFilter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonDeleteSupplier = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonEditCustomer = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.button3EditSupplier = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.comboBoxMainEditCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxMainEditProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxMainEditSupplier = new System.Windows.Forms.ComboBox();
            this.comboBoxMainEditCategory = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxMainCategory = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonShowOrderOverview = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProductOverview
            // 
            this.listViewProductOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.ProductDescription,
            this.ProductStock,
            this.ProductPrice});
            this.listViewProductOverview.Location = new System.Drawing.Point(6, 49);
            this.listViewProductOverview.Name = "listViewProductOverview";
            this.listViewProductOverview.Size = new System.Drawing.Size(646, 287);
            this.listViewProductOverview.TabIndex = 0;
            this.listViewProductOverview.UseCompatibleStateImageBehavior = false;
            this.listViewProductOverview.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 122;
            // 
            // ProductDescription
            // 
            this.ProductDescription.Text = "Description";
            this.ProductDescription.Width = 127;
            // 
            // ProductStock
            // 
            this.ProductStock.Text = "Stock";
            this.ProductStock.Width = 57;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Price";
            this.ProductPrice.Width = 51;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(218, 17);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(94, 26);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(122, 92);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(59, 24);
            this.buttonAddCategory.TabIndex = 3;
            this.buttonAddCategory.Text = "Add";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Location = new System.Drawing.Point(122, 151);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(59, 24);
            this.buttonAddSupplier.TabIndex = 4;
            this.buttonAddSupplier.Text = "Add Supplier";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(122, 210);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(59, 24);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(122, 269);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(59, 24);
            this.buttonAddCustomer.TabIndex = 6;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDeleteCustomer);
            this.groupBox1.Controls.Add(this.buttonDeleteProduct);
            this.groupBox1.Controls.Add(this.buttonDeleteSupplier);
            this.groupBox1.Controls.Add(this.buttonDeleteCategory);
            this.groupBox1.Controls.Add(this.buttonEditCustomer);
            this.groupBox1.Controls.Add(this.buttonEditProduct);
            this.groupBox1.Controls.Add(this.button3EditSupplier);
            this.groupBox1.Controls.Add(this.buttonEditCategory);
            this.groupBox1.Controls.Add(this.comboBoxMainEditCustomer);
            this.groupBox1.Controls.Add(this.comboBoxMainEditProduct);
            this.groupBox1.Controls.Add(this.comboBoxMainEditSupplier);
            this.groupBox1.Controls.Add(this.comboBoxMainEditCategory);
            this.groupBox1.Controls.Add(this.buttonAddCategory);
            this.groupBox1.Controls.Add(this.buttonAddCustomer);
            this.groupBox1.Controls.Add(this.buttonAddSupplier);
            this.groupBox1.Controls.Add(this.buttonAddProduct);
            this.groupBox1.Location = new System.Drawing.Point(677, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 301);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Store";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 48);
            this.label5.TabIndex = 22;
            this.label5.Text = "Instructions:  Click \"Add\" to create a new item\r\n                         Select " +
    "an item to \"Edit\" or \"Delete\"\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Supplier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Category:";
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(246, 268);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(61, 24);
            this.buttonDeleteCustomer.TabIndex = 17;
            this.buttonDeleteCustomer.Text = "Delete";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(246, 210);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(61, 24);
            this.buttonDeleteProduct.TabIndex = 16;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonDeleteSupplier
            // 
            this.buttonDeleteSupplier.Location = new System.Drawing.Point(246, 151);
            this.buttonDeleteSupplier.Name = "buttonDeleteSupplier";
            this.buttonDeleteSupplier.Size = new System.Drawing.Size(61, 24);
            this.buttonDeleteSupplier.TabIndex = 15;
            this.buttonDeleteSupplier.Text = "Delete";
            this.buttonDeleteSupplier.UseVisualStyleBackColor = true;
            this.buttonDeleteSupplier.Click += new System.EventHandler(this.buttonDeleteSupplier_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(246, 92);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(61, 24);
            this.buttonDeleteCategory.TabIndex = 14;
            this.buttonDeleteCategory.Text = "Delete";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Location = new System.Drawing.Point(187, 268);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(53, 24);
            this.buttonEditCustomer.TabIndex = 13;
            this.buttonEditCustomer.Text = "Edit Customer";
            this.buttonEditCustomer.UseVisualStyleBackColor = true;
            this.buttonEditCustomer.Click += new System.EventHandler(this.buttonEditCustomer_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(187, 210);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(53, 24);
            this.buttonEditProduct.TabIndex = 12;
            this.buttonEditProduct.Text = "Edit Product";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // button3EditSupplier
            // 
            this.button3EditSupplier.Location = new System.Drawing.Point(187, 151);
            this.button3EditSupplier.Name = "button3EditSupplier";
            this.button3EditSupplier.Size = new System.Drawing.Size(53, 24);
            this.button3EditSupplier.TabIndex = 11;
            this.button3EditSupplier.Text = "Edit Supplier";
            this.button3EditSupplier.UseVisualStyleBackColor = true;
            this.button3EditSupplier.Click += new System.EventHandler(this.button3EditSupplier_Click);
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Location = new System.Drawing.Point(187, 92);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(53, 24);
            this.buttonEditCategory.TabIndex = 10;
            this.buttonEditCategory.Text = "Edit";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // comboBoxMainEditCustomer
            // 
            this.comboBoxMainEditCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMainEditCustomer.FormattingEnabled = true;
            this.comboBoxMainEditCustomer.Location = new System.Drawing.Point(23, 268);
            this.comboBoxMainEditCustomer.Name = "comboBoxMainEditCustomer";
            this.comboBoxMainEditCustomer.Size = new System.Drawing.Size(87, 24);
            this.comboBoxMainEditCustomer.TabIndex = 9;
            // 
            // comboBoxMainEditProduct
            // 
            this.comboBoxMainEditProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMainEditProduct.FormattingEnabled = true;
            this.comboBoxMainEditProduct.Location = new System.Drawing.Point(23, 209);
            this.comboBoxMainEditProduct.Name = "comboBoxMainEditProduct";
            this.comboBoxMainEditProduct.Size = new System.Drawing.Size(87, 24);
            this.comboBoxMainEditProduct.TabIndex = 8;
            // 
            // comboBoxMainEditSupplier
            // 
            this.comboBoxMainEditSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMainEditSupplier.FormattingEnabled = true;
            this.comboBoxMainEditSupplier.Location = new System.Drawing.Point(23, 150);
            this.comboBoxMainEditSupplier.Name = "comboBoxMainEditSupplier";
            this.comboBoxMainEditSupplier.Size = new System.Drawing.Size(87, 24);
            this.comboBoxMainEditSupplier.TabIndex = 7;
            // 
            // comboBoxMainEditCategory
            // 
            this.comboBoxMainEditCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMainEditCategory.FormattingEnabled = true;
            this.comboBoxMainEditCategory.Location = new System.Drawing.Point(23, 91);
            this.comboBoxMainEditCategory.Name = "comboBoxMainEditCategory";
            this.comboBoxMainEditCategory.Size = new System.Drawing.Size(87, 24);
            this.comboBoxMainEditCategory.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonFilter);
            this.groupBox2.Controls.Add(this.comboBoxMainCategory);
            this.groupBox2.Controls.Add(this.listViewProductOverview);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 378);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product overview";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(577, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(471, 18);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearch.TabIndex = 4;
            // 
            // comboBoxMainCategory
            // 
            this.comboBoxMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMainCategory.FormattingEnabled = true;
            this.comboBoxMainCategory.Location = new System.Drawing.Point(78, 19);
            this.comboBoxMainCategory.Name = "comboBoxMainCategory";
            this.comboBoxMainCategory.Size = new System.Drawing.Size(134, 24);
            this.comboBoxMainCategory.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonShowOrderOverview);
            this.groupBox3.Controls.Add(this.buttonAddOrder);
            this.groupBox3.Location = new System.Drawing.Point(677, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orders";
            // 
            // buttonShowOrderOverview
            // 
            this.buttonShowOrderOverview.Location = new System.Drawing.Point(174, 14);
            this.buttonShowOrderOverview.Name = "buttonShowOrderOverview";
            this.buttonShowOrderOverview.Size = new System.Drawing.Size(133, 40);
            this.buttonShowOrderOverview.TabIndex = 1;
            this.buttonShowOrderOverview.Text = "Order Overview";
            this.buttonShowOrderOverview.UseVisualStyleBackColor = true;
            this.buttonShowOrderOverview.Click += new System.EventHandler(this.buttonShowOrderOverview_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(23, 14);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(145, 40);
            this.buttonAddOrder.TabIndex = 0;
            this.buttonAddOrder.Text = "Add Order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Category:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProductOverview;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductDescription;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxMainCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonShowOrderOverview;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.ComboBox comboBoxMainEditCustomer;
        private System.Windows.Forms.ComboBox comboBoxMainEditProduct;
        private System.Windows.Forms.ComboBox comboBoxMainEditSupplier;
        private System.Windows.Forms.ComboBox comboBoxMainEditCategory;
        private System.Windows.Forms.Button button3EditSupplier;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonEditCustomer;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonDeleteSupplier;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label6;
    }
}

