
namespace CS2REACTJS.Helpers.UI
{
    public class IsReadyViewModel: NotifyPropertyChangedViewModel
    {
        public IsReadyNotificationService IsReady;
        public IsReadyViewModel()
        {
            IsReady = new IsReadyNotificationService();
        }
    }
}
