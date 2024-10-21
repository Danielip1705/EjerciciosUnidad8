using Android.Database;
using System.Collections.ObjectModel;

namespace Ejercicio5Listado
{
    public partial class MainPage : ContentPage
    {

        ObservableCollection personaCol = new ObservableCollection();
        public ObservableCollection per { get { return fruits; } }

        public MainPage()
        {

            InitializeComponent();
            
            clsPersona personaList = new clsPersona();
            List<clsPersona> lista = personaList
        }

       
    }

}
