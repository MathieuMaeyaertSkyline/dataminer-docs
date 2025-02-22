﻿namespace Skyline.DataMiner.Library.Common
{
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;

    /// <summary>
    /// The exception that is thrown when an action is performed on a DataMiner Agent that was not found.
    /// </summary>
    [Serializable]
    public class AgentNotFoundException : DmsException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNotFoundException"/> class.
        /// </summary>
        public AgentNotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNotFoundException"/> class with a specified DataMiner Agent ID.
        /// </summary>
        /// <param name="id">The ID of the DataMiner Agent that was not found.</param>
        public AgentNotFoundException(int id)
        : base(String.Format(CultureInfo.InvariantCulture, "The agent with ID '{0}' was not found.", id))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNotFoundException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public AgentNotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNotFoundException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public AgentNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNotFoundException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The serialization info.</param>
        /// <param name="context">The streaming context.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="info"/> parameter is <see langword="null" />.</exception>
        /// <exception cref="SerializationException">The class name is <see langword="null" /> or HResult is zero (0).</exception>
        /// <remarks>This constructor is called during deserialization to reconstitute the exception object transmitted over a stream.</remarks>
        protected AgentNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}