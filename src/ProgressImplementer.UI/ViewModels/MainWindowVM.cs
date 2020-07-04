namespace ProgressImplementer.UI.ViewModels
{
    using ProgressImplementer.UI.Commands;

    /// <summary>
    /// Вью-модель основного окна.
    /// </summary>
    public class MainWindowVM
    {
        /// <summary>
        /// Вью-модель основного окна.
        /// </summary>
        public MainWindowVM()
        {
            OpenProgressWindowCommand = new OpenProgressWindowCommand();
        }

        /// <summary>
        /// Команда запуска окна с прогрессом.
        /// </summary>
        public OpenProgressWindowCommand OpenProgressWindowCommand { get; }
    }
}
