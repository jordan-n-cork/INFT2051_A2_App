using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A2_AppProject.Pages.AddPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddTask : ContentPage
	{
		public AddTask ()
		{
			InitializeComponent ();
		}

        private void OnAddTaskButtonClicked(object sender, EventArgs e)
        {
            // code to test if list is able to add items

            // test for switch cells
            string switchResult = "";
            if (testSwitch.On)
            {
                switchResult = "on";
                
            } else
            {
                switchResult = "off";
            }

            DisplayAlert("Alert", "The switch result is " + switchResult, "OK");
 
            //TasksListData.Add(new Logic.quickListWork() { Name = "Button Made Item", Detail = "additional info goes here" });
            
        }

            // testing a boolean alert result  
        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Question?", "Choose these two", "Yes", "No");
            // Debug.WriteLine("Answer: " + answer);
            await DisplayAlert("Alert", "The alert result is " + answer, "OK");
        }

    }
}