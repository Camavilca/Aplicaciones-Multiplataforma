using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace clase07.View
{
    public class GlobalCode : ContentPage
    {
        public GlobalCode()
        {
            Content = new StackLayout
            {
                Children = {
                    new Button { Text = "These buttons", Style = (Style)Application.Current.Resources ["buttonStyleCode"] },
                    new Button { Text = "are demonstrating", Style = (Style)Application.Current.Resources ["buttonStyleCode"] },
                    new Button { Text = "application styles", Style = (Style)Application.Current.Resources ["buttonStyleCode"]                }
                }
            };

        }
    }
}