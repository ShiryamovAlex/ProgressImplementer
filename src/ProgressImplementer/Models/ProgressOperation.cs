namespace ProgressImplementer.Models
{
    using System;

    using ProgressImplementer.BL;
    using ProgressImplementer.UI.Interfaces;
    using ProgressImplementer.UI.ViewModels;

    /// <summary>
    /// Операция с прогрессом.
    /// </summary>
    public class ProgressOperation : IProgressOperation
    {
        /// <inheritdoc cref="IProgressOperation.Execute"/>
        public void Execute(ProgressBarVM progressBarVM)
        {
            // Получаем случайное число итераций от 100 до 500.
            var random = new Random(DateTime.Now.Millisecond);
            progressBarVM.MaxValue = 100 + random.Next(100, 500);

            for (var iteration = 0; iteration < progressBarVM.MaxValue; iteration++)
            {
                while (progressBarVM.InPause)
                {
                    // Ожидаем отключение паузы.
                }

                if (progressBarVM.IsAborted)
                    return;

                progressBarVM.CurrentValue++;

                // Получаем случайное число миллисекунд от 100 до 1000.
                var timing = random.Next(100, 1000);
                var timeWaiting = new TimeWaiting(timing);
                timeWaiting.Wait();
            }
        }
    }
}