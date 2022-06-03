using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLogin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sPassword = txtPassword.Text;

            if(sUsuario == "AndresATzuc001@hotmail.com" && sPassword == "@5001Fk" +
                "f")
            {
                Navigation.PushAsync(new Dashboard());
            }
            else
            {
                lblResultado.Text = "El usuario o contraseña son incorrectos";
            }
        }
    }
}