using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MockUpa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        bool alreadyChoosen = false;
        private void tak_Clicked(object sender, EventArgs e)
        {
            if (alreadyChoosen == false)
            {
                tak.BackgroundColor = Color.LightGreen;
                alreadyChoosen = true;
                dalej.IsEnabled = true;
                dalej.BackgroundColor = Color.FromHex("#E5F961");
            }
            else
            {
                tak.BackgroundColor = Color.LightGreen;
                nie.BackgroundColor = Color.FromHex("#E5F961");
            }
        }

        private void nie_Clicked(object sender, EventArgs e)
        {
            if (alreadyChoosen == false)
            {
                nie.BackgroundColor = Color.LightGreen;
                alreadyChoosen = true;
                dalej.IsEnabled = true;
                dalej.BackgroundColor = Color.FromHex("#E5F961");
            }
            else
            {
                nie.BackgroundColor = Color.LightGreen;
                tak.BackgroundColor = Color.FromHex("#E5F961");
            }
        }

        private void dalej_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page5();
        }
    }
}