using Avalonia.Controls;

namespace ChronoShift.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public Control Content { get; set; } = new TextBox() { Text = "TEST" };
    }
}
