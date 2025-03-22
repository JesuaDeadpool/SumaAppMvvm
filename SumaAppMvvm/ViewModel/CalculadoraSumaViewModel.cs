using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAppMvvm.ViewModel
{
    public partial class CalculadoraSumaViewModel : ObservableObject
    {

        [ObservableProperty]
        private double primerNumero;

        [ObservableProperty]
        private double segundoNumero;

        [ObservableProperty]
        private double resultado; 

        [RelayCommand]
        public void Calcular()
        {
            try
            {

                if (PrimerNumero == 0)
                {
                    Alerta("CAMPOS VACIOS", "Primer Numero esta vacio");

                }
                else if (SegundoNumero == 0)
                {
                    Alerta("CAMPOS VACIOS", "Segundo Numero esta vacio");

                }
                else
                {
                    Resultado = PrimerNumero + SegundoNumero;
                }

            }
            catch (Exception e)
            {
               Alerta("ERROR", e.Message);
            }

        }

        [RelayCommand]
        public void Limpiar()
        {
            PrimerNumero = 0;
            SegundoNumero = 0;
            Resultado = 0; 
        }

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }
    }
}
