using FlexiMvvm.ViewModels;

namespace Sample.Core.Presentation.ViewModels
{
    public class ContactResult : Result
    {
        public string PhoneNumber
        {
            get => Bundle.GetString();
            set => Bundle.SetString(value);
        }
    }
}
