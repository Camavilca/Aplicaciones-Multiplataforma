using Clase03.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clase03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Title = "Access";

        }

        private async void ejemplo01(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StackLayoutDemo());
        }

        private async void ejemplo02(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AbsoluteLayoutDemo());
        }
        private async void ejemplo03(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RelativeLayoutDemo());
        }
        private async void ejemplo04(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GridDemo());
        }
        private async void ejemplo05(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ScrollViewDemo());
        }  
    }
}
