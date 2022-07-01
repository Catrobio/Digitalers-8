namespace Digitalers_Console5
{
    public struct Clientes
    {
        public string Nombre;
        public string Apellido;
        public int Documento;

        public void Constructor(string nombre, string apellido, int documento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
        }
    }
}


