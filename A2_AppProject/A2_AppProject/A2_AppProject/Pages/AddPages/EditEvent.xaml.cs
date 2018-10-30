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
	public partial class EditEvent : ContentPage
	{
		public EditEvent ()
		{
			InitializeComponent ();
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

        async void OnAddTaskButtonClicked(object sender, EventArgs e)
        {
            var taskItem = (Models.TaskItem)BindingContext;
            await App.Database.SaveItemAsync(taskItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}