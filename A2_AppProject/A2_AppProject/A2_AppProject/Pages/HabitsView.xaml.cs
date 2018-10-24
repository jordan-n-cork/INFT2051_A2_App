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
    public partial class HabitsView : ContentPage
    {

        ObservableCollection<Logic.quickListWork> HabitsListData = new ObservableCollection<Logic.quickListWork>();

        public HabitsView()
        {
            InitializeComponent();

            // just a quick example list build
            HabitsList.ItemsSource = HabitsListData;

            String itemName = "";
            for (int i = 0; i <= 3; i++)
            {
                itemName = "Habit " + (i + 1);
                HabitsListData.Add(new Logic.quickListWork() { Name = itemName, Detail = "info for " + itemName + " goes here" });

            }
        }

        private void OnAddItemButtonClicked(object sender, EventArgs e)
        {
            // code to test if list is able to add items

            HabitsListData.Add(new Logic.quickListWork() { Name = "Button Made Item", Detail = "additional info goes here" });

        }
    }
}