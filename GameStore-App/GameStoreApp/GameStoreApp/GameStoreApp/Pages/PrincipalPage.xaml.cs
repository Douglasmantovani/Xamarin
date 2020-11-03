using GameStoreApp.ViewModels;
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
    public partial class PrincipalPage : ContentPage
    {
        JogosViewModel vm = new JogosViewModel();
        public PrincipalPage()
        {
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}