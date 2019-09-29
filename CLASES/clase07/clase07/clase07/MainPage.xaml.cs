using clase07.View;
using System;
using Xamarin.Forms;

namespace clase07
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.Title = "Tecsup";

            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var btn01 = new Button();
            btn01.Text = "Explicit Demo";
            btn01.TextColor = Color.AliceBlue;
            btn01.Image = "venom.png";
            btn01.HorizontalOptions = LayoutOptions.Center;
            btn01.Clicked += btnExplicitDemo;


            var btn02 = new Button();
            btn02.Text = "Explicit Code";
            btn02.TextColor = Color.AliceBlue;
            btn02.Image = "venom.png";
            btn02.HorizontalOptions = LayoutOptions.Center;
            btn02.Clicked += btnExplicitCode;

            var btn03 = new Button();
            btn03.Text = "Explicit Control Demo";
            btn03.TextColor = Color.AliceBlue;
            btn03.Image = "venom.png";
            btn03.HorizontalOptions = LayoutOptions.Center;
            btn03.Clicked += btnExplicitControlDemo;

            var btn04 = new Button();
            btn04.Text = "Explicit Control Code";
            btn04.TextColor = Color.AliceBlue;
            btn04.Image = "venom.png";
            btn04.HorizontalOptions = LayoutOptions.Center;
            btn04.Clicked += btnExplicitControlCode;

            var btn05 = new Button();
            btn05.Text = "Implicid Demo";
            btn05.TextColor = Color.AliceBlue;
            btn05.Image = "venom.png";
            btn05.HorizontalOptions = LayoutOptions.Center;
            btn05.Clicked += btnImplicidDemo;


            var btn06 = new Button();
            btn06.Text = "Implicid Code";
            btn06.TextColor = Color.AliceBlue;
            btn06.Image = "venom.png";
            btn06.HorizontalOptions = LayoutOptions.Center;
            btn06.Clicked += btnImplicidCode;


            var btn07 = new Button();
            btn07.Text = "Implicid Control Demo";
            btn07.TextColor = Color.AliceBlue;
            btn07.Image = "venom.png";
            btn07.HorizontalOptions = LayoutOptions.Center;
            btn07.Clicked += btnImplicidControlDemo;

            var btn08 = new Button();
            btn08.Text = "Global Demo";
            btn08.TextColor = Color.AliceBlue;
            btn08.Image = "venom.png";
            btn08.HorizontalOptions = LayoutOptions.Center;
            btn08.Clicked += btnGlobalDemo;

            var btn09 = new Button();
            btn09.Text = "Global Code";
            btn09.TextColor = Color.AliceBlue;
            btn09.Image = "venom.png";
            btn09.HorizontalOptions = LayoutOptions.Center;
            btn09.Clicked += btnGlobalCode;

            var btn10 = new Button();
            btn10.Text = "Inheritance Code";
            btn10.TextColor = Color.AliceBlue;
            btn10.Image = "venom.png";
            btn10.HorizontalOptions = LayoutOptions.Center;
            btn10.Clicked += btnInheritanceCode;

            var btn11 = new Button();
            btn11.Text = "Inheritance Demo";
            btn11.TextColor = Color.AliceBlue;
            btn11.Image = "venom.png";
            btn11.HorizontalOptions = LayoutOptions.Center;
            btn11.Clicked += btnInheritanceDemo;

            var btn12 = new Button();
            btn12.Text = "Dynamic Demo";
            btn12.TextColor = Color.AliceBlue;
            btn12.Image = "venom.png";
            btn12.HorizontalOptions = LayoutOptions.Center;
            btn12.Clicked += btnDynamicDemo;


            var btn13 = new Button();
            btn13.Text = "Dynamic Code";
            btn13.TextColor = Color.AliceBlue;
            btn13.Image = "venom.png";
            btn13.HorizontalOptions = LayoutOptions.Center;
            btn13.Clicked += btnDynamicCode;

            var btn14 = new Button();
            btn14.Text = "Class Demo";
            btn14.TextColor = Color.AliceBlue;
            btn14.Image = "venom.png";
            btn14.HorizontalOptions = LayoutOptions.Center;
            btn14.Clicked += btnClassDemo;






            grid.Children.Add(btn01, 0, 0);
            grid.Children.Add(btn02, 1, 0);
            grid.Children.Add(btn03, 0, 1);
            grid.Children.Add(btn04, 1, 1);
            grid.Children.Add(btn05, 0, 2);
            grid.Children.Add(btn06, 1, 2);
            grid.Children.Add(btn07, 0, 3);
            grid.Children.Add(btn08, 1, 3);
            grid.Children.Add(btn09, 0, 4);
            grid.Children.Add(btn10, 1, 4);
            grid.Children.Add(btn11, 0, 5);
            grid.Children.Add(btn12, 1, 5);
            grid.Children.Add(btn13, 0, 6);
            grid.Children.Add(btn14, 1, 6);

            Content = grid;

        }

        async private void btnExplicitDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitDemo());
        }

        async private void btnExplicitCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitCode());
        }

        async private void btnExplicitControlDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitControlDemo());
        }

        async private void btnExplicitControlCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitControlCode());
        }

        async private void btnImplicidDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImplicitDemo());
        }

        async private void btnImplicidCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImplicitCode());
        }

        async private void btnImplicidControlDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImplicitControlDemo());
        }

        async private void btnGlobalDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalDemo());
        }

        async private void btnGlobalCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalCode());
        }

        async private void btnInheritanceCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InheritanceCode());
        }

        async private void btnInheritanceDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InheritanceDemo());
        }

        async private void btnDynamicDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DynamicDemo());
        }

        async private void btnDynamicCode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DynamicCode());
        }

        async private void btnClassDemo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClassDemo());
        }


    }
}
