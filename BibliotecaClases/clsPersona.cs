using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaClases
{
    public class clsPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public clsPersona(string nombreUsu, string ApellidoUsu)
        {
            Nombre = nombreUsu;
            Apellido = ApellidoUsu;

        }
    }

    
}
