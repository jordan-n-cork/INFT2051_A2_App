using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A2_AppProject.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MonthView : ContentPage
	{
		public MonthView ()
		{
			InitializeComponent ();

            // test to add a calendar-like grid





            /* failed grid code
            // monthGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            // monthGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            // monthGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            
            for (int i = 0; i <= 6; i++)
            {
                monthGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }

            for (int i = 0; i <= 3; i++)
            {
                monthGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            */
        }
    }
}