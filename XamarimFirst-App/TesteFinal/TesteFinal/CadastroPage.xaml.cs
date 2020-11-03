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
	public partial class CadastroPage : ContentPage
	{
        LoginViewModel lvm = new LoginViewModel();

        public CadastroPage ()
		{
			InitializeComponent ();
		}

        private void OnClicked_Login(object sender, EventArgs e)
        {
            Usuario usuarioNovo = new Usuario();

            usuarioNovo.Nome = lbNome.Text;

            usuarioNovo.Email = lbEmail.Text;

            usuarioNovo.Senha = lbSenha.Text;

            usuarioNovo.Telefone = lbTelefone.Text;

            if (lvm.Cadastrar(usuarioNovo))
            {
                Navigation.PushAsync(new LoginPage());
            }
            else
            {
                DisplayAlert("", "Nao foi possivel efetuar o cadastro", "Fechar");
            }   
        }
    }
}