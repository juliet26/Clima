namespace Clima.ViewModel
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class WeatherViewModelPage : NotificableViewModel
    {
        #region Atributos
        private string ubicacion;
        private string pais;
        private string resultTerm;
        private string region;
        private string ultimaActualizacion;
        private string clima;
        private string tempereatura;
        private ImageSource imagen;
        #endregion

        #region Propiedades
        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }
            set
            {
                SetValue(ref ubicacion, value);
            }
        }
        public string Pais
        {
            get
            {
                return pais;
            }
            set
            {
                SetValue(ref pais, value);
            }
        }
        public string ResultTerm
        {
            get
            {
                return resultTerm;
            }
            set
            {
                SetValue(ref resultTerm, value);
            }
        }
        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                SetValue(ref region, value);
            }
        }
        public string UltimaActualizacion
        {
            get
            {
                return ultimaActualizacion;
            }
            set
            {
                SetValue(ref ultimaActualizacion, value);
            }
        }
        public string Clima
        {
            get
            {
                return clima;
            }
            set
            {
                SetValue(ref clima, value);
            }
        }
        public string Temperatura
        {
            get
            {
                return tempereatura;
            }
            set
            {
                SetValue(ref tempereatura, value);
            }
        }
        public ImageSource Image
        {
            get
            {
                return imagen;
            }
            set
            {
                SetValue(ref imagen, value);
            }
        }
        #endregion

            #region Comandos
            public ICommand BuscarCommand
            {
                get
                {
                    return new RelayCommand(Buscar);
                }
            }

            private void Buscar()
            {
                throw new NotImplementedException();
            }
            #endregion

            #region Constructores
            public WeatherViewModelPage()
            {

            }
            #endregion
    }
}
