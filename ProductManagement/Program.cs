using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmProduct());
        }
    }
    public class Product
    {
        private string _id;
        private string _product_name;
        private Single _product_price;
        private DateTime _expire_date;
        private Single _amount_in_stock;

        public Product(string ID, string name, Single price, DateTime expire, Single amount)
        {
            _id = ID;
            _product_name = name;
            _product_price = price;
            _expire_date = expire;
            _amount_in_stock = amount;
        }

        public string ProductID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ProductName
        {
            get { return _product_name; }
            set { _product_name = value; }
        }

        public Single ProductPrice
        {
            get { return _product_price; }
            set { _product_price = value; }
        }

        public DateTime ProductExpireDate
        {
            get { return _expire_date; }
            set { _expire_date = value; }
        }

        public Single ProductStockAmount
        {
            get { return _amount_in_stock; }
            set { _amount_in_stock = value; }
        }
    }

    public class ProductManager
    {

        private Product[] _product_list;
        private int _current_index = -1;


        public void AddProduct(Product prod)
        {
            if (prod != null)
            {
                if (_product_list == null)
                {
                    _product_list = new Product[1];
                    _product_list[0] = prod;
                }
                else
                {

                    Product[] temp = new Product[_product_list.Length];

                    temp = _product_list;

                    _product_list = new Product[temp.Length + 1];

                    for (int i = 0; i <= temp.Length - 1; i++)
                    {
                        _product_list[i] = temp[i];
                    }
                    _product_list[_product_list.Length - 1] = prod;
                }
                _current_index = _product_list.Length - 1;
            }

        }

        public void Delete(Product Obj)
        {
            Product[] temp = null;

            if (Obj == null || _product_list == null) { return; }

            //get all undeleted items
            temp = _product_list.AsEnumerable().Where(exp => exp.ProductID != Obj.ProductID).ToArray();


            if (temp.Length == 0)
            {
                _product_list = null;
                _current_index = -1;
                return;
            }

            _product_list = temp;

            if (_current_index > _product_list.Length - 1)
            {
                _current_index = _product_list.Length - 1;
            }
        }

        public void Update(Product oldobj, Product newObj)
        {
            if (oldobj == null || _product_list == null) { return; }

            for (int i = 0; i <= _product_list.Length - 1; i++)
            {
                if (_product_list[i].ProductID == oldobj.ProductID)
                {
                    _product_list[i] = newObj;
                    break;
                }
            }
        }

        public Single getTotalProductPrice()
        {
            Single Sumexp = 0.0f;
            if (_product_list == null) { return 0.0f; }

            foreach (Product exp in _product_list)
            {
                Sumexp = Sumexp + exp.ProductPrice*exp.ProductStockAmount;

            }

            return Sumexp;
        }

        public string GenerateNewProductID()
        {
            if (_product_list == null)
            {
                return "0001";
            }
            else
            {
                return (Convert.ToInt32(_product_list[_product_list.Length - 1].ProductID) + 1).ToString("D4");
            }

        }

        public int getCurrentPost
        {
            get { return _current_index + 1; }
        }

        public Product MoveNext()
        {
            if (_product_list != null && _current_index < _product_list.Length - 1)
            {
                _current_index = _current_index + 1;
                return _product_list[_current_index];
            } else if (_product_list != null && _current_index == _product_list.Length - 1)
            {
                return _product_list[_current_index];
            }
                return null;
        }

        public Product MovePrevious()
        {
            if (_product_list != null && _current_index > 0)
            {
                _current_index = _current_index - 1;
                return _product_list[_current_index];
            } else if (_product_list != null && _current_index == 0)
            {
                return _product_list[_current_index];
            }
                return null;
        }

        public Product MoveFirst()
        {
            if (_product_list != null && _current_index >= 0)
            {
                _current_index = 0;
                return _product_list[_current_index];
            }
            return null;
        }

        public Product MoveLast()
        {
            if (_product_list != null && _current_index < _product_list.Length)
            {
                _current_index = _product_list.Length - 1;
                return _product_list[_current_index];
            }
            return null;
        }

        public Product[] GetProducts
        {
            get { return _product_list; }
        }

      
    }    
}
