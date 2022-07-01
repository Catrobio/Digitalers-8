namespace Digitalers_Console5
{
    public class Program
    {
        public static void Main()
        {
            mostrarNombre();
        }
        static void mostrarNombre()
        {
            //Instaciar 
            var clientes = new Clientes();
            var funciones = new Funciones();

            Console.WriteLine("Indique el nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Indique el apellido");
            var apellido = Console.ReadLine();
            Console.WriteLine("Indique el documento");
            var documento = Convert.ToInt32(Console.ReadLine());

            clientes.Constructor(nombre,apellido,documento);

            var nombreCompleto = funciones.NombreCompleto(clientes.Nombre, clientes.Apellido);

            Console.WriteLine("Cliente: {0}  documento {1}", nombreCompleto, clientes.Documento);
        }

        
        
    }        
}
