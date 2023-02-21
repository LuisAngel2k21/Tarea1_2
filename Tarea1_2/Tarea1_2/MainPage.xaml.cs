using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void b_enviar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.datos
            {

                nombre = Nombre.Text,
                apellidos = Apellido.Text,
                edad = Edad.Text,
                correo = Correo.Text
            };


            var segunda = new SecondPage();
            segunda.BindingContext = emple;
            await Navigation.PushAsync(segunda);
        }
    }
}