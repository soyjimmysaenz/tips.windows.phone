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
using ScottIsAFool.WindowsPhone.Tools;

namespace PhoneFlipMenuDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            CargarMenu();
        }

        private void CargarMenu()
        {
            new PhoneFlipMenu(
                new PhoneFlipMenuAction("menú 1", () =>
                {
                    MessageBox.Show("Menú 1");
                }),
                new PhoneFlipMenuAction("menú 2", () =>
                {
                    MessageBox.Show("Menú 2");
                }),
                new PhoneFlipMenuAction("menú 3", () =>
                {
                    MessageBox.Show("Menú 3");
                }))
            .Show();
        }       
    }
}