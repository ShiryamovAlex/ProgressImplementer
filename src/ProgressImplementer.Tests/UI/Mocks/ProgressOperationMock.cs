namespace ProgressImplementer.Tests.UI.Mocks
{
    using System.Threading;

    using ProgressImplementer.UI.Interfaces;
    using ProgressImplementer.UI.ViewModels;

    /// <summary>
    /// Фиктивная операция с прогрессом.
    /// </summary>
    internal class ProgressOperationMock : IProgressOperation
    {
        /// <inheritdoc cref="IProgressOperation.Execute(ProgressBarVM)"/>
        public void Execute(ProgressBarVM progressBarVM)
        {
            for (var iteration = 0; iteration < progressBarVM.MaxValue; iteration++)
            {
                while (progressBarVM.InPause)
                {
                    // Ожидаем отключение паузы.
                }

                if (progressBarVM.IsAborted)
                    return;

                progressBarVM.CurrentValue++;
                Thread.Sleep(100);
            }
        }
    }
}