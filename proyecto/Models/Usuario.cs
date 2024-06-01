using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Models
{
    public class Usuario
    {
        private int _id;
        private string _name;
        private string _lastName;
        private string _userName;
        private string _password;
        private string _email;


        public Usuario() { }
        public Usuario(string name, string lastName, string userName, string password ,string email)
        {

            this._name = name;
            this._lastName = lastName;
            this._userName = userName;
            this._password = password;
            this._email = email;
        }
        public Usuario(int id, string name, string lastName, string userName, string password ,string email) : this(name, lastName, userName, password ,email)
        {
            this._id = id;

        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }

        public override string ToString()
        {
            return $"Id = {this._id} - Nombre = {this._name} - Apellido = {this._lastName} - Nombre de Usuario = {this._userName} - Password = {this._password} - Email = {this._email}";
        }
    }

}
