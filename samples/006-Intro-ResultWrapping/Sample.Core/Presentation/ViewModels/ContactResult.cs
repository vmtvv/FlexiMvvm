using FlexiMvvm.ViewModels;

namespace Sample.Core.Presentation.ViewModels
{
    public class ContactResult : Result
    {
        public string ContactNumber
        {
            get => Bundle.GetString();
            set => Bundle.SetString(value);
        }
    }
}
