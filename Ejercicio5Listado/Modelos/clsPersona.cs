using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio5Listado
{

    public class clsPersona
    {
        #region Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion Atributos
        #region Constructor
        public clsPersona(string nombreUsu, string ApellidoUsu)
        {
            Nombre = nombreUsu;
            Apellido = ApellidoUsu;

        }
        #endregion
    }


}
