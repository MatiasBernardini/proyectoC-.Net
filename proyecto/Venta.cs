using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Venta
    {
        private int _id;
        private string _comments;
        private int _idUser;

        public Venta (int id, string comments, int idUser)
        {
            this._id = id;
            this._comments = comments;
            this._idUser = idUser;
        }

        public string showComments
        {
            get
            {
                return this._comments;
            }
            set
            {
                this._comments = value;
            }
        }
    }
}
