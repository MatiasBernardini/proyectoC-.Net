using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Models
{
    public class Producto
    {
        private int _id;
        private string _description;
        private double _cost;
        private double _salePrice;
        private int _stock;
        private int _idUser;

        public Producto() { }
        public Producto(string description, double cost, double salePrice, int stock, int idUser)
        {
            this._description = description;
            this._cost = cost;
            this._salePrice = salePrice;
            this._stock = stock;
            this._idUser = idUser;
        }
        public Producto(int id, string description, double cost, double salePrice, int stock, int idUser) : this(description, cost, salePrice, stock, idUser)
        {
            this._id = id;

        }


        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public double Cost { get => _cost; set => _cost = value; }
        public double SalePrice { get => _salePrice; set => _salePrice = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int IdUser { get => _idUser; set => _idUser = value; }
    }
}
