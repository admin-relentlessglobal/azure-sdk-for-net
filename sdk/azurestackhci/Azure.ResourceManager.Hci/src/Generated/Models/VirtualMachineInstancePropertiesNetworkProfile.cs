// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Hci;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> NetworkProfile - describes the network configuration the virtual machine instance. </summary>
    internal partial class VirtualMachineInstancePropertiesNetworkProfile
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineInstancePropertiesNetworkProfile"/>. </summary>
        public VirtualMachineInstancePropertiesNetworkProfile()
        {
            NetworkInterfaces = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineInstancePropertiesNetworkProfile"/>. </summary>
        /// <param name="networkInterfaces"> NetworkInterfaces - list of network interfaces to be attached to the virtual machine instance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineInstancePropertiesNetworkProfile(IList<WritableSubResource> networkInterfaces, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkInterfaces = networkInterfaces;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> NetworkInterfaces - list of network interfaces to be attached to the virtual machine instance. </summary>
        public IList<WritableSubResource> NetworkInterfaces { get; }
    }
}
