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
    public partial class frmProduct : Form
    {
        private static readonly ProductManager productManager = new ProductManager();
        public ProductManager Product = productManager;
        public Product CurExp = null;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            inputName.Focus();
            inputCode.Text = Product.GenerateNewProductID();
            inputName.Clear();
            inputPrice.Clear();
            inputStock.Clear();
            inputTotal.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product prod = null;
            prod = new Product(inputCode.Text, inputName.Text, Convert.ToSingle(inputPrice.Text), Convert.ToDateTime(inputDate.Text), Convert.ToSingle(inputStock.Text));
            Product.AddProduct(prod);

            inputCode.Clear();
            inputName.Clear();
            inputPrice.Clear();
            inputStock.Clear();
            inputTotal.Clear();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Product prod = Product.MoveFirst();

            if (prod == null) { return; }
            CurExp = prod;

            if (prod != null)
            {
                inputCode.Text = prod.ProductID;
                inputName.Text = prod.ProductName;
                inputPrice.Text = prod.ProductPrice.ToString();
                inputDate.Text = prod.ProductExpireDate.ToString();
                inputStock.Text = prod.ProductStockAmount.ToString();
                inputTotal.Text = (prod.ProductPrice * prod.ProductStockAmount).ToString();
                txtOrder.Text = Product.getCurrentPost.ToString() + "/" + Product.GetProducts.Length.ToString();
            }            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Product prod = Product.MovePrevious();

            if (prod == null) { return; }
            CurExp = prod;

            if (prod != null)
            {
                inputCode.Text = prod.ProductID;
                inputName.Text = prod.ProductName;
                inputPrice.Text = prod.ProductPrice.ToString();
                inputDate.Text = prod.ProductExpireDate.ToString();
                inputStock.Text = prod.ProductStockAmount.ToString();
                inputTotal.Text = (prod.ProductPrice * prod.ProductStockAmount).ToString();
                txtOrder.Text = Product.getCurrentPost.ToString() + "/" + Product.GetProducts.Length.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Product prod = Product.MoveNext();

            if (prod == null) { return; }
            CurExp = prod;

            if (prod != null)
            {
                inputCode.Text = prod.ProductID;
                inputName.Text = prod.ProductName;
                inputPrice.Text = prod.ProductPrice.ToString();
                inputDate.Text = prod.ProductExpireDate.ToString();
                inputStock.Text = prod.ProductStockAmount.ToString();
                inputTotal.Text = (prod.ProductPrice * prod.ProductStockAmount).ToString();
                txtOrder.Text = Product.getCurrentPost.ToString() + "/" + Product.GetProducts.Length.ToString();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Product prod = Product.MoveLast();

            if (prod == null) { return; }
            CurExp = prod;

            if (prod != null)
            {
                inputCode.Text = prod.ProductID;
                inputName.Text = prod.ProductName;
                inputPrice.Text = prod.ProductPrice.ToString();
                inputDate.Text = prod.ProductExpireDate.ToString();
                inputStock.Text = prod.ProductStockAmount.ToString();
                inputTotal.Text = (prod.ProductPrice * prod.ProductStockAmount).ToString();
                txtOrder.Text = Product.getCurrentPost.ToString() + "/" + Product.GetProducts.Length.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product prod = null;

            if (MessageBox.Show("Are you sure to delete the expense?", "Delete Confirm?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Product.Delete(CurExp);

                if (Product.getCurrentPost == 0)
                {
                    return;
                }

                prod = Product.GetProducts[Product.getCurrentPost - 1];


                if (prod == null) { return; }
                CurExp = prod;

                if (prod != null)
                {
                    inputCode.Text = prod.ProductID;
                    inputName.Text = prod.ProductName;
                    inputPrice.Text = prod.ProductPrice.ToString();
                    inputDate.Text = prod.ProductExpireDate.ToString();
                    inputStock.Text = prod.ProductStockAmount.ToString();
                    inputTotal.Text = (prod.ProductPrice * prod.ProductStockAmount).ToString();
                    txtOrder.Text = Product.getCurrentPost.ToString() + "/" + Product.GetProducts.Length.ToString();
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product prod = null;

            prod = new Product(inputCode.Text, inputName.Text, Convert.ToSingle(inputPrice.Text), Convert.ToDateTime(inputDate.Text), Convert.ToSingle(inputStock.Text));

            Product.Update(CurExp, prod);

            if (prod != null)
            {
                inputCode.Text = prod.ProductID;
                inputName.Text = prod.ProductName;
                inputPrice.Text = prod.ProductPrice.ToString();
                inputDate.Text = prod.ProductExpireDate.ToString();
                inputStock.Text = prod.ProductStockAmount.ToString();
                inputTotal.Text = (prod.ProductPrice * prod.ProductStockAmount).ToString();
                txtOrder.Text = Product.getCurrentPost.ToString() + "/" + Product.GetProducts.Length.ToString();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form frm = new frmProductList();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
