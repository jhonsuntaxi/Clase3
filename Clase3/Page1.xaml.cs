using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clase3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string user, string pass)
        {
            InitializeComponent();

            lblUser.Text = user;
            txtPass.Text = pass;
        }
    }
}