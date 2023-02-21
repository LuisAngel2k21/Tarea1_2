using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarea1_2.Models;

namespace Tarea1_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }
        public SecondPage(string pnombre, string papellidos, string pedad, string pcorreo)

        {
            InitializeComponent();

            nombre.Text = pnombre;
            apellido.Text = papellidos;
            edad.Text = pedad;
            correo.Text = pcorreo;

        }
    }
}