using FlexiMvvm.Commands;
using FlexiMvvm.ViewModels;
using Sample.Core.Presentation.Navigation;

namespace Sample.Core.Presentation.ViewModels
{
    public class MainViewModel : LifecycleViewModel, ILifecycleViewModelWithResultHandler
    {
        private readonly INavigationService _navigationService;
        private string _contactNumber;
        private string _contactName;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public Command PickContactCommand
        {
            get => CommandProvider.Get(PickContact);
        }

        public string ContactName
        {
            get => _contactName;
            set => SetValue(ref _contactName, value);
        }

        public string PhoneNumber
        {
            get => _contactNumber;
            set => SetValue(ref _contactNumber, value);
        }

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
                        PhoneNumber = contactResult.PhoneNumber;
                    }

                    break;
            }
        }
    }
}
