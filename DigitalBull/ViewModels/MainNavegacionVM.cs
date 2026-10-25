using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DigitalBull.Utilities;


namespace DigitalBull.ViewModels
{
    class MainNavegacionVM : ViewModelBase
    {
        private object _currentViewModel; //Esta variable guarda la referencia al ViewModel
        public object CurrentView // Esta propiedad permite acceder a al valores
        {
            get { return _currentViewModel; } //Simplemente devuelve el ViewModel actual
            set { _currentViewModel = value; OnPropertyChanged(); }
        }


        // definimos los comandos para cambiar de vista
        public ICommand ControlProduccionCarneCommand { get; set; }
        public ICommand ControlProduccionLecheCommand { get; set; }
        public ICommand ControlViaticosCommand { get; set; }
        public ICommand InventarioAlimentoCarneCommand { get; set; }
        public ICommand InventarioAlimentoLecheCommand { get; set; }
        public ICommand InventarioMedicinaCommand { get; set; }
        public ICommand PlanillaCommand { get; set; }
        public ICommand RegistroColaboradoresCommand { get; set; }
        public ICommand RegistroGastosActivosCommand { get; set; }
        public ICommand RegistroGastosAlimentacionCarneCommand { get; set; }
        public ICommand RegistroGastosAlimentacionLecheCommand { get; set; }
        public ICommand RegistroGastosVeterinarioCarneCommand { get; set; }
        public ICommand RegistroGastosVeterinarioLecheCommand { get; set; }
        public ICommand RegistroHatoCommand { get; set; }
        public ICommand RegistroUsuarioCommand { get; set; }
        public ICommand MainNavegacionViewCommand { get; set; }

        // definimos los metodos para cambiar de vista
        private void ControlProduccionCarneView(object obj) => CurrentView = new ControlProduccionCarneVM();
        private void ControlProduccionLecheView(object obj) => CurrentView = new ControlProduccionLecheVM();
        private void ControlViaticosView(object obj) => CurrentView = new ControlViaticosVM();
        private void InventarioAlimentoCarneView(object obj) => CurrentView = new InventarioAlimentoCarneVM();
        private void InventarioAlimentoLecheView(object obj) => CurrentView = new InventarioAlimentoLecheVM();
        private void InventarioMedicinaView(object obj) => CurrentView = new InventarioMedicinaVM();
        private void PlanillaView(object obj) => CurrentView = new PlanillaVM();
        private void RegistroColaboradoresView(object obj) => CurrentView = new RegistroColaboradoresVM();
        private void RegistroGastosActivosView(object obj) => CurrentView = new RegistroGastosActivosVM();
        private void RegistroGastosAlimentacionCarneView(object obj) => CurrentView = new RegistroGastosAlimentacionCarneVM();
        private void RegistroGastosAlimentacionLecheView(object obj) => CurrentView = new RegistroGastosAlimentacionLecheVM();
        private void RegistroGastosVeterinarioCarneView(object obj) => CurrentView = new RegistroGastosVeterinarioCarneVM();
        private void RegistroGastosVeterinarioLecheView(object obj) => CurrentView = new RegistroGastosVeterinarioLecheVM();
        private void RegistroHatoView(object obj) => CurrentView = new RegistroHatoVM();
        private void RegistroUsuarioView(object obj) => CurrentView = new RegistroUsuarioVM();

        // Constructor
        //conecta el comando con el método que se ejecutará cuando el usuario pulse el botón
        public MainNavegacionVM()
        {
            ControlProduccionCarneCommand = new RelayCommand(ControlProduccionCarneView);
            ControlProduccionLecheCommand = new RelayCommand(ControlProduccionLecheView);
            ControlViaticosCommand = new RelayCommand(ControlViaticosView);
            InventarioAlimentoCarneCommand = new RelayCommand(InventarioAlimentoCarneView);
            InventarioAlimentoLecheCommand = new RelayCommand(InventarioAlimentoLecheView);
            InventarioMedicinaCommand = new RelayCommand(InventarioMedicinaView);
            PlanillaCommand = new RelayCommand(PlanillaView);
            RegistroColaboradoresCommand = new RelayCommand(RegistroColaboradoresView);
            RegistroGastosActivosCommand = new RelayCommand(RegistroGastosActivosView);
            RegistroGastosAlimentacionCarneCommand = new RelayCommand(RegistroGastosAlimentacionCarneView);
            RegistroGastosAlimentacionLecheCommand = new RelayCommand(RegistroGastosAlimentacionLecheView);
            RegistroGastosVeterinarioCarneCommand = new RelayCommand(RegistroGastosVeterinarioCarneView);
            RegistroGastosVeterinarioLecheCommand = new RelayCommand(RegistroGastosVeterinarioLecheView);
            RegistroHatoCommand = new RelayCommand(RegistroHatoView);
            RegistroUsuarioCommand = new RelayCommand(RegistroUsuarioView);

            // Pagina de inicio
            CurrentView = new MainNavegacionVM();

        }
    }
}
