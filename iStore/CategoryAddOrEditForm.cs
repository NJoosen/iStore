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
    public partial class CategoryAddOrEditForm : Form
    {
        private Category _category;

        public CategoryAddOrEditForm(Category category)
        {
            InitializeComponent();
            _category = category;
            textBoxCategory.Text = _category.Catagory;

        }

        //Category save button
        private void buttonCategorySave_Click(object sender, EventArgs e)
        {
            _category.Catagory = textBoxCategory.Text;


            // prepares a newly added row or an existing updated row.
            Program.db.Categories.AddOrUpdate(_category);

            // Apply's the prepared changes to the database.
            Program.db.SaveChanges();
            Close();
        }
    }
}
