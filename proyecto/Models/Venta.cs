using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace proyecto
{
    public class Venta
    {
        private int _id;
        private string _comments;
        private int _idUser;


        public Venta() { }
        public Venta(string comments, int idUser)
        {

            this._comments = comments;
            this._idUser = idUser;
        }
        public Venta(int id, string comments, int idUser) : this(comments, idUser)
        {
            this._id = id;

        }

        public int Id { get => _id; set => _id = value; }
        public string Comments { get => _comments; set => _comments = value; }
        public int IdUser { get => _idUser; set => _idUser = value; }
    }
}
