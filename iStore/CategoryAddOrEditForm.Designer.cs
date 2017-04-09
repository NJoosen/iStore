namespace iStore
{
    partial class CategoryAddOrEditForm
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
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.buttonCategorySave = new System.Windows.Forms.Button();
            this.groupBoxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.textBoxCategory);
            this.groupBoxCategory.Controls.Add(this.labelCategory);
            this.groupBoxCategory.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(202, 57);
            this.groupBoxCategory.TabIndex = 0;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(89, 22);
            this.textBoxCategory.MaxLength = 45;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 22);
            this.textBoxCategory.TabIndex = 1;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(17, 28);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(66, 16);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Category:";
            // 
            // buttonCategorySave
            // 
            this.buttonCategorySave.Location = new System.Drawing.Point(76, 75);
            this.buttonCategorySave.Name = "buttonCategorySave";
            this.buttonCategorySave.Size = new System.Drawing.Size(75, 23);
            this.buttonCategorySave.TabIndex = 1;
            this.buttonCategorySave.Text = "Save";
            this.buttonCategorySave.UseVisualStyleBackColor = true;
            this.buttonCategorySave.Click += new System.EventHandler(this.buttonCategorySave_Click);
            // 
            // CategoryAddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 102);
            this.Controls.Add(this.buttonCategorySave);
            this.Controls.Add(this.groupBoxCategory);
            this.Name = "CategoryAddOrEditForm";
            this.Text = "CategoryAddOrEditForm";
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonCategorySave;
    }
}