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
        // public variables I want to access in the app
        //string TaskPreviewName;
        //string TaskPreviewDetail;
      

		public AddTask ()
		{
			InitializeComponent ();
		}

        public void UpdateTaskPreview ()
        {
            // build the string of other entry cells here
            
        }

        private void OnAddTaskButtonClicked(object sender, EventArgs e)
        {
            // code to test if list is able to add items


            /* 
                various variables in the addtasks page
                
             */
            // test for switch cells
            string switchResult = "";
            if (AllDayBool.On)
            {
                switchResult = "All day event";
                date1Pick.IsVisible = true;
            } else
            {
                switchResult = "Specific Time";
                date1Pick.IsVisible = false;
            }

            DisplayAlert("Alert", "The switch result is " + switchResult, "OK");

            

            // quick replacement for the above debug code
            // date1Pick.IsVisible = !date1Pick.IsVisible;

            //TasksListData.Add(new Logic.quickListWork() { Name = "Button Made Item", Detail = "additional info goes here" });

        }

        // testing a boolean alert result  
        void OnUpdateClicked(object sender, EventArgs e)
        {




            /*  testing out double alert answers
            var answer = await DisplayAlert("Question?", "Choose these two", "Yes", "No");
            // Debug.WriteLine("Answer: " + answer);
            await DisplayAlert("Alert", "The alert result is " + answer, "OK");
            */
        }

        void onNameEntered(object sender, EventArgs e)
        {
            TaskPreview.Text = entryEventName.Text;
        }

        void onDescEntered(object sender, EventArgs e)
        {
            TaskPreview.Detail = entryEventDesc.Text;
        }

    }
}