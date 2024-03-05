// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.CallingServer
{
    /// <summary> The CommunicationError. </summary>
    internal partial class CommunicationError
    {
        /// <summary> Initializes a new instance of <see cref="CommunicationError"/>. </summary>
        internal CommunicationError()
        {
            Details = new ChangeTrackingList<CommunicationError>();
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationError"/>. </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="target"></param>
        /// <param name="details"></param>
        /// <param name="innererror"></param>
        internal CommunicationError(string code, string message, string target, IReadOnlyList<CommunicationError> details, CommunicationError innererror)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
        }

        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
        /// <summary> Gets the target. </summary>
        public string Target { get; }
        /// <summary> Gets the details. </summary>
        public IReadOnlyList<CommunicationError> Details { get; }
        /// <summary> Gets the innererror. </summary>
        public CommunicationError Innererror { get; }
    }
}
