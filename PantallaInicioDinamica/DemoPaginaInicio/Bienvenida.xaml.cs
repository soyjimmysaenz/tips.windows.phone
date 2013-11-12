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

namespace DemoPaginaInicio
{
    public partial class Bienvenida : PhoneApplicationPage
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void btnIr_Click(object sender, EventArgs e) /**/
        {
            ISHelper.guardar(App.SALTAR_INTRO, App.SALTAR_INTRO);
            NavigationService.Navigate(new Uri(App.MAINPAGE, UriKind.Relative));
        }
    }
}