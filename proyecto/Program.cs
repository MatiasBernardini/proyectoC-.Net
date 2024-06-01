using proyecto.DataBase;
using proyecto.Models;
using System.Data.SqlClient;

namespace proyecto
{
    class Program
    {

        static void Main(string[] args)
        {
            GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();

            try
            {
                //Ejecución de Metodos de Usuario:


                //Console.WriteLine("Bienvenido, Por favor, ingrese el ID del usuario que desea obtener:");
                //string input = Console.ReadLine();
                //if (int.TryParse(input, out int userId))
                //{
                //    Usuario usuario = gestorBaseDeDatos.GetUser(userId);

                //    if (usuario != null)
                //    {
                //        Console.WriteLine($"Usuario: {usuario.Name} {usuario.LastName}, Nombre de usuario: {usuario.UserName}, Email: {usuario.Email}");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Usuario no encontrado.");
                //    }
                //}


                //List<Usuario> usuarios = gestorBaseDeDatos.ListUser();

                //foreach (var usuario in usuarios)
                //{
                //    Console.WriteLine($"ID: {usuario.Id}, Nombre: {usuario.Name}, Apellido: {usuario.LastName}, Usuario: {usuario.UserName}, Email: {usuario.Email}");
                //}


                //Usuario newUser = new Usuario("franco", "listeiner", "franlister", "324344323", "francolisteiner@gmail.com");
                //if (gestorBaseDeDatos.CreateUser(newUser))
                //{
                //    Console.WriteLine("usuario creado!");
                //}


                //Usuario editUser = new Usuario("nicolas", "barreiro", "nicobar", "2324211233", "nicobarreiro@gmail.com");

                //if (gestorBaseDeDatos.UpdateUser(7, editUser))
                //{
                //    Console.WriteLine("Usuario actualizado!");
                //}


                //Console.WriteLine("Bienvenido, Por favor, ingrese el ID del usuario que desea eliminar:");
                //string input = Console.ReadLine();
                //if (int.TryParse(input, out int userId))
                //{
                //    if (gestorBaseDeDatos.DeleteUser(userId))
                //    {
                //        Console.WriteLine("Usuario eliminado");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Usuario no encontrado.");
                //    }
                //}




                //Ejecución de Metodos de Producto:

                //Console.WriteLine("Bienvenido, Por favor, ingrese el ID del producto que desea obtener:");
                //string input = Console.ReadLine();
                //if (int.TryParse(input, out int productId))
                //{
                //    Producto product = gestorBaseDeDatos.GetProduct(productId);

                //    if (product != null)
                //    {
                //        Console.WriteLine($"Descripcion: {product.Description}, Costo: {product.Cost}, Precio Venta: {product.SalePrice}, IdUsuario: {product.IdUser}");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Producto no encontrado.");
                //    }
                //}


                //List<Producto> products = gestorBaseDeDatos.ListProduct();
                //foreach (var product in products)
                //{
                //    Console.WriteLine($"Descripcion: {product.Description}, Costo: {product.Cost}, Precio Venta: {product.SalePrice}, IdUsuario: {product.IdUser}");
                //}


                //Producto newProduct = new Producto("Camiseta Basquet", 1200.00, 2800.00, 26, 4);
                //if (gestorBaseDeDatos.CreateProduct(newProduct))
                //{
                //    Console.WriteLine("Producto creado!");
                //}


                //Producto editProduct = new Producto("Zapatilla", 900.00, 2000.00, 28, 2);
                //if (gestorBaseDeDatos.UpdateProduct(7, editProduct))
                //{
                //    Console.WriteLine("Producto actualizado!");
                //}


                //Console.WriteLine("Bienvenido, Por favor, ingrese el ID del producto que desea eliminar:");
                //string input = Console.ReadLine();
                //if (int.TryParse(input, out int productId))
                //{
                //    if (gestorBaseDeDatos.DeleteProduct(productId))
                //    {
                //        Console.WriteLine("Producto eliminado");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Producto no encontrado.");
                //    }
                //}




                //Ejecución de Metodos de ProductoVendido:

                //Console.WriteLine("Bienvenido, Por favor, ingrese el ID del producto vendido que desea obtener:");
                //string input = Console.ReadLine();
                //if (int.TryParse(input, out int soldProductId))
                //{
                //    ProductoVendido soldProduct = gestorBaseDeDatos.GetSoldProduct(soldProductId);

                //    if (soldProduct != null)
                //    {
                //        Console.WriteLine($"Stock: {soldProduct.Stock}, Id Producto: {soldProduct.IdProduct}, Id Venta: {soldProduct.IdSale}");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Producto vendido no encontrado.");
                //    }
                //}


                //List<ProductoVendido> soldproducts = gestorBaseDeDatos.ListSoldProduct();
                //foreach (var soldproduct in soldproducts)
                //{
                //    Console.WriteLine($"Stock: {soldproduct.Stock}, Id Producto: {soldproduct.IdProduct}, Id Venta: {soldproduct.IdSale}");
                //}


                //ProductoVendido newSoldProduct = new ProductoVendido(1, 2, 3);
                //if (gestorBaseDeDatos.CreateSoldProduct(newSoldProduct))
                //{
                //    Console.WriteLine("Producto Vendido creado!");
                //}


                //ProductoVendido editSoldProduct = new ProductoVendido(5, 2, 3);
                //if (gestorBaseDeDatos.UpdateSoldProduct(9, editSoldProduct))
                //{
                //    Console.WriteLine("Producto Vendido actualizado!");
                //}


                //Console.WriteLine("Bienvenido, Por favor, ingrese el ID del producto vendido que desea eliminar:");
                //string input = Console.ReadLine();
                //if (int.TryParse(input, out int soldProductId))
                //{
                //    if (gestorBaseDeDatos.DeleteSoldProduct(soldProductId))
                //    {
                //        Console.WriteLine("Producto vendido eliminado");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Producto vendido no encontrado.");
                //    }
                //}



                //Ejecución de Metodos de Venta:

                //Console.WriteLine("Bienvenido, Por favor, ingrese el ID de la venta que desea obtener:");
                //string input = Console.ReadLine();
                //if (int.TryParse(input, out int saleId))
                //{
                //    Venta sale = gestorBaseDeDatos.GetSale(saleId);

                //    if (sale != null)
                //    {
                //        Console.WriteLine($"Comentario: {sale.Comments}, Id Usuario: {sale.IdUser}");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Venta no encontrada.");
                //    }
                //}


                //List<Venta> sales = gestorBaseDeDatos.ListSale();
                //foreach (var sale in sales)
                //{
                //    Console.WriteLine($"Comentarios: {sale.Comments}, Id Usuario: {sale.IdUser}");
                //}


                //Venta newSale = new Venta("Muy buen producto", 2);
                //if (gestorBaseDeDatos.CreateSale(newSale))
                //{
                //    Console.WriteLine("Venta creada!");
                //}


                //Venta editSale = new Venta("Excelente Producto", 2);
                //if (gestorBaseDeDatos.UpdateSale(7, editSale))
                //{
                //    Console.WriteLine("Venta actualizada!");
                //}


                //Console.WriteLine("Bienvenido, Por favor, ingrese el ID de la venta que desea eliminar:");
                //string input = Console.ReadLine();
                //if (int.TryParse(input, out int saleId))
                //{
                //    if (gestorBaseDeDatos.DeleteSale(saleId))
                //    {
                //        Console.WriteLine("venta eliminada");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Venta no encontrada.");
                //    }
                //}


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    }
}
