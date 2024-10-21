using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio5Listado
{
    public class clsPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }

        public clsPersona(string nombreUsu, string ApellidoUsu, string MailUsu)
        {
            Nombre = nombreUsu;
            Apellido = ApellidoUsu;
            Mail = MailUsu;

        }
        public clsPersona() { }
    }

    
}
