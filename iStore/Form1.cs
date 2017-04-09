using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iStore
{
    public partial class Form1 : Form
    {
        public List<Product> FilteredProducts;
        public Form1()
        {
            InitializeComponent();
        }

        //Trigger once form gets loaded.
        private void Form1_Load(object sender, EventArgs e)
        {
            //run method Dictionairy
            Dictionary();

        }

        //Contains lists for all the comboboxes and listviews.
        public void Dictionary()
        {
            //Make a new list for Category objects and bind the data to the combobox MainCategory & MainEditCategory.
            Dictionary<int, string> CategoryItems = new Dictionary<int, string>();
            foreach (Category Category in Program.db.Categories)
            {
                CategoryItems.Add(Category.id, Category.Catagory);

                comboBoxMainCategory.DataSource = new BindingSource(CategoryItems, null);
                comboBoxMainEditCategory.DataSource = new BindingSource(CategoryItems, null);
                comboBoxMainCategory.ValueMember = "Key";
                comboBoxMainEditCategory.ValueMember = "Key";
                comboBoxMainCategory.DisplayMember = "Value";
                comboBoxMainEditCategory.DisplayMember = "Value";
            }

            //Make a new list for Supplier objects and bind the data to the combobox MainEditSupplier.
            Dictionary<int, string> SupplierItems = new Dictionary<int, string>();
            foreach (Supplier Supplier in Program.db.Suppliers)
            {
                SupplierItems.Add(Supplier.id, Supplier.name);
                comboBoxMainEditSupplier.DataSource = new BindingSource(SupplierItems, null);
                comboBoxMainEditSupplier.ValueMember = "Key";
                comboBoxMainEditSupplier.DisplayMember = "Value";
            }

            //Make a new list for Product objects and bind the data to the combobox MainEditProduct.
            Dictionary<int, string> ProductItems = new Dictionary<int, string>();
            foreach (Product Product in Program.db.Products)
            {
                ProductItems.Add(Product.id, Product.name);

                comboBoxMainEditProduct.DataSource = new BindingSource(ProductItems, null);
                comboBoxMainEditProduct.ValueMember = "Key";
                comboBoxMainEditProduct.DisplayMember = "Value";
            }

            //Make a new list for Customer objects and bind the data to the combobox MainEditCustomer.
            Dictionary<int, string> CustomerItems = new Dictionary<int, string>();
            foreach (Customer Customer in Program.db.Customers)
            {
                CustomerItems.Add(Customer.id, Customer.Firstname);

                comboBoxMainEditCustomer.DataSource = new BindingSource(CustomerItems, null);
                comboBoxMainEditCustomer.ValueMember = "Key";
                comboBoxMainEditCustomer.DisplayMember = "Value";
            }

            //Clears the listview of ProductOverview
            listViewProductOverview.Items.Clear();


            //Checks if the list of FilterdProducts got any filtered objects.
            if (FilteredProducts == null)
            {
                //Adds all the products from database to the listview.
                foreach (Product product in Program.db.Products)
                {
                    ListViewItem carlist = new ListViewItem();

                    //Setup the data for a list.
                    carlist.Text = (product.name);
                    carlist.SubItems.Add(product.Description);
                    carlist.SubItems.Add(product.StockQuantity.ToString());
                    carlist.SubItems.Add(product.Price.ToString());
                    carlist.Tag = product.id;

                    //Add them to the list.
                    listViewProductOverview.Items.Add(carlist);

                }
            }
            else
            {
                //Adds all the products from the list of FilteredProducts to the listview.
                foreach (Product product in FilteredProducts)
                {
                    ListViewItem carlist = new ListViewItem();

                    // Setup the data for a list.
                    carlist.Text = (product.name);
                    carlist.SubItems.Add(product.Description);
                    carlist.SubItems.Add(product.StockQuantity.ToString());
                    carlist.SubItems.Add(product.Price.ToString());
                    carlist.Tag = product.id;

                    //Add them to the list.
                    listViewProductOverview.Items.Add(carlist);

                }
            }

        }

        //Button add new supplier.
        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
                //Make new Supplier object.
                Supplier addSupplier = new Supplier();

                //Make new SupplierAddOrEditForm object and pass a new Supplier object to the form.
                SupplierAddOrEditForm SupplierAddOrEditForm = new SupplierAddOrEditForm(addSupplier);
                SupplierAddOrEditForm.FormClosed += Form1_Load;
                SupplierAddOrEditForm.Show();

        }

        //Button add new Category.
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
         
                //Make new Category object
                Category addCategory = new Category();

                //Make new CatecoryAddOrEditForm object and pass a new Category object to the form.
                CategoryAddOrEditForm CategoryAddOrEditForm = new CategoryAddOrEditForm(addCategory);
                CategoryAddOrEditForm.FormClosed += Form1_Load;
                CategoryAddOrEditForm.Show();

        }

        //Button add new Product.
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            //Make new Product Object.
            Product addProduct = new Product();

            //Make new ProductAddOrEditForm object and pass a new Product object to the form.
            ProductAddOrEditForm ProductAddOrEditForm = new ProductAddOrEditForm(addProduct);
            ProductAddOrEditForm.FormClosed += Form1_Load;
            ProductAddOrEditForm.Show();
        }

        //Button add new customer
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            //Make new Customer Object.
            Customer addCustomer = new Customer();

            //Make new CustomerAddOrEditForm object and pass a new Customer object to the form.
            CustomersAddOrEditForm CustomersAddOrEditForm = new CustomersAddOrEditForm(addCustomer);
            CustomersAddOrEditForm.FormClosed += Form1_Load;
            CustomersAddOrEditForm.Show();
        }

        

        //Button edit Category.
        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if (comboBoxMainEditCategory.SelectedItem != null)
            {
                //Find selected Category and add it to the Category Object.
                Category addCategory = Program.db.Categories.Find(comboBoxMainEditCategory.SelectedValue);

            //Make new CategoryAddOrEditForm object and pass the selected Category object to the form.
            CategoryAddOrEditForm CategoryAddOrEditForm = new CategoryAddOrEditForm(addCategory);
            CategoryAddOrEditForm.FormClosed += Form1_Load;
            CategoryAddOrEditForm.Show();
            }

            //Clears datasource.
            comboBoxMainEditCategory.DataSource = null;
            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
        }

        //Button edit Supplier.
        private void button3EditSupplier_Click(object sender, EventArgs e)
        {
            if (comboBoxMainEditSupplier.SelectedItem != null)
            {
                //Find selected Supplier and add it to the Supplier Object.
                Supplier addSupplier = Program.db.Suppliers.Find(comboBoxMainEditSupplier.SelectedValue);

            //Make new SupplierAddOrEditForm object and pass the selected Supplier object to the form.
            SupplierAddOrEditForm SupplierAddOrEditForm = new SupplierAddOrEditForm(addSupplier);
            SupplierAddOrEditForm.FormClosed += Form1_Load;
            SupplierAddOrEditForm.Show();
            }

            //Clears datasource.
            comboBoxMainEditSupplier.DataSource = null;
            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
        }

        //Button edit Product
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (comboBoxMainEditProduct.SelectedItem != null)
            {
                //Find selected Product and add it to the Product Object.
                Product addProduct = Program.db.Products.Find(comboBoxMainEditProduct.SelectedValue);

                //Make new ProductAddOrEditForm object and pass the selected Product object to the form.
                ProductAddOrEditForm ProductAddOrEditForm = new ProductAddOrEditForm(addProduct);
                ProductAddOrEditForm.FormClosed += Form1_Load;
                ProductAddOrEditForm.Show();
            }

            //Clears datasource.
            comboBoxMainEditProduct.DataSource = null;

            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
    }

        //Button edit Customer.
        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            if (comboBoxMainEditCustomer.SelectedItem != null)
            {
                //Find selected Customer and add it to the Customer Object.
                Customer addCustomer = Program.db.Customers.Find(comboBoxMainEditCustomer.SelectedValue);

                //Make new CustomerAddOrEditForm object and pass the selected Customer object to the form.
                CustomersAddOrEditForm CustomersAddOrEditForm = new CustomersAddOrEditForm(addCustomer);
                CustomersAddOrEditForm.FormClosed += Form1_Load;
                CustomersAddOrEditForm.Show();
            }

            //Clears datasource.
            comboBoxMainEditCustomer.DataSource = null;

            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
        }

        //Button delete Category.
        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (comboBoxMainEditCategory.SelectedItem != null)
            {
                //Find selected Category and add it to the Category Object.
                Category RemoveCategory = Program.db.Categories.Find(comboBoxMainEditCategory.SelectedValue);

                //Prepare to delete the selected Category object and save it to the database.
                Program.db.Categories.Remove(RemoveCategory);
                Program.db.SaveChanges();

                //Rerun method Dictionary to refresh comboboxes and listview.
                Dictionary();
            }

            //Clears datasource.
            comboBoxMainEditCategory.DataSource = null;
            comboBoxMainCategory.DataSource = null;
            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
    }

        //Button delete Supplier.
        private void buttonDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (comboBoxMainEditSupplier.SelectedItem != null)
            {
                //Find selected Supplier and add it to the Supplier Object.
                Supplier RemoveSupplier = Program.db.Suppliers.Find(comboBoxMainEditSupplier.SelectedValue);

                //Prepare to delete the selected Supplier object and save it to the database.
                Program.db.Suppliers.Remove(RemoveSupplier);
                Program.db.SaveChanges();

                //Rerun method Dictionary to refresh comboboxes and listview.
                Dictionary();
            }

            //Clears datasource.
            comboBoxMainEditSupplier.DataSource = null;
            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
        }

        //Button delete Product.
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            
            if (comboBoxMainEditProduct.SelectedItem != null) { 
                //Find selected Product and add it to the Product Object.
                Product RemoveProduct = Program.db.Products.Find(comboBoxMainEditProduct.SelectedValue);

                //Prepare to delete the selected Product object and save it to the database.
                Program.db.Products.Remove(RemoveProduct);
                Program.db.SaveChanges();

                //Rerun method Dictionary to refresh comboboxes and listview.
                Dictionary();
            }

            //Clears datasource.
            comboBoxMainEditProduct.DataSource = null;
            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
        }

        //Button delete Customer.
        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (comboBoxMainEditCustomer.SelectedItem != null)
            {
                //Find selected Customer and add it to the Customer Object.
                Customer RemoveCustomer = Program.db.Customers.Find(comboBoxMainEditCustomer.SelectedValue);

                //Prepare to delete the selected Customer object and save it to the database.
                Program.db.Customers.Remove(RemoveCustomer);
                Program.db.SaveChanges();

                //Rerun method Dictionary to refresh comboboxes and listview.
                Dictionary();
            }

            //Clears datasource.
            comboBoxMainEditCustomer.DataSource = null;

            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
        }

        //Button filter listview with selected Category.
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (comboBoxMainCategory.SelectedItem != null)
            {
                //Receives the id from the selected Category.
                int CategoryId = (int)comboBoxMainCategory.SelectedValue;

                //Search the Product table for matching categorys and retrieves a list of products under that Category.
                var products = from listOfProduct in Program.db.Products
                               where listOfProduct.CategoryID == CategoryId
                               select listOfProduct;

                //Puts the retrieved list into the list of FilteredProducts
                FilteredProducts = products.ToList();

                //Rerun method Dictionary to refresh comboboxes and listview.
                Dictionary();
            }
            //Clears datasource.
            comboBoxMainCategory.DataSource = null;
            comboBoxMainCategory.DataSource = null;
            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
        }

        //Resets the FilteredProducts
        private void button2_Click(object sender, EventArgs e)
        {
            FilteredProducts = null;

            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
        }

        //Search Button
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Search database for product which containts the user character input nd retrieves a list of products under that searchterm.
            var products = from listOfProduct in Program.db.Products
                           where listOfProduct.name.Contains(textBoxSearch.Text)
                           select listOfProduct;

            //Puts the retrieved list into the list of FilteredProducts
            FilteredProducts = products.ToList();

            //Rerun method Dictionary to refresh comboboxes and listview.
            Dictionary();
        }

        //Button add Order.
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            //Make new Order object.
            Order addOrder = new Order();

            //Make new OrderAddForm object and pass a new Order object to the form.
            OrderAddForm OrderAddForm = new OrderAddForm(addOrder);
            OrderAddForm.FormClosed += Form1_Load;
            OrderAddForm.Show();
        }

        //Button show overview
        private void buttonShowOrderOverview_Click(object sender, EventArgs e)
        {
            //Make new Order overview object and shows it.
            Orders Order = new Orders();
            Order.FormClosed += Form1_Load;
            Order.Show();
        }
    }
}
