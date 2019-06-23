﻿using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using FlexiMvvm;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;
using Sample.Core.Presentation.ViewModels;

namespace Sample.Droid.Views
{
    [Activity(Theme = "@style/AppTheme.NoActionBar")]
    public class MainActivity : BindableAppCompatActivity<MainViewModel>
    {
        private TextView _contactNumberTextView;
        private Button _pickContactButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            SetSupportActionBar(FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar));

            _contactNumberTextView = FindViewById<TextView>(Resource.Id.main_contact_number_header_text);
            _pickContactButton = FindViewById<Button>(Resource.Id.main_pick_contact_button);
        }

        public override void Bind(BindingSet<MainViewModel> bindingSet)
        {
            base.Bind(bindingSet);

            bindingSet.Bind(_contactNumberTextView)
                .For(v => v.TextBinding())
                .To(vm => vm.ContactNumber);

            bindingSet.Bind(_pickContactButton)
                .For(v => v.ClickBinding())
                .To(vm => vm.PickContactCommand);
        }
    }
}
