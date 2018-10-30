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
        //string TaskLocation;
        //string TaskDescription;
      

		public AddTask ()
		{
			InitializeComponent ();

            
        }

        public void UpdateTaskPreview ()
        {
            // the aim of this function is to be called by the other cell entries to build a 
            // detailed combined 'detail' section of the task preview.

            // build the string of other entry cells here
            
        }

        private void OnAddTaskButtonClicked(object sender, EventArgs e)
        {
            // code to test if list is able to add items


            /* 
                various variables in the addtasks page
                
             */

            // quick replacement for the above debug code
            // date1Pick.IsVisible = !date1Pick.IsVisible;

            //TasksListData.Add(new Logic.quickListWork() { Name = "Button Made Item", Detail = "additional info goes here" });
            
            /*  testing out double alert answers
            var answer = await DisplayAlert("Question?", "Choose these two", "Yes", "No");
            // Debug.WriteLine("Answer: " + answer);
            await DisplayAlert("Alert", "The alert result is " + answer, "OK");
            */
        }

        void onNameEntered(object sender, EventArgs e)
        {
            TaskPreviewTitle.Text = entryEventName.Text;
            entryEventDesc.Focus();
            
        }

        void onDescEntered(object sender, EventArgs e)
        {
            TaskPreviewDetail.Text = entryEventDesc.Text;
        }

        public void AllDayBool_OnChanged(object sender, ToggledEventArgs e)
        {
            datePick1Cell.IsVisible = !datePick1Cell.IsVisible;
            /*
            if (AllDayBool.On)
            {
                datePick2.IsVisible = false;
            }
            else
            {
                datePick2.IsVisible = true;
            }
            */
        }
        /* 
        private void MultiDayBool_OnChanged(object sender, ToggledEventArgs e)
        {
            datePick2Cell.IsVisible = !datePick2Cell.IsVisible;
        }
        */
    }
}