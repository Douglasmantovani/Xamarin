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
	public partial class EditarPage : ContentPage
	{
        LoginViewModel lvm = new LoginViewModel();

		public EditarPage ()
		{
			InitializeComponent ();
		}

        private void OnClicked_Editar(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.Email = lbEmail.Text;
                usuario.Nome = lbNome.Text;
                usuario.Telefone = lbTelefone.Text;

                if (lvm.Atualizar(usuario))
                {
                    DisplayAlert("", "Usuario atualizado com sucesso", "Fechar");
                    lvm.RemoveSESSION();
                    Navigation.PushAsync(new LoginPage());
                }
                else
                {
                    DisplayAlert("", "Nao foi possivel atualizar", "Fechar");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("", "Erro no sistema", "Fechar");
            }
        }
    }
}