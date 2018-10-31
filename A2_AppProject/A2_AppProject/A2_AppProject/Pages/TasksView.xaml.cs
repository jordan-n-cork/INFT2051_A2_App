using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


// needed for ObservableCollection
using System.Collections.ObjectModel;
using SQLite;

namespace A2_AppProject.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TasksView : ContentPage
	{

        //ObservableCollection<Models.TaskItem> TasksListData = new ObservableCollection<Models.TaskItem>();

        public TasksView ()
		{
			InitializeComponent ();

            /*
            // just a quick list build
            TasksList.ItemsSource = TasksListData;

            String itemName = "";
            for (int i = 0; i <= 3; i++)
            {
                itemName = "Task " + (i + 1);
                TasksListData.Add(new Models.TaskItem() { Name = itemName, Detail = "info for " + itemName + " goes here" });

            }
            */

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;

            // this requests the database as detailed in app.xaml.cs
            // will need to change the config to Jordan's classes
            TasksListData.ItemsSource = await App.Database.GetItemsAsync();
        }

       

        async void OnAddTaskButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.AddPages.EditEvent()
            {
                BindingContext = new Models.TaskItem()
            });
        }


        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Pages.AddPages.EditEvent
                {
                    BindingContext = e.SelectedItem as Models.TaskItem
                });
            }
        }
    }
}