using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Producto
    {
        private int _id;
        private string _description;
        private double _cost;
        private double _salePrice;
        private int _stock;
        private int _idUser;

        public Producto(int id, string description, double cost, double salePrice, int stock, int idUser )
        {
            this._id = id;
            this._description = description;
            this._cost = cost;
            this._salePrice = salePrice;
            this._stock = stock;
            this._idUser = idUser;
        }


        public string showDescription
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
    }
}
