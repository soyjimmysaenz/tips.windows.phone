using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DemoAppBarsDinamicos
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private string[] AppBars = new string[]
        {
            "appbar1",
            "appbar2",
            "appbar3"
        };

        private void PanoramaPrinc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            ApplicationBar = ((ApplicationBar)Resources[this.AppBars[this.PanoramaPrinc.SelectedIndex]]);
        }

        private void elem1_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pagina2.xaml", UriKind.Relative));
        }	
		
    }
}