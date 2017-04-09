using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace iStore
{
    public partial class SupplierAddOrEditForm : Form
    {
        private Supplier _supplier;
        public SupplierAddOrEditForm(Supplier supplier)
        {
            InitializeComponent();
            _supplier = supplier;
            textBoxSupplierAdress.Text = _supplier.adress;
            textBoxSupplierEmail.Text = _supplier.email;
            textBoxSupplierName.Text = _supplier.name;
            numericUpDownSupplierPhoneNumber.Text = _supplier.phonenumber.ToString();
        }

        //Supplier save button
        private void buttonSupplierSave_Click(object sender, EventArgs e)
        {
            _supplier.adress = textBoxSupplierAdress.Text;
            _supplier.email = textBoxSupplierEmail.Text;
            _supplier.name = textBoxSupplierName.Text;
            if (numericUpDownSupplierPhoneNumber.Text == "")
            {
                // If the value in the numeric updown is an empty string, replace with 0.
                numericUpDownSupplierPhoneNumber.Text = "0";
            }
            _supplier.phonenumber = Int32.Parse(numericUpDownSupplierPhoneNumber.Text);

            // prepares a newly added row or an existing updated row.
            Program.db.Suppliers.AddOrUpdate(_supplier);

            // Apply's the prepared changes to the database.
            Program.db.SaveChanges();
            Close();
        }
    }
}
