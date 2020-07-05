namespace ProgressImplementer.Tests.UI.Forms
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ProgressImplementer.UI.Forms;

    [TestClass]
    public class ProgressFormTests
    {
        /// <summary>
        /// Тест окна для просмотра окна без запуска приложения.
        /// Игнор указан, чтобы тест не завис при запуске.
        /// </summary>
        [TestMethod]
        [Ignore("Тест с окном")]
        public void ShowFormTest()
        {
            var form = new ProgressForm();
            form.ShowDialog();
        }
    }
}