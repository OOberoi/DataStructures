using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    //Not implemented
    public interface IProduct
    {
        string ProductID { get; set; }

        void AddProduct();
        void DeleteProduct();
        void UpdateProduct();
    }

    public abstract class Product
    {
        public abstract void AddProduct();
        public abstract void DeleteProduct();
        public abstract void UpdateProduct();

    }
}
