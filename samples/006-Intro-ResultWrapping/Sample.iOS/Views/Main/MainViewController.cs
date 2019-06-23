using FlexiMvvm.Bindings;
using FlexiMvvm.Views;
using Sample.Core.Presentation.ViewModels;

namespace Sample.iOS.Views.Main
{
    public class MainViewController : BindableViewController<MainViewModel>
    {
        public new MainView View
        {
            get => (MainView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new MainView();
        }
    }
}
