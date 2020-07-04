namespace ProgressImplementer
{
    using System.Windows;

    using ProgressImplementer.Models;
    using ProgressImplementer.UI.ViewModels;
    using ProgressImplementer.UI.Windows;

    /// <summary>
    /// Приложение.
    /// </summary>
    public partial class App
    {
        /// <summary>
        /// Запустить основное окно.
        /// </summary>
        private void ShowMainWindow(object sender, StartupEventArgs e)
        {
            var progressOperation = new ProgressOperation();
            var mainWindowVM = new MainWindowVM(progressOperation);
            var mainWindow = new MainWindow { DataContext = mainWindowVM };

            mainWindow.ShowDialog();
        }
    }
}