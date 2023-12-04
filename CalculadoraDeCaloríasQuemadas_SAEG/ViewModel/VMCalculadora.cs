using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculadoraDeCaloríasQuemadas_SAEG.ViewModel
{
    public class VMCalculadora : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        double _PesoKG;
        double _Duracion;
        double _Resultado;
        bool _MostrarResultado;
        bool _Foto;
        #endregion
        #region CONSTRUCTOR
        public VMCalculadora(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public double Duracion
        {
            get { return _Duracion; }
            set { SetValue(ref _Duracion, value); }
        }
        public double PesoKG
        {
            get { return _PesoKG; }
            set { SetValue(ref _PesoKG, value); }
        }
        public double Resultado
        {
            get { return _Resultado; }
            set { SetValue(ref _Resultado, value);}
        }
        public bool MostrarResultado
        {
            get { return _MostrarResultado;}
            set { SetValue(ref _MostrarResultado, value); }
        }
        public bool Foto
        {
            get { return _Foto;}
            set { SetValue(ref _Foto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        }
        public void CalcularResultado()
        {
            if(PesoKG <= 0 || Duracion <= 0)
            {
                DisplayAlert("Error", "Ingrese sus datos correctamente", "ok");
                MostrarResultado= false;
            }
            else
            {
                Resultado = Duracion * 10 * (PesoKG / 200);
                MostrarResultado= true;
                if (Resultado < 250)
                {
                    DisplayAlert("Motivación",$"Perdiste: {Resultado} calorias. Deberias Correr Más Para Superarte","OK");
                    Foto = false;
                }
                else if(Resultado >= 250 && Resultado < 500)
                {
                    DisplayAlert("Motivación",$"Perdiste: {Resultado} calorias. Manten Ese Ritmo Tú Puedes Con Mucho Más","OK");
                    Foto = false;
                }
                else
                {
                    DisplayAlert("Motivación",$"Perdiste: {Resultado} calorias. Felicidades Te Estas Mamadisimo","OK");
                    Foto = true;
                }


            }
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        public ICommand CalcularResultadocomand => new Command(CalcularResultado);
        #endregion
    }
}
