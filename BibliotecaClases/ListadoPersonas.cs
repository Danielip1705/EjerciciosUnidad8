using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class ListadoPersonas
    {
    
        public static List<clsPersona> getListadoCompleto(clsPersona obj)
        {
            List<clsPersona> listadoPersona = new List<clsPersona>
            {
            new clsPersona("Daniel","Iglesias"),
            new clsPersona("Pablo","Iglesias"),
            new clsPersona("Maria","Prieto"),
            new clsPersona("Clovin","Mac"),
            new clsPersona("Peter","Parker"),
            new clsPersona("Charizard","Segura"),
            new clsPersona("Pepe","peposo"),
            new clsPersona("Evelyn","Afalgar"),
            new clsPersona("Tony","Hawk"),
            new clsPersona("Daniel","Iglesias")

            };
            return listadoPersona;   
        }
        

        
    }
}
