using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calc_IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string resultado = "";

                if (imc < 18.5)
                {
                    resultado = "Tienes bajo peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tu peso es normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Tienes sobre peso";
                }
                else
                {
                    resultado = "Tienes Obesidad, ¡Cuidate!";
                }
                DisplayAlert("Resultado", resultado, "Ok");
            }
            else
            {
                DisplayAlert("Datos Erróneos", "Por Favor llenar toda la información", "Ok");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Integrantes: ", "Alex Francisco Maltez Barrios\nJairo Cristopher Ramos Hernández", "Ok");
        }
    }
}
