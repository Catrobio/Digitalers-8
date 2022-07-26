using Digitalers_Console6.Clases;

public class inicial
{
    static void Main()
    {
        var listaTelefono = new List<Telefonos>();

        var telefono1 = new Telefonos
        {
            IdCliente = 1,
            IdTelefono = 1,
            Numero = "123456"
        };

        listaTelefono.Add(telefono1);

        var telefono2 = new Telefonos
        {
            IdCliente = 1,
            IdTelefono = 2,
            Numero = "654321"
        };

        listaTelefono.Add(telefono2);

        var clientes = new Clientes
        {
            IdCliente = 1,
            Nombre = "ignacio",
            Apellido = "Pacheco",
            Email = "fpacheco527@gmail.com",
            Fax = "123456",
            ListTelefonos = listaTelefono
        };

        foreach (var tel in clientes.ListTelefonos)
        {
            clientes.LLamar(tel.IdTelefono);
        }
        

        clientes.EnviarMail("menasje");



        //clientes.setearClientes(1, "Ignacio", "Pacheco", "5332222", "fpacheco527@gmail.com");

        clientes.EnviarMail("El mail enviado a ");
       
    }
}