using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Listado
{
    public class ListadoPersonas
    {
    
        public List<clsPersona> getListadoCompleto(clsPersona obj)
        {
            List<clsPersona> listadoPersona = new List<clsPersona>
            {
            new clsPersona("Daniel","Iglesias","patata@gmail.com"),
            new clsPersona("Pablo","Iglesias","pabloiglesias@gmail.com"),
            new clsPersona("Maria","Prieto","marilyn@gmail.com"),
            new clsPersona("Clovin","Mac","macClovin777@gmail.com"),
            new clsPersona("Peter","Parker","nosoyspidy@gmail.com"),
            new clsPersona("Charizard","Segura","pokemofan1122@gmail.com"),
            new clsPersona("Pepe","peposo","pepepo@gmail.com"),
            new clsPersona("Evelyn","Afalgar","evelyn@gmail.com"),
            new clsPersona("Tony","Hawk","proskater1@gmail.com"),
            new clsPersona("Daniel","Iglesias","patata@gmail.com")

            };
            return listadoPersona;   
        }
        

        
    }
}
