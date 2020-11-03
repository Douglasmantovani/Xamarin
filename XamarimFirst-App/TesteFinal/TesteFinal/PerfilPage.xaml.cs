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
	public partial class PerfilPage : ContentPage
	{
        LoginViewModel lvm = new LoginViewModel();

        public PerfilPage ()
		{
        InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            
            this.BindingContext = lvm;
        }
	}
}