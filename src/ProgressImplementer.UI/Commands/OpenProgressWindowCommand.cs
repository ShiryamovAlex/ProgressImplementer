namespace ProgressImplementer.UI.Commands
{
    using ProgressImplementer.UI.Interfaces;
    using ProgressImplementer.UI.ViewModels;
    using ProgressImplementer.UI.Windows;

    /// <summary>
    /// Команда запуска окна с прогрессом.
    /// </summary>
    public class OpenProgressWindowCommand : BaseCommand
    {
        /// <summary>
        /// Операция с прогрессом.
        /// </summary>
        private readonly IProgressOperation _progressOperation;

        /// <summary>
        /// Команда запуска окна с прогрессом.
        /// </summary>
        /// <param name="progressOperation">Операция с прогрессом.</param>
        public OpenProgressWindowCommand(IProgressOperation progressOperation)
        {
            _progressOperation = progressOperation;
        }

        /// <summary>
        /// Выполнить запуск окна.
        /// </summary>
        /// <param name="parameter">Входной параметр.</param>
        public override void Execute(object parameter)
        {
            var progressWindowVM = new ProgressWindowVM(_progressOperation);
            var progressWindow = new ProgressWindow { DataContext = progressWindowVM };
            progressWindow.ShowDialog();
        }
    }
}