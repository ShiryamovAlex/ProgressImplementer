namespace ProgressImplementer.UI.Commands
{
    using ProgressImplementer.UI.ViewModels;
    using ProgressImplementer.UI.Windows;

    /// <summary>
    /// Команда запуска окна с прогрессом.
    /// </summary>
    public class OpenProgressWindowCommand : BaseCommand
    {
        /// <summary>
        /// Выполнить запуск окна.
        /// </summary>
        /// <param name="parameter">Входной параметр.</param>
        public override void Execute(object parameter)
        {
            var window = new ProgressWindow { DataContext = new ProgressWindowVM(null) };
            window.ShowDialog();
        }
    }
}