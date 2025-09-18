using Grocery.App.ViewModels;

namespace Grocery.App
{
    internal class LoginView : Page
    {
        private LoginViewModel viewModel;

        public LoginView(LoginViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
    }
}