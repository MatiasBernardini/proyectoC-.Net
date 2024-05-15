using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class ProductoVendido
    {
        private int _id;
        private int _idProduct;
        private int _stock;
        private int _idSale;


        public ProductoVendido(int id, int idProduct, int stock, int idSale)
        {
            this._id = id;
            this._idProduct = idProduct;
            this._stock = stock;
            this._idSale = idSale;
        }

        public int showIdProduct
        {
            get
            {
                return this._idProduct;
            }
            set
            {
                this._idProduct = value;
            }
        }
    }

}
