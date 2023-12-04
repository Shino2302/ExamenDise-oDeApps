using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraDeCaloríasQuemadas_SAEG.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraDeCaloríasQuemadas_SAEG.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        public Calculadora()
        {
            InitializeComponent();
            BindingContext = new VMCalculadora(Navigation);
        }
    }
}