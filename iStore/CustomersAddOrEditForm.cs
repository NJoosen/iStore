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
    public partial class CustomersAddOrEditForm : Form
    {
        private Customer _customer;
        public CustomersAddOrEditForm(Customer customer)
        {
            InitializeComponent();

            _customer = customer;
            textBoxCustomerAdress.Text = _customer.adress;
            textBoxCustomerEmail.Text = _customer.adress;
            textBoxCustomerFirstName.Text = _customer.Firstname;
            textBoxCustomerLastName.Text = _customer.Lastname;
            numericUpDownCustomerPhoneNumber.Text = _customer.phonenumber.ToString();
        }

        //Customer save button
        private void buttonCustomerSave_Click(object sender, EventArgs e)
        {
            _customer.adress = textBoxCustomerAdress.Text;
            _customer.email = textBoxCustomerEmail.Text;
            _customer.Firstname = textBoxCustomerFirstName.Text;
            _customer.Lastname = textBoxCustomerLastName.Text;
            if (numericUpDownCustomerPhoneNumber.Text == "")
            {
                // If the value in the numeric updown is an empty string, replace with 0.
                numericUpDownCustomerPhoneNumber.Text = "0";
            }
            _customer.phonenumber = Int32.Parse(numericUpDownCustomerPhoneNumber.Text);

            // prepares a newly added row or an existing updated row.
            Program.db.Customers.AddOrUpdate(_customer);

            // Apply's the prepared changes to the database.
            Program.db.SaveChanges();
            Close();
        }
    }
}
