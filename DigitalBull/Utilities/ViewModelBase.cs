using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace DigitalBull.Utilities
{
     class ViewModelBase : INotifyPropertyChanged
    {
        //clase para notificar automáticamente a la interfaz cuando cambia una propiedad de un ViewModel.
        public event PropertyChangedEventHandler PropertyChanged; // Este evento es el mecanismo que usa WPF para enterarse de que una propiedad ha cambiado. 
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
