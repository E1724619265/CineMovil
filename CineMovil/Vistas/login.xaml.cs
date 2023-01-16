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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btningresa_Clicked(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "Admin001";

            if (user == txtusser.Text && pass == txtpassword.Text)
            {
                Navigation.PushAsync(new crecomendado(user));
            }
            else
            {
                DisplayAlert("Error", "Usuario y/o Contraseña Incorrecta", "cerrar");
            }
        }

        private void btnregistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new registro());
        }
    }
}