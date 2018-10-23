using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// needed for ObservableCollection
using System.Collections.ObjectModel;


namespace A2_AppProject.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TodayView : ContentPage
	{
        // this is for the listview, it will continually update the Listview property with array data
        ObservableCollection<Logic.quickListWork> QuickList = new ObservableCollection<Logic.quickListWork>();

        public TodayView ()
		{
			InitializeComponent ();

            // just a quick list build
            // testing out observable collection
            TodayViewList.ItemsSource = QuickList;

            String timeSlot = "";
            int timeCheck;
            for (int i = 0; i <= 12; i++)
            {
                timeCheck = i + 6;
                if ( timeCheck < 13) {
                    timeSlot = timeCheck + "am";
                } else
                {
                    timeSlot = timeCheck - 12 + "pm";
                }
                
                QuickList.Add(new Logic.quickListWork() { Name = timeSlot, Detail = "info for " + timeSlot + " goes here" });
            }

            /*  The other ways of adding items to the list
            ObservableCollection<Logic.quickListWork> QuickList = new ObservableCollection<Logic.quickListWork>();
            TodayViewList.ItemsSource = QuickList;
            QuickList.Add(new Logic.quickListWork() { Name = "Item 1", Detail = "additional info goes here" });

            TodayViewList.ItemsSource = new List< Logic.quickListWork >() {
            new Logic.quickListWork() { Name = "Item 1", Detail = "additional info goes here"},
              
            */
        }

        async void OnMonthViewButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.MonthView());
        }

        /* for when testing items from a button
        private void OnAddItemButtonClicked(object sender, EventArgs e)
        {
            // code to test if list is able to add items

            QuickList.Add(new Logic.quickListWork() { Name = "Button Made Item", Detail = "additional info goes here" });

        }
        */
        
    }
}