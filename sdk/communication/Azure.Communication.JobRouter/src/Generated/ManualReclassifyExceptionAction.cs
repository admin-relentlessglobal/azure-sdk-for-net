// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> An action that manually reclassifies a job by providing the queue, priority and worker selectors. </summary>
    public partial class ManualReclassifyExceptionAction : ExceptionAction
    {
        /// <summary> Initializes a new instance of <see cref="ManualReclassifyExceptionAction"/>. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="queueId"> Updated QueueId. </param>
        /// <param name="priority"> Updated Priority. </param>
        /// <param name="workerSelectors"> Updated WorkerSelectors. </param>
        internal ManualReclassifyExceptionAction(string id, ExceptionActionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string queueId, int? priority, IList<RouterWorkerSelector> workerSelectors) : base(id, kind, serializedAdditionalRawData)
        {
            QueueId = queueId;
            Priority = priority;
            WorkerSelectors = workerSelectors;
        }
    }
}
