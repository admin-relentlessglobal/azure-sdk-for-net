// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Router Communication Error. </summary>
    internal partial class AcsRouterCommunicationError
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterCommunicationError"/>. </summary>
        internal AcsRouterCommunicationError()
        {
            Details = new ChangeTrackingList<AcsRouterCommunicationError>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterCommunicationError"/>. </summary>
        /// <param name="code"> Router Communication Error Code. </param>
        /// <param name="message"> Router Communication Error Message. </param>
        /// <param name="target"> Router Communication Error Target. </param>
        /// <param name="innererror"> Router Communication Inner Error. </param>
        /// <param name="details"> List of Router Communication Errors. </param>
        internal AcsRouterCommunicationError(string code, string message, string target, AcsRouterCommunicationError innererror, IReadOnlyList<AcsRouterCommunicationError> details)
        {
            Code = code;
            Message = message;
            Target = target;
            Innererror = innererror;
            Details = details;
        }

        /// <summary> Router Communication Error Code. </summary>
        public string Code { get; }
        /// <summary> Router Communication Error Message. </summary>
        public string Message { get; }
        /// <summary> Router Communication Error Target. </summary>
        public string Target { get; }
        /// <summary> Router Communication Inner Error. </summary>
        public AcsRouterCommunicationError Innererror { get; }
        /// <summary> List of Router Communication Errors. </summary>
        public IReadOnlyList<AcsRouterCommunicationError> Details { get; }
    }
}
