namespace iStore
{
    partial class CustomersAddOrEditForm
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
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.numericUpDownCustomerPhoneNumber = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomerAdress = new System.Windows.Forms.TextBox();
            this.textBoxCustomerEmail = new System.Windows.Forms.TextBox();
            this.textBoxCustomerLastName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerFirstName = new System.Windows.Forms.TextBox();
            this.labelCustomerAdress = new System.Windows.Forms.Label();
            this.labelCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.labelCustomerEmail = new System.Windows.Forms.Label();
            this.labelCustomerLastName = new System.Windows.Forms.Label();
            this.labelCustomerFirstName = new System.Windows.Forms.Label();
            this.buttonCustomerSave = new System.Windows.Forms.Button();
            this.groupBoxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomerPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.numericUpDownCustomerPhoneNumber);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerAdress);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerEmail);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerLastName);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerFirstName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerAdress);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerPhoneNumber);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerEmail);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerLastName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerFirstName);
            this.groupBoxCustomer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(266, 180);
            this.groupBoxCustomer.TabIndex = 0;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer";
            // 
            // numericUpDownCustomerPhoneNumber
            // 
            this.numericUpDownCustomerPhoneNumber.Location = new System.Drawing.Point(134, 105);
            this.numericUpDownCustomerPhoneNumber.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownCustomerPhoneNumber.Name = "numericUpDownCustomerPhoneNumber";
            this.numericUpDownCustomerPhoneNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCustomerPhoneNumber.TabIndex = 10;
            // 
            // textBoxCustomerAdress
            // 
            this.textBoxCustomerAdress.Location = new System.Drawing.Point(134, 134);
            this.textBoxCustomerAdress.Name = "textBoxCustomerAdress";
            this.textBoxCustomerAdress.Size = new System.Drawing.Size(120, 22);
            this.textBoxCustomerAdress.TabIndex = 9;
            // 
            // textBoxCustomerEmail
            // 
            this.textBoxCustomerEmail.Location = new System.Drawing.Point(134, 78);
            this.textBoxCustomerEmail.Name = "textBoxCustomerEmail";
            this.textBoxCustomerEmail.Size = new System.Drawing.Size(120, 22);
            this.textBoxCustomerEmail.TabIndex = 7;
            // 
            // textBoxCustomerLastName
            // 
            this.textBoxCustomerLastName.Location = new System.Drawing.Point(134, 50);
            this.textBoxCustomerLastName.Name = "textBoxCustomerLastName";
            this.textBoxCustomerLastName.Size = new System.Drawing.Size(120, 22);
            this.textBoxCustomerLastName.TabIndex = 6;
            // 
            // textBoxCustomerFirstName
            // 
            this.textBoxCustomerFirstName.Location = new System.Drawing.Point(134, 22);
            this.textBoxCustomerFirstName.Name = "textBoxCustomerFirstName";
            this.textBoxCustomerFirstName.Size = new System.Drawing.Size(120, 22);
            this.textBoxCustomerFirstName.TabIndex = 5;
            // 
            // labelCustomerAdress
            // 
            this.labelCustomerAdress.AutoSize = true;
            this.labelCustomerAdress.Location = new System.Drawing.Point(18, 140);
            this.labelCustomerAdress.Name = "labelCustomerAdress";
            this.labelCustomerAdress.Size = new System.Drawing.Size(54, 16);
            this.labelCustomerAdress.TabIndex = 4;
            this.labelCustomerAdress.Text = "Adress:";
            // 
            // labelCustomerPhoneNumber
            // 
            this.labelCustomerPhoneNumber.AutoSize = true;
            this.labelCustomerPhoneNumber.Location = new System.Drawing.Point(18, 112);
            this.labelCustomerPhoneNumber.Name = "labelCustomerPhoneNumber";
            this.labelCustomerPhoneNumber.Size = new System.Drawing.Size(98, 16);
            this.labelCustomerPhoneNumber.TabIndex = 3;
            this.labelCustomerPhoneNumber.Text = "Phone number:";
            // 
            // labelCustomerEmail
            // 
            this.labelCustomerEmail.AutoSize = true;
            this.labelCustomerEmail.Location = new System.Drawing.Point(18, 84);
            this.labelCustomerEmail.Name = "labelCustomerEmail";
            this.labelCustomerEmail.Size = new System.Drawing.Size(49, 16);
            this.labelCustomerEmail.TabIndex = 2;
            this.labelCustomerEmail.Text = "E-mail:";
            // 
            // labelCustomerLastName
            // 
            this.labelCustomerLastName.AutoSize = true;
            this.labelCustomerLastName.Location = new System.Drawing.Point(18, 56);
            this.labelCustomerLastName.Name = "labelCustomerLastName";
            this.labelCustomerLastName.Size = new System.Drawing.Size(73, 16);
            this.labelCustomerLastName.TabIndex = 1;
            this.labelCustomerLastName.Text = "Last name:";
            // 
            // labelCustomerFirstName
            // 
            this.labelCustomerFirstName.AutoSize = true;
            this.labelCustomerFirstName.Location = new System.Drawing.Point(18, 28);
            this.labelCustomerFirstName.Name = "labelCustomerFirstName";
            this.labelCustomerFirstName.Size = new System.Drawing.Size(73, 16);
            this.labelCustomerFirstName.TabIndex = 0;
            this.labelCustomerFirstName.Text = "First name:";
            // 
            // buttonCustomerSave
            // 
            this.buttonCustomerSave.Location = new System.Drawing.Point(105, 198);
            this.buttonCustomerSave.Name = "buttonCustomerSave";
            this.buttonCustomerSave.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerSave.TabIndex = 1;
            this.buttonCustomerSave.Text = "Save";
            this.buttonCustomerSave.UseVisualStyleBackColor = true;
            this.buttonCustomerSave.Click += new System.EventHandler(this.buttonCustomerSave_Click);
            // 
            // CustomersAddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 230);
            this.Controls.Add(this.buttonCustomerSave);
            this.Controls.Add(this.groupBoxCustomer);
            this.Name = "CustomersAddOrEditForm";
            this.Text = "CustomersAddOrEditForm";
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomerPhoneNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Label labelCustomerFirstName;
        private System.Windows.Forms.TextBox textBoxCustomerAdress;
        private System.Windows.Forms.TextBox textBoxCustomerEmail;
        private System.Windows.Forms.TextBox textBoxCustomerLastName;
        private System.Windows.Forms.TextBox textBoxCustomerFirstName;
        private System.Windows.Forms.Label labelCustomerAdress;
        private System.Windows.Forms.Label labelCustomerPhoneNumber;
        private System.Windows.Forms.Label labelCustomerEmail;
        private System.Windows.Forms.Label labelCustomerLastName;
        private System.Windows.Forms.Button buttonCustomerSave;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomerPhoneNumber;
    }
}