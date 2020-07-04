namespace ProgressImplementer.UI.Commands
{
    using System;
    using System.ComponentModel;
    using System.Windows.Input;

    using ProgressImplementer.UI.ViewModels;

    /// <summary>
    /// Команда запуска прогресса.
    /// </summary>
    public class StartProgressCommand : ICommand
    {
        /// <inheritdoc cref="ICommand.CanExecute(object)"/>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <inheritdoc cref="ICommand.CanExecuteChanged"/>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Запустить процесс прогресса.
        /// </summary>
        /// <param name="parameter">Входной параметр команды.</param>
        public void Execute(object parameter)
        {
            if (!(parameter is ProgressWindowVM progressWindowVM))
                return;

            progressWindowVM.IsEnabled = false;
            var progressBarVM = progressWindowVM.ProgressBarVM;

            progressBarVM.CurrentValue = 0;

            var backgroundWorker = new BackgroundWorker { WorkerSupportsCancellation = true };
            backgroundWorker.DoWork += delegate { progressWindowVM.ProgressOperation.Execute(progressBarVM); };

            backgroundWorker.RunWorkerCompleted += delegate
            {
                progressWindowVM.IsEnabled = true;
                progressBarVM.CurrentValue = 0;
            };

            backgroundWorker.RunWorkerAsync();
        }
    }
}