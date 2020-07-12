using delta.Core.ViewModel;
using System.Windows.Controls;

namespace delta
{
    /// <summary>
    /// Interaction logic for BottomMenuControl.xaml
    /// </summary>
    public partial class BottomMenuControl : UserControl
    {
        public BottomMenuControl()
        {
            InitializeComponent();

            DataContext = new BottomMenuViewModel();
        }
    }
}
