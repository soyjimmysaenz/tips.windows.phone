using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PhoneFlipMenuDemo
{
    class RelayCommand : ICommand
    {
        private Action handler;
        private bool _IsEnabled;

        //Constructor
        public RelayCommand(Action _handler)
        {
            handler = _handler;
        }
        //Determina si el comando se puede ejecutar y desactiva o activa los controles asociados.
        public bool IsEnabled
        {
            get { return _IsEnabled; }
            set
            {
                if (value != _IsEnabled)
                {
                    _IsEnabled = value;
                    if (CanExecuteChanged != null)
                    {
                        CanExecuteChanged(this, EventArgs.Empty);
                    }
                }
            }
        }
        //indica si el comando se puede ejecutar, no la llamamos directamente nosotros.
        public bool CanExecute(object parameter)
        {
            return IsEnabled;
        }
        public event EventHandler CanExecuteChanged;
        //Ejecuta la acción indicada en la variable handler.
        public void Execute(object parameter)
        {
            handler();
        }
    }
}
