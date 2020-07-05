namespace ProgressImplementer.Tests.UI.Windows
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ProgressImplementer.Tests.UI.Mocks;
    using ProgressImplementer.UI.ViewModels;
    using ProgressImplementer.UI.Windows;

    [TestClass]
    public class ProgressWindowTests
    {
        /// <summary>
        /// Тест окна для просмотра окна без запуска приложения.
        /// Игнор указан, чтобы тест не завис при запуске.
        /// </summary>
        [TestMethod]
        [Ignore("Тест с окном")]
        public void ShowWindowTest()
        {
            var vm = new ProgressWindowVM(new ProgressOperationMock());
            var window = new ProgressWindow { DataContext = vm };
            window.ShowDialog();
        }
    }
}