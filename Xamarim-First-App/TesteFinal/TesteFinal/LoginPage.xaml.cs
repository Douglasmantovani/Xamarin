using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteFinal.Models;
using TesteFinal.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        LoginViewModel lvm = new LoginViewModel();

		public LoginPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void OnClicked_Entrar(object sender, EventArgs e)
        {
            LoginClass login = new LoginClass();

            login.Email = lbEmail.Text;

            login.Senha = lbSenha.Text;

            Usuario usuarioBuscado = lvm.Login(login.Email, login.Senha);

            if (usuarioBuscado != null)
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("", "Email ou senha incorretos","Fechar");
            }        
        }
        private void OnClicked_Cadastrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage());
        }
    }
}