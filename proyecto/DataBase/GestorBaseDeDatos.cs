using proyecto.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.DataBase
{
    internal class GestorBaseDeDatos
    {
        //Conexion a la base de datos
        private string connectionString;

        public GestorBaseDeDatos()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        }

        //Metodos de Usuario
        public Usuario GetUser(int userId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", userId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string name = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string userName = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    Usuario usuario = new Usuario(id, name, lastName, userName, password, email);

                    return usuario;
                }
                throw new Exception("Id no fue encontrado");
            }


        }

        public List<Usuario> ListUser()
        {
            List<Usuario> listUser = new List<Usuario>();
            string query = "SELECT * FROM Usuario";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.Id = Convert.ToInt32(dataReader["Id"]);
                            usuario.Name = dataReader["Nombre"].ToString();
                            usuario.LastName = dataReader["Apellido"].ToString();
                            usuario.UserName = dataReader["NombreUsuario"].ToString();
                            usuario.Password = dataReader["Contraseña"].ToString();
                            usuario.Email = dataReader["Mail"].ToString();

                            listUser.Add(usuario);

                        }
                    }
                }
            }
            return listUser;

        }

        public bool CreateUser(Usuario user)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO Usuario(nombre, apellido, nombreUsuario, contraseña,mail) values(@name, @lastName,@userName,@password,@email)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("name", user.Name);
                command.Parameters.AddWithValue("lastName", user.LastName);
                command.Parameters.AddWithValue("userName", user.UserName);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("email", user.Email);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public bool UpdateUser(int idUser, Usuario user)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Usuario SET nombre = @nombre, apellido = @apellido, nombreUsuario= @nombreUsuario, contraseña = @password, mail = @email WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("nombre", user.Name);
                command.Parameters.AddWithValue("apellido", user.LastName);
                command.Parameters.AddWithValue("nombreUsuario", user.UserName);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("email", user.Email);
                command.Parameters.AddWithValue("id", idUser);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", userId);

                return command.ExecuteNonQuery() > 0;
            }

        }


        //Metodos de Producto

        public Producto GetProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Producto WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", productId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string description = reader.GetString(1);
                    double cost = Convert.ToDouble(reader[2]);
                    double salePrice = Convert.ToDouble(reader[3]);
                    int stock = Convert.ToInt32(reader[4]);
                    int idUser = Convert.ToInt32(reader[5]);

                    Producto producto = new Producto(id, description, cost, salePrice, stock, idUser);

                    return producto;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public List<Producto> ListProduct()
        {
            List<Producto> listProduct = new List<Producto>();
            string query = "SELECT * FROM Producto";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Producto product = new Producto();
                            product.Id = Convert.ToInt32(dataReader["Id"]);
                            product.Description = dataReader["Descripciones"].ToString();
                            product.Cost = Convert.ToDouble(dataReader["Costo"]);
                            product.SalePrice = Convert.ToDouble(dataReader["PrecioVenta"]);
                            product.Stock = Convert.ToInt32(dataReader["Stock"]);
                            product.IdUser = Convert.ToInt32(dataReader["IdUsuario"]);

                            listProduct.Add(product);

                        }
                    }
                }
            }
            return listProduct;
        }

        public bool CreateProduct(Producto product)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO Producto(Descripciones, Costo, PrecioVenta, Stock, IdUsuario) values(@description, @cost,@salePrice,@stock,@idUser)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("description", product.Description);
                command.Parameters.AddWithValue("cost", product.Cost);
                command.Parameters.AddWithValue("salePrice", product.SalePrice);
                command.Parameters.AddWithValue("stock", product.Stock);
                command.Parameters.AddWithValue("idUser", product.IdUser);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public bool UpdateProduct(int idProduct, Producto product)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Producto SET Descripciones = @description, Costo = @cost, PrecioVenta= @salePrice, Stock = @stock, IdUsuario = @idUser WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("description", product.Description);
                command.Parameters.AddWithValue("cost", product.Cost);
                command.Parameters.AddWithValue("salePrice", product.SalePrice);
                command.Parameters.AddWithValue("stock", product.Stock);
                command.Parameters.AddWithValue("idUser", product.IdUser);
                command.Parameters.AddWithValue("id", idProduct);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteProduct(int productId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", productId);

                return command.ExecuteNonQuery() > 0;
            }

        }


        //Metodos de ProductoVendido
        public ProductoVendido GetSoldProduct(int soldProductId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM ProductoVendido WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", soldProductId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    int stock = Convert.ToInt32(reader[1]);
                    int idProduct = Convert.ToInt32(reader[2]);
                    int idSale = Convert.ToInt32(reader[3]);

                    ProductoVendido productoVendido = new ProductoVendido(id, stock, idProduct, idSale);

                    return productoVendido;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public List<ProductoVendido> ListSoldProduct()
        {
            List<ProductoVendido> listSoldProduct = new List<ProductoVendido>();
            string query = "SELECT * FROM ProductoVendido";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            ProductoVendido soldProduct = new ProductoVendido();
                            soldProduct.Id = Convert.ToInt32(dataReader["Id"]);
                            soldProduct.Stock = Convert.ToInt32(dataReader["Stock"]);
                            soldProduct.IdProduct = Convert.ToInt32(dataReader["IdProducto"]);
                            soldProduct.IdSale = Convert.ToInt32(dataReader["IdVenta"]);

                            listSoldProduct.Add(soldProduct);

                        }
                    }
                }
            }
            return listSoldProduct;
        }

        public bool CreateSoldProduct(ProductoVendido soldProduct)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO ProductoVendido(Stock, IdProducto, IdVenta) values(@stock, @idProduct, @idSale)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("stock", soldProduct.Stock);
                command.Parameters.AddWithValue("idProduct", soldProduct.IdProduct);
                command.Parameters.AddWithValue("idSale", soldProduct.IdSale);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public bool UpdateSoldProduct(int idSoldProduct, ProductoVendido soldProduct)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE ProductoVendido SET Stock = @stock, IdProducto = @idProduct, IdVenta = @IdSale WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("stock", soldProduct.Stock);
                command.Parameters.AddWithValue("idProduct", soldProduct.IdProduct);
                command.Parameters.AddWithValue("IdSale", soldProduct.IdSale);
                command.Parameters.AddWithValue("id", idSoldProduct);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteSoldProduct(int soldProductId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ProductoVendido WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", soldProductId);

                return command.ExecuteNonQuery() > 0;
            }

        }


        //Metodos de Venta

        public Venta GetSale(int saleId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Venta WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", saleId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string comments = reader.GetString(1);
                    int idUser = Convert.ToInt32(reader[2]);

                    Venta sale = new Venta(id, comments, idUser);

                    return sale;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public List<Venta> ListSale()
        {
            List<Venta> listSale = new List<Venta>();
            string query = "SELECT * FROM Venta";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Venta sale = new Venta();
                            sale.Id = Convert.ToInt32(dataReader["Id"]);
                            sale.Comments = dataReader["Comentarios"].ToString();
                            sale.IdUser = Convert.ToInt32(dataReader["IdUsuario"]);


                            listSale.Add(sale);

                        }
                    }
                }
            }
            return listSale;
        }

        public bool CreateSale(Venta sale)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO Venta(Comentarios, IdUsuario) values(@comments, @idUser)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("comments", sale.Comments);
                command.Parameters.AddWithValue("idUser", sale.IdUser);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public bool UpdateSale(int idSale, Venta sale)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Venta SET Comentarios = @comments, IdUsuario = @idUser WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("comments", sale.Comments);
                command.Parameters.AddWithValue("idUser", sale.IdUser);
                command.Parameters.AddWithValue("id", idSale);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteSale(int saleId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Venta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", saleId);

                return command.ExecuteNonQuery() > 0;
            }

        }
    }
}