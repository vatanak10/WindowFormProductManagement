using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            frmProduct frm = (frmProduct)Application.OpenForms["frmProduct"];

            LoadProducts(frm.Product.GetProducts);
            totalPrice.Text = frm.Product.getTotalProductPrice().ToString("C");

            productView.Columns[0].Width = productView.Width / 5;
            productView.Columns[1].Width = productView.Width / 5;
            productView.Columns[2].Width = productView.Width / 5;
            productView.Columns[3].Width = productView.Width / 5;
            productView.Columns[4].Width = productView.Width / 5;
        }

        public void LoadProducts(Product[] product_list)
        {
            ListViewItem itm = null;
            foreach (Product item in product_list)
            {
                itm = productView.Items.Add(item.ProductID);
                itm.SubItems.Add(item.ProductName);
                itm.SubItems.Add(item.ProductPrice.ToString());
                itm.SubItems.Add(item.ProductStockAmount.ToString());
                itm.SubItems.Add(item.ProductExpireDate.ToString());
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }        

        private void productView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            frmProduct frm = (frmProduct)Application.OpenForms["frmProduct"];

            if (e.Column == 0)
            {                
                frm.Product.Sort(SortOptions.SortByID);
            }
            if (e.Column == 1)
            {               
                frm.Product.Sort(SortOptions.SortByName);
            }

            if (e.Column == 2)
            {                
                frm.Product.Sort(SortOptions.SortByPrice);
            }
            if (e.Column == 3)
            {                
                frm.Product.Sort(SortOptions.SortByStock);
            }
            if (e.Column == 4)
            {                
                frm.Product.Sort(SortOptions.SortByDate);
            }

            productView.Items.Clear();

            LoadProducts(frm.Product.GetProducts);
            totalPrice.Text = frm.Product.getTotalProductPrice().ToString("C");

            productView.Columns[0].Width = productView.Width / 5;
            productView.Columns[1].Width = productView.Width / 5;
            productView.Columns[2].Width = productView.Width / 5;
            productView.Columns[3].Width = productView.Width / 5;
            productView.Columns[4].Width = productView.Width / 5;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
