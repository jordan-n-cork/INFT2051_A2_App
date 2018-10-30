using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace A2_AppProject
{
    public partial class App : Application
    {
        static Data.TaskDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static Data.TaskDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new Data.TaskDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TasksSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }

    }


}
