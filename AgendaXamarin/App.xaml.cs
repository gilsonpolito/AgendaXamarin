using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AgendaXamarin
{
    public partial class App : Application
    {
        private static PessoaItemDatabase database;
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new AgendaXamarin.MainPage());
        }

        internal static PessoaItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PessoaItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("PessoaSQLite.db3"));
                }
                return database;
            }
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
    }
}
