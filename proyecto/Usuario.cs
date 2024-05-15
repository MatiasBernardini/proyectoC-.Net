using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Usuario
    {
        private int _id;
        private string _name;
        private string _lastName;
        private string _userName;
        private string _email;

        public Usuario (int id, string name, string lastName, string userName, string email)
        {
            this._id = id;
            this._name = name;
            this._lastName = lastName;
            this._userName = userName;
            this._email = email;
        }

        public string showName
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
    }

}
