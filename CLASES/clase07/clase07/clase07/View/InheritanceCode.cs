
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace clase07.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InheritanceCode : ContentPage
    {
        public InheritanceCode()
        {
            var baseStyle = new Style(typeof(BoxView))
            {
                Setters = {
                new Setter {
                       Property = BoxView.HorizontalOptionsProperty, Value = LayoutOptions.Center    }
                }
            };

            var labelStyle = new Style(typeof(Label))
            {
                BasedOn = baseStyle,
                Setters = {
                    new Setter { Property = Label.TextColorProperty, Value = Color.Teal    }
                }
            };

            var buttonStyle = new Style(typeof(Button))
            {
                BasedOn = baseStyle,
                Setters = {
                    new Setter { Property = Button.BorderColorProperty, Value =    Color.Lime }
                }
            };

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "These labels", Style = labelStyle },
                    new Button { Text = "So is the button", Style = buttonStyle }
                }
            };
        }
    }
}