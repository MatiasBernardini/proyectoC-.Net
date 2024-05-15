namespace proyecto
{
    class Program
    {

        static void Main(string[] args)
        {
            string showName;
            string showDescription;
            int showIdProduct;
            string showComments;


            // creando objetos
            Usuario usuario_1 = new Usuario(1, "Matias", "Bernardini", "matiasBernardini", "matiasbernardini@gmail.com");

            Producto producto_1 = new Producto(1, "Producto de limpieza", 200.00, 270.00, 99, 1);

            ProductoVendido productoVendido_1 = new ProductoVendido(1, 1, 98, 1);

            Venta venta_1 = new Venta(1, "buen producto por su precio", 1);



            Console.WriteLine("nombre del primer usuario registrado: " + usuario_1.showName);
            Console.WriteLine("descripcion del primer producto: " + producto_1.showDescription);
            Console.WriteLine("el producto que se vendio contiene el id: " + productoVendido_1.showIdProduct);
            Console.WriteLine("el producto recibio el siguiente comentario: " + venta_1.showComments);

        }

    }
}
