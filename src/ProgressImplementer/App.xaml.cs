namespace ProgressImplementer
{
    using System.Windows;

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
            var mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}