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
            Random rnd = new Random();
            int[] arr = Enumerable.Range(0, 4).OrderBy(c => rnd.Next()).ToArray();
            Grid.SetRow(button1, arr[0]);
            Grid.SetRow(button2, arr[1]);
            Grid.SetRow(button3, arr[2]);
            Grid.SetRow(button4, arr[3]);
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
            polecenie.Text = "Wybierz zwierzę:";
        }

        private void dalej_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page4();
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
