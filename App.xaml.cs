using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Daniel_Montero_Ap1_p1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_DispatcherUnhandledException(Object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs args)
        {
            MessageBox.Show($"Ocurrio un error:({args.Exception.Message}","Errror no controlado",  MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
