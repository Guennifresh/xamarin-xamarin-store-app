using System;
using System.Threading.Tasks;

namespace Shared.Helpers
{
    public static class TaskExtensions
    {
        /// <summary>
        /// Not the best of practices, but better than swalling the exceptions.
        /// Its usage flags the need for refactoring.
        /// </summary>
        /// <param name="task">The task.</param>
        public static void FireAndForget(this Task task)
        {
            task.ContinueWith(t => Console.WriteLine(t.Exception), TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}
