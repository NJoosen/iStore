namespace iStore
{
    partial class ProductAddOrEditForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.numericUpDownProductStock = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownProductPrice = new System.Windows.Forms.NumericUpDown();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.textBoxProductProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonProductSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxSupplier);
            this.groupBox1.Controls.Add(this.numericUpDownProductStock);
            this.groupBox1.Controls.Add(this.numericUpDownProductPrice);
            this.groupBox1.Controls.Add(this.textBoxProductDescription);
            this.groupBox1.Controls.Add(this.textBoxProductProduct);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Supplier";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(89, 57);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(179, 24);
            this.comboBoxSupplier.TabIndex = 12;
            // 
            // numericUpDownProductStock
            // 
            this.numericUpDownProductStock.Location = new System.Drawing.Point(89, 148);
            this.numericUpDownProductStock.Name = "numericUpDownProductStock";
            this.numericUpDownProductStock.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownProductStock.TabIndex = 11;
            // 
            // numericUpDownProductPrice
            // 
            this.numericUpDownProductPrice.Location = new System.Drawing.Point(89, 118);
            this.numericUpDownProductPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownProductPrice.Name = "numericUpDownProductPrice";
            this.numericUpDownProductPrice.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownProductPrice.TabIndex = 10;
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.Location = new System.Drawing.Point(89, 176);
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(179, 22);
            this.textBoxProductDescription.TabIndex = 9;
            // 
            // textBoxProductProduct
            // 
            this.textBoxProductProduct.Location = new System.Drawing.Point(89, 91);
            this.textBoxProductProduct.Name = "textBoxProductProduct";
            this.textBoxProductProduct.Size = new System.Drawing.Size(179, 22);
            this.textBoxProductProduct.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(89, 21);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(179, 24);
            this.comboBoxCategory.TabIndex = 0;
            // 
            // buttonProductSave
            // 
            this.buttonProductSave.Location = new System.Drawing.Point(116, 261);
            this.buttonProductSave.Name = "buttonProductSave";
            this.buttonProductSave.Size = new System.Drawing.Size(75, 23);
            this.buttonProductSave.TabIndex = 1;
            this.buttonProductSave.Text = "Save";
            this.buttonProductSave.UseVisualStyleBackColor = true;
            this.buttonProductSave.Click += new System.EventHandler(this.buttonProductSave_Click);
            // 
            // ProductAddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 314);
            this.Controls.Add(this.buttonProductSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductAddOrEditForm";
            this.Text = "ProductAddOrEditForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxProductDescription;
        private System.Windows.Forms.TextBox textBoxProductProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonProductSave;
        private System.Windows.Forms.NumericUpDown numericUpDownProductStock;
        private System.Windows.Forms.NumericUpDown numericUpDownProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
    }
}