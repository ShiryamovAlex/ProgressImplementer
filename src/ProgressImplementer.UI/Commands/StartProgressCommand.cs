namespace ProgressImplementer.UI.Commands
{
    using System.Threading.Tasks;

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
            if (parameter is ProgressWindowVM progressWindowVM)
                ExecuteAsync(progressWindowVM);
        }

        /// <summary>
        /// Асинхронный запуск процесса.
        /// </summary>
        /// <param name="progressWindowVM">Вью-модель окна с прогрессом.</param>
        public async void ExecuteAsync(ProgressWindowVM progressWindowVM)
        {
            progressWindowVM.InProgress = true;
            var progressBarVM = progressWindowVM.ProgressBarVM;

            await Task.Run(() => progressWindowVM.ProgressOperation.Execute(progressBarVM));

            progressWindowVM.InProgress = false;
            progressBarVM.Reset();
        }
    }
}