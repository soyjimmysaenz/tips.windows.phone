using System.Collections.Generic;
using Microsoft.Phone.Controls;

namespace AnchoListBoxItemsDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();   
        }
    }

    public class ViewModel
    {
        public List<string> Personas { get; set; }

        public ViewModel()
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            Personas = new List<string>() { "Francesco Totti", "Franz Beckenbauer", "Juninho Pernambucano"};
        }
    }
}