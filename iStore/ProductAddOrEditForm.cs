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
    public partial class ProductAddOrEditForm : Form
    {
        private Product _product;
        public List<Product> ListOfProduct;
        public ProductAddOrEditForm(Product product)
        {
            InitializeComponent();

            _product = product;

            textBoxProductProduct.Text = _product.name;
            textBoxProductDescription.Text = _product.Description;
            comboBoxCategory.SelectedItem = _product.Category;
            comboBoxSupplier.SelectedItem = _product.Supplier;
            numericUpDownProductPrice.Text = _product.Price.ToString();
            numericUpDownProductStock.Text = _product.StockQuantity.ToString();

            //Make a new list for Category objects and bind the data to the combobox Category.
            Dictionary<int, string> CategoryItems = new Dictionary<int, string>();
            foreach (Category Category in Program.db.Categories)
            {
                CategoryItems.Add(Category.id, Category.Catagory);

                comboBoxCategory.DataSource = new BindingSource(CategoryItems, null);
                comboBoxCategory.ValueMember = "Key";
                comboBoxCategory.DisplayMember = "Value";
            }

            //Make a new list for Supplier objects and bind the data to the combobox Supplier.
            Dictionary<int, string> SupplierItems = new Dictionary<int, string>();
            foreach (Supplier Supplier in Program.db.Suppliers)
            {
                SupplierItems.Add(Supplier.id, Supplier.name);

                comboBoxSupplier.DataSource = new BindingSource(SupplierItems, null);
                comboBoxSupplier.ValueMember = "Key";
                comboBoxSupplier.DisplayMember = "Value";
            }
        }

        //Product save button
        private void buttonProductSave_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem != null)
            {
                if (comboBoxSupplier.SelectedItem != null)
                {


                    _product.CategoryID = (int)comboBoxCategory.SelectedValue;
                    _product.SupplierID = (int)comboBoxSupplier.SelectedValue;
                    _product.name = textBoxProductProduct.Text;
                    if (numericUpDownProductPrice.Text == "")
                    {
                        // If the value in the numeric updown is an empty string, replace with 0.
                        numericUpDownProductPrice.Text = "0";
                    }
                    _product.Price = Int32.Parse(numericUpDownProductPrice.Text);
                    if (numericUpDownProductStock.Text == "")
                    {
                        // If the value in the numeric updown is an empty string, replace with 0.
                        numericUpDownProductStock.Text = "0";
                    }
                    _product.StockQuantity = Int32.Parse(numericUpDownProductStock.Text);
                    _product.Description = textBoxProductDescription.Text;

                    // prepares a newly added row or an existing updated row.
                    Program.db.Products.AddOrUpdate(_product);

                    // Apply's the prepared changes to the database.
                    Program.db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("It appears that there is no supplier/category, Please ask an admin to add either of them before u proceed", "Category or supplier not found");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("It appears that there is no supplier/category, Please ask an admin to add either of them before u proceed", "Category or supplier not found");
                Close();
            }
        }
    }
}
