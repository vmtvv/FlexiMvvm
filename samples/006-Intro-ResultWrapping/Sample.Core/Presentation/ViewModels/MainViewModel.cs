using FlexiMvvm.Commands;
using FlexiMvvm.ViewModels;
using Sample.Core.Presentation.Navigation;

namespace Sample.Core.Presentation.ViewModels
{
    public class MainViewModel : LifecycleViewModel, ILifecycleViewModelWithResultHandler
    {
        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public Command PickContactCommand
        {
            get => CommandProvider.Get(PickContact);
        }

        public string ContactNumber { get; private set; }

        private void PickContact()
        {
            _navigationService.NavigateToContacts(this);
        }

        public void HandleResult(ResultCode resultCode, Result result)
        {
            switch (result)
            {
                case ContactResult contactResult:
                    if (resultCode == ResultCode.Ok)
                    {
                        ContactNumber = contactResult.ContactNumber;
                    }

                    break;
            }
        }
    }
}
