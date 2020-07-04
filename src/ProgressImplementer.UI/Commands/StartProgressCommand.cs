namespace ProgressImplementer.UI.Commands
{
    using System.ComponentModel;

    using ProgressImplementer.UI.ViewModels;

    /// <summary>
    /// Команда запуска прогресса.
    /// </summary>
    public class StartProgressCommand : BaseCommand
    {
        /// <summary>
        /// Запустить процесс прогресса.
        /// </summary>
        /// <param name="parameter">Входной параметр команды.</param>
        public override void Execute(object parameter)
        {
            if (!(parameter is ProgressWindowVM progressWindowVM))
                return;

            progressWindowVM.InProgress = true;
            var progressBarVM = progressWindowVM.ProgressBarVM;

            var backgroundWorker = new BackgroundWorker { WorkerSupportsCancellation = true };
            backgroundWorker.DoWork += delegate { progressWindowVM.ProgressOperation.Execute(progressBarVM); };

            backgroundWorker.RunWorkerCompleted += delegate
            {
                progressWindowVM.InProgress = false;
                progressBarVM.Reset();
            };

            backgroundWorker.RunWorkerAsync();
        }
    }
}