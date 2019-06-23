using FlexiMvvm.ViewModels;
using Sample.Core.Presentation.ViewModels;

namespace Sample.Core.Presentation.Navigation
{
    public interface INavigationService
    {
        void NavigateToContacts(ILifecycleViewModelWithResultHandler fromViewModel);

        void NavigateToMain(EntryViewModel fromViewModel);
    }
}
