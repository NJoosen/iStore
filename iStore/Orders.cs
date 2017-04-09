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
    public partial class Orders : Form
    {
        //Shows a list of all orders.
        public Orders()
        {
            InitializeComponent();

            foreach (OrderDetail orderDetail in Program.db.OrderDetails)
            {
                ListViewItem OrderOverview = new ListViewItem();

                //Setup the data for a list.
                OrderOverview.Text = (orderDetail.OrderID.ToString());
                OrderOverview.SubItems.Add(orderDetail.Product.name);
                OrderOverview.SubItems.Add(orderDetail.Price.ToString());
                OrderOverview.SubItems.Add(orderDetail.Amount.ToString());
                OrderOverview.SubItems.Add(orderDetail.Order.Customer.Firstname);
                OrderOverview.SubItems.Add(orderDetail.Order.Customer.Lastname);
                OrderOverview.SubItems.Add(orderDetail.Order.OrderDate.ToString());
                //Add them to the list.
                listViewOrderOverview.Items.Add(OrderOverview);
            }
        }
    }
}
