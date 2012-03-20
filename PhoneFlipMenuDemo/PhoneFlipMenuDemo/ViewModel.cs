using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Linq.Expressions;
using ScottIsAFool.WindowsPhone.Tools; 

namespace PhoneFlipMenuDemo
{
    public class ViewModel
    {
        private readonly ICommand _CmdMenu;
		public ICommand CmdMenu
		{
			get
			{
                return _CmdMenu;
			}
		}

        public ViewModel()
        {            
            _CmdMenu = new RelayCommand(CargarMenu) { IsEnabled = true };
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
