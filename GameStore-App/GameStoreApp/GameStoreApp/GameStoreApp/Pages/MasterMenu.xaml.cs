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
    public partial class MasterMenu : MasterDetailPage
    {
        public MasterMenu()
        {
            InitializeComponent();
            this.Master = new MenuPrincipal();
            this.Detail = new NavigationPage(new PrincipalPage());
            App.MasterDetail = this;
        }
    }
}