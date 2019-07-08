using Android.Content;
using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;
using Sample.Core.Presentation.Navigation;
using Sample.Core.Presentation.ViewModels;
using Sample.Droid.Views;
using Sample.Droid.Views.ResultMappers;
using static Android.Provider.ContactsContract;

namespace Sample.Droid.Navigation
{
    public class AppNavigationService : NavigationService, INavigationService
    {
        public void NavigateToMain(EntryViewModel fromViewModel)
        {
            var splashActivity = NavigationViewProvider.GetActivity<SplashScreenActivity, EntryViewModel>(fromViewModel);

            var intent = new Intent(splashActivity, typeof(MainActivity));
            intent.AddFlags(ActivityFlags.ClearTask | ActivityFlags.ClearTop | ActivityFlags.NewTask);
            splashActivity.StartActivity(intent);
        }

        public void NavigateToContacts(ILifecycleViewModelWithResultHandler fromViewModel)
        {
            var fromView = NavigationViewProvider.Get(fromViewModel);

            var intent = new Intent(Intent.ActionPick);
            intent.SetType(CommonDataKinds.Phone.ContentType);

            NavigateForResult<ContactResultMapper>(fromView, intent);
        }
    }
}
