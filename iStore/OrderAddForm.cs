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
    public partial class OrderAddForm : Form
    {
        private Order _order;
        public List<Product> Product;
        public OrderAddForm(Order order)
        {
            InitializeComponent();
            _order = order;

            //Make a new list for Customer objects and bind the data to the combobox OrderCustomer.
            Dictionary<int, string> CustomerItems = new Dictionary<int, string>();
            foreach (Customer Customer in Program.db.Customers)
            {
                CustomerItems.Add(Customer.id, Customer.Firstname);

                comboBoxOrderCustomer.DataSource = new BindingSource(CustomerItems, null);
                comboBoxOrderCustomer.ValueMember = "Key";
                comboBoxOrderCustomer.DisplayMember = "Value";
            }

            //Make a new list for Product objects and bind the data to the combobox OrderProduct.
            Dictionary<int, string> ProductItems = new Dictionary<int, string>();
            foreach (Product Product in Program.db.Products)
            {
                ProductItems.Add(Product.id, Product.name);

                comboBoxOrderProduct.DataSource = new BindingSource(ProductItems, null);
                comboBoxOrderProduct.ValueMember = "Key";
                comboBoxOrderProduct.DisplayMember = "Value";
            }
        }

        //Method add items to listview ShoppingCart
        public void shoppingcart() {

            foreach (Product Product in Product)
            {
                ListViewItem Shoppingcart = new ListViewItem();

                //Setup the data for a list.
                Shoppingcart.Text = (Product.id.ToString());
                Shoppingcart.SubItems.Add(Product.name);
                Shoppingcart.SubItems.Add(Product.Price.ToString());

                Shoppingcart.SubItems.Add(numericUpDownOrderAmount.Value.ToString());
                Shoppingcart.Tag = comboBoxOrderCustomer.SelectedValue;

                //Add them to the list.
                listViewShoppingCart.Items.Add(Shoppingcart);
            }
        }

        //Button Add to cart.
        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderProduct.SelectedItem != null)
            {
                //Receives the id from the selected Product.
                int ProductId = (int)comboBoxOrderProduct.SelectedValue;

                //Search the Product table for matching id and retrieves the product.
                var product = from Product in Program.db.Products
                              where Product.id == ProductId
                              select Product;

                //Puts the retrieved product to a list and sends it to the shoppingcart method to put in shoppingcart.
                Product = product.ToList();
                shoppingcart();
            }
            if (comboBoxOrderProduct.SelectedItem == null)
            {
                MessageBox.Show("An error has occured. There are no products in store.", "Error: No products available");
                Close();
            }
        }

        //Button deleted selected item from ShoppingCart listview.
        private void buttonOrderDelete_Click(object sender, EventArgs e)
        {
            if(listViewShoppingCart.SelectedItems.Count > 0)
            {
                listViewShoppingCart.SelectedItems[0].Remove();
            }
        }

        //Button place the order.
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderCustomer.SelectedItem != null)
            {
                //Receives the id from the selected Customer.
                int CustomerID = (int)comboBoxOrderCustomer.SelectedValue;

                //Finds the selected customer and place it in the customer object.
                Customer SelectedCustomer = Program.db.Customers.Find(CustomerID);
                SelectedCustomer.Orders.Add(_order);
                _order.OrderDate = DateTime.Now;

                //Prepare to add new order
                Program.db.Orders.Add(_order);

                foreach (ListViewItem Product in listViewShoppingCart.Items)
                {
                    OrderDetail _orderDetail = new OrderDetail();
                    _orderDetail.OrderID = _order.id;
                    _orderDetail.ProductID = Int32.Parse(Product.Text);
                    _orderDetail.Price = Int32.Parse(Product.SubItems[2].Text.ToString());
                    _orderDetail.Amount = Int32.Parse(Product.SubItems[3].Text.ToString());

                    //Prepare to add new order details
                    Program.db.OrderDetails.Add(_orderDetail);
                }
                //Save the prepared order and orderdetails to database.
                Program.db.SaveChanges();
                Close();
            }
            if(comboBoxOrderCustomer.SelectedItem == null) { 
            MessageBox.Show("No Customer selected, unavailable to place order.", "Error: Customer not found");
            Close();
            }
        }
        
    }
}
