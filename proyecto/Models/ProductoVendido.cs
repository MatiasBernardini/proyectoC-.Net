using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Models
{
    public class ProductoVendido
    {
        private int _id;
        private int _stock;
        private int _idProduct;
        private int _idSale;


        public ProductoVendido() { }
        public ProductoVendido(int stock, int idProduct, int idSale)
        {
            this._stock = stock;
            this._idProduct = idProduct;
            this._idSale = idSale;
        }
        public ProductoVendido(int id, int stock, int idProduct, int idSale) : this( stock, idProduct, idSale)
        {
            this._id = id;

        }


        public int Id { get => _id; set => _id = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public int IdProduct { get => _idProduct; set => _idProduct = value; }
        public int IdSale { get => _idSale; set => _idSale = value; }

    }

}
