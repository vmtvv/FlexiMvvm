using Android.App;
using Android.Content;
using Android.Net;
using Android.Support.V4.App;
using FlexiMvvm.Views;
using Sample.Core.Presentation.ViewModels;
using static Android.Provider.ContactsContract;

namespace Sample.Droid.Views.ResultMappers
{
    public class ContactResultMapper : IResultMapper<ContactResult>
    {
        public ContactResult Map(FragmentActivity activity, Result resultCode, Intent data)
        {
            var result = new ContactResult();

            if (resultCode == Result.Ok)
            {
                Uri contactUri = data.Data;

                var numberColumnKey = CommonDataKinds.Phone.Number;

                string[] projection = { numberColumnKey };
                var cursor = activity.ContentResolver.Query(contactUri, projection, null, null, null);

                // If the cursor returned is valid, get the phone number
                if (cursor != null && cursor.MoveToFirst())
                {
                    int numberIndex = cursor.GetColumnIndex(numberColumnKey);
                    string number = cursor.GetString(numberIndex);

                    result.PhoneNumber = number;
                }
            }

            return result;
        }
    }
}
