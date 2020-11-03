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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

       private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage());
        }

        private void Button_ClickedLogin(object sender, EventArgs e)
        {
            App.Current.MainPage = new MasterMenu();
        }
    }
}