namespace iStore
{
    partial class OrderAddForm
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
            this.listViewShoppingCart = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrderCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOrderProduct = new System.Windows.Forms.ComboBox();
            this.numericUpDownOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddCart = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonOrderDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewShoppingCart
            // 
            this.listViewShoppingCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnProduct,
            this.columnPrice,
            this.columnAmount});
            this.listViewShoppingCart.Location = new System.Drawing.Point(27, 151);
            this.listViewShoppingCart.Name = "listViewShoppingCart";
            this.listViewShoppingCart.Size = new System.Drawing.Size(380, 278);
            this.listViewShoppingCart.TabIndex = 0;
            this.listViewShoppingCart.UseCompatibleStateImageBehavior = false;
            this.listViewShoppingCart.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            // 
            // columnProduct
            // 
            this.columnProduct.Text = "Product";
            this.columnProduct.Width = 124;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 107;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer:";
            // 
            // comboBoxOrderCustomer
            // 
            this.comboBoxOrderCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderCustomer.FormattingEnabled = true;
            this.comboBoxOrderCustomer.Location = new System.Drawing.Point(98, 22);
            this.comboBoxOrderCustomer.Name = "comboBoxOrderCustomer";
            this.comboBoxOrderCustomer.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOrderCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product:";
            // 
            // comboBoxOrderProduct
            // 
            this.comboBoxOrderProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderProduct.FormattingEnabled = true;
            this.comboBoxOrderProduct.Location = new System.Drawing.Point(98, 60);
            this.comboBoxOrderProduct.Name = "comboBoxOrderProduct";
            this.comboBoxOrderProduct.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOrderProduct.TabIndex = 4;
            // 
            // numericUpDownOrderAmount
            // 
            this.numericUpDownOrderAmount.Location = new System.Drawing.Point(287, 61);
            this.numericUpDownOrderAmount.Name = "numericUpDownOrderAmount";
            this.numericUpDownOrderAmount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownOrderAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add to cart:";
            // 
            // buttonAddCart
            // 
            this.buttonAddCart.Location = new System.Drawing.Point(111, 107);
            this.buttonAddCart.Name = "buttonAddCart";
            this.buttonAddCart.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCart.TabIndex = 8;
            this.buttonAddCart.Text = "Add";
            this.buttonAddCart.UseVisualStyleBackColor = true;
            this.buttonAddCart.Click += new System.EventHandler(this.buttonAddCart_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(314, 435);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(93, 23);
            this.buttonOrder.TabIndex = 9;
            this.buttonOrder.Text = "Place order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonOrderDelete
            // 
            this.buttonOrderDelete.Location = new System.Drawing.Point(30, 435);
            this.buttonOrderDelete.Name = "buttonOrderDelete";
            this.buttonOrderDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderDelete.TabIndex = 10;
            this.buttonOrderDelete.Text = "Delete";
            this.buttonOrderDelete.UseVisualStyleBackColor = true;
            this.buttonOrderDelete.Click += new System.EventHandler(this.buttonOrderDelete_Click);
            // 
            // OrderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 487);
            this.Controls.Add(this.buttonOrderDelete);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonAddCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownOrderAmount);
            this.Controls.Add(this.comboBoxOrderProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOrderCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewShoppingCart);
            this.Name = "OrderAddForm";
            this.Text = "OrderAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewShoppingCart;
        private System.Windows.Forms.ColumnHeader columnProduct;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrderCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOrderProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownOrderAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddCart;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.Button buttonOrderDelete;
    }
}