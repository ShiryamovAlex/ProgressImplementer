namespace ProgressImplementer.UI.Commands
{
    using System;
    using System.Windows.Input;

    using ProgressImplementer.UI.ViewModels;
    using ProgressImplementer.UI.Windows;

    /// <summary>
    /// Команда запуска окна с прогрессом.
    /// </summary>
    public class OpenProgressWindowCommand : ICommand
    {
        /// <summary>
        /// Проверить доступность команды.
        /// </summary>
        /// <param name="parameter">Входной параметр.</param>
        /// <returns>Всегда True.</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <inheritdoc />
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Выполнить запуск окна.
        /// </summary>
        /// <param name="parameter">Входной параметр.</param>
        public void Execute(object parameter)
        {
            var window = new ProgressWindow { DataContext = new ProgressWindowVM(null) };
            window.ShowDialog();
        }
    }
}