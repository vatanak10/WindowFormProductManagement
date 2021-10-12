using System;
using System.Collections;
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
            Application.Run(new frmHome());
        }
    }

    public enum SortOptions
    {
        SortByID = 0,
        SortByName = 1,
        SortByPrice = 2,
        SortByStock = 3,
        SortByDate = 4
    }

    public class Product : IComparable
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

        public int CompareTo(object o)
        {
            Product temp = (Product)o;
            return string.Compare(this.ProductName, temp.ProductName, StringComparison.Ordinal);
        }
    }

    public class ProductComparator : IComparer
    {
        protected SortOptions _SortType = SortOptions.SortByPrice;

        public ProductComparator(SortOptions SortBy)
        {
            _SortType = SortBy;

        }

        public int Compare(object x, object y)
        {
            Product x1 = (Product)x;
            Product x2 = (Product)y;

            if (_SortType == SortOptions.SortByID)
            {
                return x1.ProductID.CompareTo(x2.ProductID);
            }

            if (_SortType == SortOptions.SortByName)
            {
                return string.Compare(x1.ProductName, x2.ProductName, StringComparison.Ordinal);
            }

            if (_SortType == SortOptions.SortByPrice)
            {
                return string.Compare(x1.ProductPrice.ToString(), x2.ProductPrice.ToString(), StringComparison.Ordinal);
            }

            if (_SortType == SortOptions.SortByStock)
            {
                return string.Compare(x1.ProductStockAmount.ToString(), x2.ProductStockAmount.ToString(), StringComparison.Ordinal);
            }

            if (_SortType == SortOptions.SortByDate)
            {
                return string.Compare(x1.ProductExpireDate.ToString(), x2.ProductExpireDate.ToString(), StringComparison.Ordinal);
            }

            return 0;
        }
    }
}
