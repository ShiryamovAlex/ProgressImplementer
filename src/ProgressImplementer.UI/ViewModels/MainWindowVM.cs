namespace ProgressImplementer.UI.ViewModels
{
    using ProgressImplementer.UI.Commands;
    using ProgressImplementer.UI.Interfaces;

    /// <summary>
    /// Вью-модель основного окна.
    /// </summary>
    public class MainWindowVM
    {
        /// <summary>
        /// Вью-модель основного окна.
        /// </summary>
        /// <param name="progressOperation">Операция с прогрессом.</param>
        public MainWindowVM(IProgressOperation progressOperation)
        {
            OpenProgressWindowCommand = new OpenProgressWindowCommand(progressOperation);
        }

        /// <summary>
        /// Команда запуска окна с прогрессом.
        /// </summary>
        public OpenProgressWindowCommand OpenProgressWindowCommand { get; }
    }
}
