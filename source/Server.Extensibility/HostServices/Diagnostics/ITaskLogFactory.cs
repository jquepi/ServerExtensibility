using System;
using Octopus.Diagnostics;
using Octopus.Server.MessageContracts.Diagnostics;

namespace Octopus.Server.Extensibility.HostServices.Diagnostics
{
    public interface ITaskLogFactory
    {
        ITaskLog Get(CorrelationId correlationId);
        ITaskLog Create(CorrelationId correlationId, string[]? sensitiveValues = null);

        /// <summary>
        /// Opens a new child block for logging.
        /// </summary>
        /// <param name="taskLog">Parent task log</param>
        /// <param name="messageText">Title of the new block.</param>
        /// <returns>A child <see cref="ITaskLog" />.</returns>
        ITaskLog CreateBlock(ITaskLog taskLog, string messageText);

        /// <summary>
        /// Opens a new child block for logging.
        /// </summary>
        /// <param name="taskLog">Parent task log</param>
        /// <param name="messageFormat">Format string for the message.</param>
        /// <param name="args">Arguments for the format string.</param>
        /// <returns>A child <see cref="ITaskLog" />.</returns>
        [StringFormatMethod("messageFormat")]
        ITaskLog CreateBlock(ITaskLog taskLog, string messageFormat, params object[] args);

        /// <summary>
        /// Plans a new block of output that will be used in the future for grouping child blocks for logging.
        /// </summary>
        /// <param name="taskLog">Parent task log</param>
        /// <param name="messageText">Title of the new block.</param>
        /// <returns>A child <see cref="ITaskLog" />.</returns>
        ITaskLog PlanGroupedBlock(ITaskLog taskLog, string messageText);

        /// <summary>
        /// Plans a new block of log output that will be used in the future. This is typically used for high-level log
        /// information, such as the steps in a big deployment process.
        /// </summary>
        /// <param name="taskLog">Parent task log</param>
        /// <param name="messageText">Title of the new block.</param>
        /// <returns>A child <see cref="ITaskLog" />.</returns>
        ITaskLog PlanFutureBlock(ITaskLog taskLog, string messageText);

        /// <summary>
        /// Plans a new block of log output that will be used in the future. This is typically used for high-level log
        /// information, such as the steps in a big deployment process.
        /// </summary>
        /// <param name="taskLog">Parent task log</param>
        /// <param name="messageFormat">Format string for the message.</param>
        /// <param name="args">Arguments for the format string.</param>
        /// <returns>A child <see cref="ITaskLog" />.</returns>
        [StringFormatMethod("messageFormat")]
        ITaskLog PlanFutureBlock(ITaskLog taskLog, string messageFormat, params object[] args);

        void Finish(ITaskLog taskLog);
    }
}