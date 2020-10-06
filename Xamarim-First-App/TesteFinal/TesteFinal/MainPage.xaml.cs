using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteFinal.Models;
using TesteFinal.ViewModels;
using Xamarin.Forms;

namespace TesteFinal
{
    public partial class MainPage : ContentPage
    {
        LoginViewModel lvm = new LoginViewModel();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked_Perfil(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PerfilPage());
        }

        private void OnClicked_Editar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditarPage());
        }

        private void OnClicked_Deletar(object sender, EventArgs e)
        {
            bool Click = true;

            try
            {
                Usuario usuarioLogado = lvm.BuscarUsuarioLogadoDeletar();
               
                if (usuarioLogado == null)
                {
                    DisplayAlert("", "Usuario logado nao encontrado", "Fechar");
                }
                else
                {
                    lvm.Deletar(Click);
                    DisplayAlert("", "Usuario Deletado", "Fechar");

                    Navigation.PushAsync(new LoginPage());
                }
            }catch(Exception ex)
            {
                DisplayAlert("", "Erro no sistema", "Fechar");
            }          
        }
    }
}
