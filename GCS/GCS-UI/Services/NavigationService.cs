using System.Windows.Controls;

namespace GCS_UI.Core
{
    public class NavigationService
    {
        private readonly Frame _frame;

        public NavigationService(Frame frame)
        {
            _frame = frame;
        }

        public void Navigate(Page page)
        {
            _frame.NavigationService.Navigate(page);
        }
    }
}
