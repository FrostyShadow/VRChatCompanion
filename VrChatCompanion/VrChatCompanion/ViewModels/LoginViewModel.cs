﻿using VrChatCompanion.Views;
using Xamarin.Forms;

namespace VrChatCompanion.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        public Command LoginCommand { get; }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }
}