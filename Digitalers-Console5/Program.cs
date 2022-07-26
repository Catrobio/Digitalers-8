namespace Digitalers_Console5
{
    public class Program
    {
        public static void Main()
        {
            mostrarNombre();
            MostrarNombresArray();
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

        static void MostrarNombresArray()
        {
            //Instaciar 
            Clientes[] clientes = new Clientes[3];
            //Instaciar 
            var funciones = new Funciones();

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Indique el nombre");
                clientes[i].Nombre = Console.ReadLine();
                Console.WriteLine("Indique el apellido");
                clientes[i].Apellido = Console.ReadLine();
                Console.WriteLine("Indique el documento");
                clientes[i].Documento = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < clientes.Length; i++)
            {
                var nombreCompleto = funciones.NombreCompleto(clientes[i].Nombre, clientes[i].Apellido);

                Console.WriteLine("Cliente: {0}  documento {1}", nombreCompleto, clientes[i].Documento);
            }
        }
        
        
    }        
}
