namespace ProgressImplementer.UI.Windows
{
    using ProgressImplementer.UI.ViewModels;

    /// <summary>
    /// Основное окно программы.
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// Основное окно программы.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
        }
    }
}