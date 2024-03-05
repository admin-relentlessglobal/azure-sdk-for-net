// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Effective Route. </summary>
    public partial class EffectiveRoute
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

        /// <summary> Initializes a new instance of <see cref="EffectiveRoute"/>. </summary>
        internal EffectiveRoute()
        {
            AddressPrefix = new ChangeTrackingList<string>();
            NextHopIPAddress = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EffectiveRoute"/>. </summary>
        /// <param name="name"> The name of the user defined route. This is optional. </param>
        /// <param name="disableBgpRoutePropagation"> If true, on-premises routes are not propagated to the network interfaces in the subnet. </param>
        /// <param name="source"> Who created the route. </param>
        /// <param name="state"> The value of effective route. </param>
        /// <param name="addressPrefix"> The address prefixes of the effective routes in CIDR notation. </param>
        /// <param name="nextHopIPAddress"> The IP address of the next hop of the effective route. </param>
        /// <param name="nextHopType"> The type of Azure hop the packet should be sent to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EffectiveRoute(string name, bool? disableBgpRoutePropagation, EffectiveRouteSource? source, EffectiveRouteState? state, IReadOnlyList<string> addressPrefix, IReadOnlyList<string> nextHopIPAddress, RouteNextHopType? nextHopType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DisableBgpRoutePropagation = disableBgpRoutePropagation;
            Source = source;
            State = state;
            AddressPrefix = addressPrefix;
            NextHopIPAddress = nextHopIPAddress;
            NextHopType = nextHopType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the user defined route. This is optional. </summary>
        public string Name { get; }
        /// <summary> If true, on-premises routes are not propagated to the network interfaces in the subnet. </summary>
        public bool? DisableBgpRoutePropagation { get; }
        /// <summary> Who created the route. </summary>
        public EffectiveRouteSource? Source { get; }
        /// <summary> The value of effective route. </summary>
        public EffectiveRouteState? State { get; }
        /// <summary> The address prefixes of the effective routes in CIDR notation. </summary>
        public IReadOnlyList<string> AddressPrefix { get; }
        /// <summary> The IP address of the next hop of the effective route. </summary>
        public IReadOnlyList<string> NextHopIPAddress { get; }
        /// <summary> The type of Azure hop the packet should be sent to. </summary>
        public RouteNextHopType? NextHopType { get; }
    }
}
