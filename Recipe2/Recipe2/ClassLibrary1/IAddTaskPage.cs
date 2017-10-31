namespace PageObject.Interfaces
{
    /// <summary>
    /// The Add Task interface.
    /// </summary>
    public interface IAddTaskPage
    {
        /// <summary>
        /// Gets or sets the task title.
        /// </summary>
        string TaskTitle { get; set; }

        /// <summary>
        /// Gets or sets the content of the task.
        /// </summary>
        string TaskContent { get; set; }

        /// <summary>
        /// Sets the color of the task.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetTaskColor(string color);

        /// <summary>
        /// Creates the task.
        /// </summary>
        void CreateTask();
    }
}
