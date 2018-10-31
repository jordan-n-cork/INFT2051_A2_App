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

        public HabitsView()
        {
            InitializeComponent();

            
        }

        private void OnAddItemButtonClicked(object sender, EventArgs e)
        {
            // original add code 
            // code to test if list is able to add items
            // HabitsListData.Add(new Logic.quickListWork() { Name = "Button Made Item", Detail = "additional info goes here" });

        }
    }
}