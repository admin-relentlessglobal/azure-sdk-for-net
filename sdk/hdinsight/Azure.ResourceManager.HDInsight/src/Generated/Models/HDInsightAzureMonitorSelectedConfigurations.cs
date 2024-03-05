// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The selected configurations for azure monitor. </summary>
    public partial class HDInsightAzureMonitorSelectedConfigurations
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

        /// <summary> Initializes a new instance of <see cref="HDInsightAzureMonitorSelectedConfigurations"/>. </summary>
        public HDInsightAzureMonitorSelectedConfigurations()
        {
            GlobalConfigurations = new ChangeTrackingDictionary<string, string>();
            TableList = new ChangeTrackingList<HDInsightAzureMonitorTableConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightAzureMonitorSelectedConfigurations"/>. </summary>
        /// <param name="configurationVersion"> The configuration version. </param>
        /// <param name="globalConfigurations"> The global configurations of selected configurations. </param>
        /// <param name="tableList"> The table list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightAzureMonitorSelectedConfigurations(string configurationVersion, IDictionary<string, string> globalConfigurations, IList<HDInsightAzureMonitorTableConfiguration> tableList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConfigurationVersion = configurationVersion;
            GlobalConfigurations = globalConfigurations;
            TableList = tableList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration version. </summary>
        public string ConfigurationVersion { get; set; }
        /// <summary> The global configurations of selected configurations. </summary>
        public IDictionary<string, string> GlobalConfigurations { get; }
        /// <summary> The table list. </summary>
        public IList<HDInsightAzureMonitorTableConfiguration> TableList { get; }
    }
}
