
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCode : ContentPage
    {
        public EntryCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var entry = new Entry { Text = "This is a read-only Entry" };
            stack.Children.Add(entry);
            Content = stack;

        }
    }
}
