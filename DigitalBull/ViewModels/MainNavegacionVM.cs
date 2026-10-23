using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DigitalBull.Utilities;


namespace DigitalBull.ViewModels
{
    class MainNavegacionVM : ViewModelBase
    {
        private object _currentViewModel;
        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value; OnPropertyChanged(); }
        }

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


        private void ControlProduccionCarneView(object obj) => CurrentViewModel = new ControlProduccionCarneVM();
        private void ControlProduccionLecheView(object obj) => CurrentViewModel = new ControlProduccionLecheVM();
        private void ControlViaticosView(object obj) => CurrentViewModel = new ControlViaticosVM();
        private void InventarioAlimentoCarneView(object obj) => CurrentViewModel = new InventarioAlimentoCarneVM();
        private void InventarioAlimentoLecheView(object obj) => CurrentViewModel = new InventarioAlimentoLecheVM();
        private void InventarioMedicinaView(object obj) => CurrentViewModel = new InventarioMedicinaVM();
        private void PlanillaView(object obj) => CurrentViewModel = new PlanillaVM();
        private void RegistroColaboradoresView(object obj) => CurrentViewModel = new RegistroColaboradoresVM();
        private void RegistroGastosActivosView(object obj) => CurrentViewModel = new RegistroGastosActivosVM();
        private void RegistroGastosAlimentacionCarneView(object obj) => CurrentViewModel = new RegistroGastosAlimentacionCarneVM();
        private void RegistroGastosAlimentacionLecheView(object obj) => CurrentViewModel = new RegistroGastosAlimentacionLecheVM();
        private void RegistroGastosVeterinarioCarneView(object obj) => CurrentViewModel = new RegistroGastosVeterinarioCarneVM();
        private void RegistroGastosVeterinarioLecheView(object obj) => CurrentViewModel = new RegistroGastosVeterinarioLecheVM();
        private void RegistroHatoView(object obj) => CurrentViewModel = new RegistroHatoVM();
        private void RegistroUsuarioView(object obj) => CurrentViewModel = new RegistroUsuarioVM();

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

        }
    }
}
