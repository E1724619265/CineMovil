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
    public partial class carteleraCinemarck : ContentPage
    {
        public carteleraCinemarck(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
        }
    }
}