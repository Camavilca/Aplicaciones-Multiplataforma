using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.view;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          
        }

       async private void ejem01(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StackLayoutDemo());
        }

        async private void ejem02(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AbsoluteLayoutDemo());
        }
        async  private void ejem03(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RelativeLayoutDemo());
        }
        async private void ejem04(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GridDemo());
        }
       async private void ejem05(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ScrollViewDemo());
        }
        async private void ejem06(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GridDemoCode());
        }
        async private void ejem07(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RelativeLayoutDemoCode());
        }
        async private void ejem08(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ScrollViewDemoCode());
        }
    }
}
