namespace iStore
{
    partial class SupplierAddOrEditForm
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
            this.groupBoxSupplier = new System.Windows.Forms.GroupBox();
            this.numericUpDownSupplierPhoneNumber = new System.Windows.Forms.NumericUpDown();
            this.textBoxSupplierEmail = new System.Windows.Forms.TextBox();
            this.textBoxSupplierAdress = new System.Windows.Forms.TextBox();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelSupplierEmail = new System.Windows.Forms.Label();
            this.labelSupplierPhoneNumber = new System.Windows.Forms.Label();
            this.labelSupplierAdress = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.buttonSupplierSave = new System.Windows.Forms.Button();
            this.groupBoxSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupplierPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSupplier
            // 
            this.groupBoxSupplier.Controls.Add(this.numericUpDownSupplierPhoneNumber);
            this.groupBoxSupplier.Controls.Add(this.textBoxSupplierEmail);
            this.groupBoxSupplier.Controls.Add(this.textBoxSupplierAdress);
            this.groupBoxSupplier.Controls.Add(this.textBoxSupplierName);
            this.groupBoxSupplier.Controls.Add(this.labelSupplierEmail);
            this.groupBoxSupplier.Controls.Add(this.labelSupplierPhoneNumber);
            this.groupBoxSupplier.Controls.Add(this.labelSupplierAdress);
            this.groupBoxSupplier.Controls.Add(this.labelSupplierName);
            this.groupBoxSupplier.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSupplier.Name = "groupBoxSupplier";
            this.groupBoxSupplier.Size = new System.Drawing.Size(266, 167);
            this.groupBoxSupplier.TabIndex = 0;
            this.groupBoxSupplier.TabStop = false;
            this.groupBoxSupplier.Text = "Supplier";
            // 
            // numericUpDownSupplierPhoneNumber
            // 
            this.numericUpDownSupplierPhoneNumber.Location = new System.Drawing.Point(115, 91);
            this.numericUpDownSupplierPhoneNumber.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownSupplierPhoneNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSupplierPhoneNumber.Name = "numericUpDownSupplierPhoneNumber";
            this.numericUpDownSupplierPhoneNumber.Size = new System.Drawing.Size(130, 22);
            this.numericUpDownSupplierPhoneNumber.TabIndex = 8;
            this.numericUpDownSupplierPhoneNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxSupplierEmail
            // 
            this.textBoxSupplierEmail.Location = new System.Drawing.Point(116, 127);
            this.textBoxSupplierEmail.Name = "textBoxSupplierEmail";
            this.textBoxSupplierEmail.Size = new System.Drawing.Size(129, 22);
            this.textBoxSupplierEmail.TabIndex = 7;
            // 
            // textBoxSupplierAdress
            // 
            this.textBoxSupplierAdress.Location = new System.Drawing.Point(116, 58);
            this.textBoxSupplierAdress.Name = "textBoxSupplierAdress";
            this.textBoxSupplierAdress.Size = new System.Drawing.Size(129, 22);
            this.textBoxSupplierAdress.TabIndex = 5;
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(116, 27);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(129, 22);
            this.textBoxSupplierName.TabIndex = 4;
            // 
            // labelSupplierEmail
            // 
            this.labelSupplierEmail.AutoSize = true;
            this.labelSupplierEmail.Location = new System.Drawing.Point(15, 133);
            this.labelSupplierEmail.Name = "labelSupplierEmail";
            this.labelSupplierEmail.Size = new System.Drawing.Size(49, 16);
            this.labelSupplierEmail.TabIndex = 3;
            this.labelSupplierEmail.Text = "E-Mail:";
            // 
            // labelSupplierPhoneNumber
            // 
            this.labelSupplierPhoneNumber.AutoSize = true;
            this.labelSupplierPhoneNumber.Location = new System.Drawing.Point(15, 97);
            this.labelSupplierPhoneNumber.Name = "labelSupplierPhoneNumber";
            this.labelSupplierPhoneNumber.Size = new System.Drawing.Size(98, 16);
            this.labelSupplierPhoneNumber.TabIndex = 2;
            this.labelSupplierPhoneNumber.Text = "Phone number:";
            // 
            // labelSupplierAdress
            // 
            this.labelSupplierAdress.AutoSize = true;
            this.labelSupplierAdress.Location = new System.Drawing.Point(15, 64);
            this.labelSupplierAdress.Name = "labelSupplierAdress";
            this.labelSupplierAdress.Size = new System.Drawing.Size(54, 16);
            this.labelSupplierAdress.TabIndex = 1;
            this.labelSupplierAdress.Text = "Adress:";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(15, 33);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(48, 16);
            this.labelSupplierName.TabIndex = 0;
            this.labelSupplierName.Text = "Name:";
            // 
            // buttonSupplierSave
            // 
            this.buttonSupplierSave.Location = new System.Drawing.Point(95, 185);
            this.buttonSupplierSave.Name = "buttonSupplierSave";
            this.buttonSupplierSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSupplierSave.TabIndex = 1;
            this.buttonSupplierSave.Text = "Save";
            this.buttonSupplierSave.UseVisualStyleBackColor = true;
            this.buttonSupplierSave.Click += new System.EventHandler(this.buttonSupplierSave_Click);
            // 
            // SupplierAddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 218);
            this.Controls.Add(this.buttonSupplierSave);
            this.Controls.Add(this.groupBoxSupplier);
            this.Name = "SupplierAddOrEditForm";
            this.Text = "SupplierAddOrEditForm";
            this.groupBoxSupplier.ResumeLayout(false);
            this.groupBoxSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSupplierPhoneNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSupplier;
        private System.Windows.Forms.TextBox textBoxSupplierEmail;
        private System.Windows.Forms.TextBox textBoxSupplierAdress;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label labelSupplierEmail;
        private System.Windows.Forms.Label labelSupplierPhoneNumber;
        private System.Windows.Forms.Label labelSupplierAdress;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.Button buttonSupplierSave;
        private System.Windows.Forms.NumericUpDown numericUpDownSupplierPhoneNumber;
    }
}