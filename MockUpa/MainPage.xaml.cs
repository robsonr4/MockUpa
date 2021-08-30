using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace MockUpa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            /*App.Current.MainPage = new Page1();*/
            button1.IsEnabled = false;
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button1.BackgroundColor = Color.Gray;
            button2.BackgroundColor = Color.Gray;
            button3.BackgroundColor = Color.Gray;
            button4.BackgroundColor = Color.Gray;
            imagButton1.IsEnabled = true;
            imagButton2.IsEnabled = true;
            imagButton3.IsEnabled = true;
            imagButton4.IsEnabled = true;
            imagButton1.BackgroundColor = Color.FromHex("#E5F961");
            imagButton2.BackgroundColor = Color.FromHex("#E5F961");
            imagButton3.BackgroundColor = Color.FromHex("#E5F961");
            imagButton4.BackgroundColor = Color.FromHex("#E5F961");
        }

        private void dalej_Clicked(object sender, EventArgs e)
        {

        }

        bool imageChoosen = false;
        ImageButton choosenBtn;
        public void imagButton_Clicked(object sender, EventArgs e)
        {
            var btn = (ImageButton)sender;
            if (imageChoosen == false)
            { 
                btn.BackgroundColor = Color.LightGreen;
                choosenBtn = btn;
                imageChoosen = true;
                dalej.IsEnabled = true;
                dalej.BackgroundColor = Color.FromHex("#E5F961");
            }
            else
            {
                choosenBtn.BackgroundColor = Color.FromHex("#E5F961");
                btn.BackgroundColor = Color.LightGreen;
                choosenBtn = btn;
            }
        }
    }
}
