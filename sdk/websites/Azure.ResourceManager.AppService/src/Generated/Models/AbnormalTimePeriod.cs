// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing Abnormal Time Period identified in diagnosis. </summary>
    public partial class AbnormalTimePeriod
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AbnormalTimePeriod"/>. </summary>
        public AbnormalTimePeriod()
        {
            Events = new ChangeTrackingList<DetectorAbnormalTimePeriod>();
            Solutions = new ChangeTrackingList<DiagnosticSolution>();
        }

        /// <summary> Initializes a new instance of <see cref="AbnormalTimePeriod"/>. </summary>
        /// <param name="startOn"> Start time of the downtime. </param>
        /// <param name="endOn"> End time of the downtime. </param>
        /// <param name="events"> List of Possible Cause of downtime. </param>
        /// <param name="solutions"> List of proposed solutions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AbnormalTimePeriod(DateTimeOffset? startOn, DateTimeOffset? endOn, IList<DetectorAbnormalTimePeriod> events, IList<DiagnosticSolution> solutions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartOn = startOn;
            EndOn = endOn;
            Events = events;
            Solutions = solutions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Start time of the downtime. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the downtime. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> List of Possible Cause of downtime. </summary>
        public IList<DetectorAbnormalTimePeriod> Events { get; }
        /// <summary> List of proposed solutions. </summary>
        public IList<DiagnosticSolution> Solutions { get; }
    }
}
