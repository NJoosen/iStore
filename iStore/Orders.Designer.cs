namespace iStore
{
    partial class Orders
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewOrderOverview = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewOrderOverview);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OrderOverview";
            // 
            // listViewOrderOverview
            // 
            this.listViewOrderOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.ProductName,
            this.ProductPrice,
            this.OrderQuantity,
            this.CustomerFirstname,
            this.CustomerLastName,
            this.OrderDate});
            this.listViewOrderOverview.Location = new System.Drawing.Point(6, 21);
            this.listViewOrderOverview.Name = "listViewOrderOverview";
            this.listViewOrderOverview.Size = new System.Drawing.Size(835, 362);
            this.listViewOrderOverview.TabIndex = 0;
            this.listViewOrderOverview.UseCompatibleStateImageBehavior = false;
            this.listViewOrderOverview.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "OrderID";
            this.OrderID.Width = 86;
            // 
            // ProductName
            // 
            this.ProductName.Text = "ProductName";
            this.ProductName.Width = 117;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "ProductPrice";
            this.ProductPrice.Width = 111;
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.Text = "OrderQuantity";
            this.OrderQuantity.Width = 122;
            // 
            // CustomerFirstname
            // 
            this.CustomerFirstname.Text = "CustomerFirstName";
            this.CustomerFirstname.Width = 145;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.Text = "CustomerLastname";
            this.CustomerLastName.Width = 139;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "OrderDate";
            this.OrderDate.Width = 109;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 413);
            this.Controls.Add(this.groupBox1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewOrderOverview;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader OrderQuantity;
        private System.Windows.Forms.ColumnHeader CustomerFirstname;
        private System.Windows.Forms.ColumnHeader CustomerLastName;
        private System.Windows.Forms.ColumnHeader OrderDate;
    }
}