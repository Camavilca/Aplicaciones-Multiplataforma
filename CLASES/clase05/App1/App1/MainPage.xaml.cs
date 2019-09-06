using System;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.Title = "Tecsup";

            var stack = new StackLayout();

            var btn01 = new Button();
            btn01.Text = "Item1";
            btn01.TextColor = Color.Blue;
            btn01.Clicked += buton01;
            stack.Children.Add(btn01);

            Button btn02 = new Button();
            btn02.Text = "Item2";
            btn02.TextColor = Color.Blue;
            btn02.Clicked += buton02;
            stack.Children.Add(btn02);

            Button btn03 = new Button();
            btn03.Text = "Item2";
            btn03.TextColor = Color.Blue;
            btn03.Clicked += buton03;
            stack.Children.Add(btn03);


            Button btn04 = new Button();
            btn04.Text = "Item2";
            btn04.TextColor = Color.Blue;
            btn04.Clicked += buton04;
            stack.Children.Add(btn04);

            Button btn05 = new Button();
            btn05.Text = "Item2";
            btn05.TextColor = Color.Blue;
            btn05.Clicked += buton05;
            stack.Children.Add(btn05);

            Button btn06 = new Button();
            btn06.Text = "Item2";
            btn06.TextColor = Color.Blue;
            btn06.Clicked += buton06;
            stack.Children.Add(btn06);

            Content = stack;

            async void buton01(object sender, EventArgs e)
            {
                await Navigation.PushModalAsync(new Page1());
            }

            async void buton02(object sender, EventArgs e)
            {
                await Navigation.PushModalAsync(new Page2());
            }

            async void buton03(object sender, EventArgs e)
            {
                await Navigation.PushModalAsync(new Page3());
            }

            async void buton04(object sender, EventArgs e)
            {
                await Navigation.PushModalAsync(new Page4());
            }

            async void buton05(object sender, EventArgs e)
            {
                await Navigation.PushModalAsync(new Page5());
            }

            async void buton06(object sender, EventArgs e)
            {
                await Navigation.PushModalAsync(new Page6());
            }

        }
    }
}
