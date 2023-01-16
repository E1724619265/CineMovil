using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CineMovil.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro()
        {
            InitializeComponent();
        }

        private void btncrear_Clicked(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtnombre.Text);
            string usuario = Convert.ToString(txtcorreo.Text);
            string correo = Convert.ToString(txtcorreo.Text);
            string cont = Convert.ToString(txtcontraseña.Text);

            if(nombre == txtnombre.Text && usuario == txtusuario.Text)
            {
                DisplayAlert("Felicidades", "Nombre y usuario guardados con exito...", "cerrar");
            }
            if (correo == txtcorreo.Text && cont == txtcontraseña.Text)
            {
                DisplayAlert("Felicidades", "Correo y contraseña guardados con exito...", "cerrar");

                Navigation.PushAsync(new login());
            }
        }
    }
}