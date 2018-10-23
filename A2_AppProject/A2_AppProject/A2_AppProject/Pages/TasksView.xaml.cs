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
	public partial class TasksView : ContentPage
	{

        ObservableCollection<Logic.quickListWork> TasksListData = new ObservableCollection<Logic.quickListWork>();

        public TasksView ()
		{
			InitializeComponent ();

            // just a quick list build
            TasksList.ItemsSource = TasksListData;

            String itemName = "";
            for (int i = 0; i <= 3; i++)
            {
                itemName = "Task " + (i + 1);
                TasksListData.Add(new Logic.quickListWork() { Name = itemName, Detail = "info for " + itemName + " goes here" });

            }

        }

        private void OnAddItemButtonClicked(object sender, EventArgs e)
        {
            // code to test if list is able to add items

            TasksListData.Add(new Logic.quickListWork() { Name = "Button Made Item", Detail = "additional info goes here" });

        }
    }
}