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
using System.IO.IsolatedStorage;

namespace DemoPaginaInicio
{
    public class ISHelper
    {
        public static bool guardar(string llave, Object valor)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            bool respuesta = false;

            if (settings.Contains(llave))
            {
                if (settings[llave] != valor)
                {
                    settings[llave] = valor;
                }
                respuesta = true;
            }
            else
            {
                settings.Add(llave, valor);
                respuesta = true;
            }

            return respuesta;
        }

        public static bool existe(string llave)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            if (settings.Contains(llave)) return true; else return false;    
        }
    }
}
