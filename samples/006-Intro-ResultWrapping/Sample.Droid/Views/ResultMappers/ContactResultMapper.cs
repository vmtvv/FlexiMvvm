using Android.App;
using Android.Content;
using FlexiMvvm.Views;
using Sample.Core.Presentation.ViewModels;
using static Android.Provider.ContactsContract;

namespace Sample.Droid.Views.ResultMappers
{
    public class ContactResultMapper : IResultMapper<ContactResult>
    {
        public ContactResult Map(Intent data)
        {
            var result = new ContactResult();

            /*
            Uri contactUri = data.Data;
            string[] projection = { CommonDataKinds.Phone.Number };
            var cursor = ContentResolver.Query(contactUri, projection, null, null, null);

            // If the cursor returned is valid, get the phone number
            if (cursor != null && cursor.MoveToFirst())
            {
                int numberIndex = cursor.GetColumnIndex(CommonDataKinds.Phone.Number);
                string number = cursor.GetString(numberIndex);

                result.ContactNumber = number;
            }*/

            return result;
        }
    }
}
