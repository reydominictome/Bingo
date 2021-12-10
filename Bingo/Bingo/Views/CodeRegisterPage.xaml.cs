using Bingo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bingo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodeRegisterPage : ContentPage
    {
        public CodeRegisterPage()
        {
            InitializeComponent();
            BindingContext = new CodeRegisterViewModel();
        }
    }
}