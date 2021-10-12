using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
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

        public void Sort(SortOptions SortType)
        {
            if (_product_list == null) { return; }
            Array.Sort(_product_list, new ProductComparator(SortType));
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
                Sumexp = Sumexp + exp.ProductPrice * exp.ProductStockAmount;

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
            }
            else if (_product_list != null && _current_index == _product_list.Length - 1)
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
            }
            else if (_product_list != null && _current_index == 0)
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
