using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameStoreApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();   
        }

        private async void Button_ClickedPerfil(object sender, EventArgs e)
        {
            await App.NavigationMasterDetail(new PerfilPage());
        }
    }
}