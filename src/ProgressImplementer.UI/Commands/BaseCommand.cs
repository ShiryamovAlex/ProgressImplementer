namespace ProgressImplementer.UI.Commands
{
    using System;
    using System.Windows.Input;

    /// <summary>
    /// Базовая команда.
    /// </summary>
    public abstract class BaseCommand : ICommand
    {
        /// <summary>
        /// Проверка доступности команды. По умолчанию всегда true.
        /// </summary>
        /// <param name="parameter">Входной параметр.</param>
        /// <returns>True, если команда доступна.</returns>
        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        /// <inheritdoc cref="ICommand.CanExecuteChanged"/>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Выполнить команду.
        /// </summary>
        /// <param name="parameter">Входной параметр.</param>
        public abstract void Execute(object parameter);
    }
}