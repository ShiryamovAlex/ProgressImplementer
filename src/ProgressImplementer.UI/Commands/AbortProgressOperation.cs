namespace ProgressImplementer.UI.Commands
{
    using ProgressImplementer.UI.ViewModels;

    /// <summary>
    /// Команда прерывания операции.
    /// </summary>
    public class AbortProgressOperation : BaseCommand
    {
        /// <inheritdoc cref="BaseCommand.Execute"/>
        public override void Execute(object parameter)
        {
            if (!(parameter is ProgressWindowVM progressWindowVM))
                return;

            if (progressWindowVM.InProgress)
                progressWindowVM.ProgressBarVM.IsAborted = true;
        }
    }
}