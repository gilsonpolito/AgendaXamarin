using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AgendaXamarin
{
    public partial class PagePessoa : ContentPage
    {
        public PagePessoa()
        {
            InitializeComponent();
        }

        private async void OnSavePessoa(object sender, System.EventArgs eventArgs){
            var pessoa = (Pessoa)BindingContext;
            await App.Database.SaveItemAsync(pessoa);
            await Navigation.PopAsync();
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
