// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for CheckIPAddressAvailability API service call. </summary>
    public partial class IPAddressAvailabilityResult
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

        /// <summary> Initializes a new instance of <see cref="IPAddressAvailabilityResult"/>. </summary>
        internal IPAddressAvailabilityResult()
        {
            AvailableIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IPAddressAvailabilityResult"/>. </summary>
        /// <param name="available"> Private IP address availability. </param>
        /// <param name="availableIPAddresses"> Contains other available private IP addresses if the asked for address is taken. </param>
        /// <param name="isPlatformReserved"> Private IP address platform reserved. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IPAddressAvailabilityResult(bool? available, IReadOnlyList<string> availableIPAddresses, bool? isPlatformReserved, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Available = available;
            AvailableIPAddresses = availableIPAddresses;
            IsPlatformReserved = isPlatformReserved;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Private IP address availability. </summary>
        public bool? Available { get; }
        /// <summary> Contains other available private IP addresses if the asked for address is taken. </summary>
        public IReadOnlyList<string> AvailableIPAddresses { get; }
        /// <summary> Private IP address platform reserved. </summary>
        public bool? IsPlatformReserved { get; }
    }
}
