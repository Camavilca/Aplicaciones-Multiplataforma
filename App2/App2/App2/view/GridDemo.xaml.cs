using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridDemo : ContentPage
	{
		public GridDemo ()
		{
            InitializeComponent();
            //var layout = new StackLayout();
            //var grid = new Grid();
            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(200) });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });

            //layout.Children.Add(grid);


            //Content = layout;
        }
    }
}