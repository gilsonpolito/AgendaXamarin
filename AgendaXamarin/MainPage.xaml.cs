using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing(){
            base.OnAppearing();
            lvPessoas.ItemsSource = await App.Database.GetItemsAsync();
        }

        private async void OnButton_Clicked(object sender, EventArgs e){
            await Navigation.PushAsync(new PagePessoa
            {
                BindingContext = new Pessoa()
            });
        }

        void onItemSelected(object sender, SelectedItemChangedEventArgs args){
            if (args != null){
                Navigation.PushAsync(new PagePessoa
                {
                    BindingContext = args.SelectedItem as Pessoa
                });
            }
        }
    }
}
