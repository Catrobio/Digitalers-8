

namespace Digitalers_Console6.Clases
{
    public class Clientes
    {
        public int IdCliente;
        public List<Telefonos> ListTelefonos;
        public string Nombre;
        public string Apellido;
        public string Fax;
        public string Email;

        public void setearClientes(int id, string nombre, string apellido, string fax, string email)
        {
            this.IdCliente = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fax = fax;
            this.Email = email;            
        }
        public void ActualizarClientes(int id, string nombre, string apellido, string fax, string email)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fax = fax;
            this.Email = email;
        }
        public void BorrarCliente(int id)
        {
            this.IdCliente = 0;
            this.Nombre = null;
            this.Apellido = null;
            this.Fax = null;
            this.Email = null;

        }
        public void EnviarMail(string mensaje, int id)
        {
            Console.WriteLine("{0}: {1}", mensaje, id);
        }
        public void EnviarMail(string mensaje)
        {
            Console.WriteLine("{0}: {1}",mensaje,this.IdCliente);
        }   

        public void LLamar(int idTelefono)
        {
            Console.WriteLine("Llamando a: {0}", idTelefono);
        }

    }
}
