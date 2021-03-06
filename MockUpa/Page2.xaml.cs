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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void dalej_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        bool alreadyChoosen = false;
        private void dziewczynka_Clicked(object sender, EventArgs e)
        {
            if (alreadyChoosen == false)
            {
                dziewczynka.BackgroundColor = Color.HotPink;
                alreadyChoosen = true;
                dalej.IsEnabled = true;
                dalej.BackgroundColor = Color.FromHex("#E5F961");
            }
            else
            {
                dziewczynka.BackgroundColor = Color.HotPink;
                chlopiec.BackgroundColor = Color.DodgerBlue;
            }
            
        }

        private void chlopiec_Clicked(object sender, EventArgs e)
        {
            if (alreadyChoosen == false)
            {
                chlopiec.BackgroundColor = Color.MediumSlateBlue;
                alreadyChoosen = true;
                dalej.IsEnabled = true;
                dalej.BackgroundColor = Color.FromHex("#E5F961");
            }
            else
            {
                chlopiec.BackgroundColor = Color.MediumSlateBlue;
                dziewczynka.BackgroundColor = Color.FromHex("#FF00A0");
            }
            
        }
    }
}