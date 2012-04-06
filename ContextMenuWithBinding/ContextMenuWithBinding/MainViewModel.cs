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
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;

namespace ContextMenuWithBinding
{
    public class MainViewModel:ViewModelBase
    {
        public ObservableCollection<Usuario> Usuarios { get; set; }
        private string _Titulo;
        public string Titulo
        {
            get { return _Titulo; }
            set
            {
                if (_Titulo != value)
                {
                    _Titulo = value;
                    RaisePropertyChanged("Titulo");
                }
            }
        }

        private Usuario _UsuarioSeleccionado;
        public Usuario UsuarioSeleccionado
        {
            get { return _UsuarioSeleccionado; }
            set
            {
                if (_UsuarioSeleccionado != value)
                {
                    _UsuarioSeleccionado = value;
                    RaisePropertyChanged("UsuarioSeleccionado");
                }
            }
        }                

        public MainViewModel()
        {
            _ComandoBuscar = new RelayCommand<Usuario>((s) => buscar(s), (e) => true);
            Usuarios = new ObservableCollection<Usuario>() 
            {
                new Usuario{Nombres = "Jimmy", Apellidos = "Saenz"},
                new Usuario{Nombres = "Ana", Apellidos = "Rocha"}
            };
            Titulo = "ContextMenu";            
        }
               

        private readonly ICommand _ComandoBuscar;
        public ICommand ComandoBuscar
        {
            get { return _ComandoBuscar; }
        }

        private void buscar(Usuario usuario)
        {
            if (usuario != null)
            { 
                UsuarioSeleccionado = usuario;
                MessageBox.Show(string.Format("Elegiste el elem {0} {1}", 
                            UsuarioSeleccionado.Nombres, UsuarioSeleccionado.Apellidos));
            }
        }
                
    }
}
