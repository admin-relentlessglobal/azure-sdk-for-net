// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Effective network security rules. </summary>
    public partial class EffectiveNetworkSecurityRule
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

        /// <summary> Initializes a new instance of <see cref="EffectiveNetworkSecurityRule"/>. </summary>
        internal EffectiveNetworkSecurityRule()
        {
            SourcePortRanges = new ChangeTrackingList<string>();
            DestinationPortRanges = new ChangeTrackingList<string>();
            SourceAddressPrefixes = new ChangeTrackingList<string>();
            DestinationAddressPrefixes = new ChangeTrackingList<string>();
            ExpandedSourceAddressPrefix = new ChangeTrackingList<string>();
            ExpandedDestinationAddressPrefix = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EffectiveNetworkSecurityRule"/>. </summary>
        /// <param name="name"> The name of the security rule specified by the user (if created by the user). </param>
        /// <param name="protocol"> The network protocol this rule applies to. </param>
        /// <param name="sourcePortRange"> The source port or range. </param>
        /// <param name="destinationPortRange"> The destination port or range. </param>
        /// <param name="sourcePortRanges"> The source port ranges. Expected values include a single integer between 0 and 65535, a range using '-' as separator (e.g. 100-400), or an asterisk (*). </param>
        /// <param name="destinationPortRanges"> The destination port ranges. Expected values include a single integer between 0 and 65535, a range using '-' as separator (e.g. 100-400), or an asterisk (*). </param>
        /// <param name="sourceAddressPrefix"> The source address prefix. </param>
        /// <param name="destinationAddressPrefix"> The destination address prefix. </param>
        /// <param name="sourceAddressPrefixes"> The source address prefixes. Expected values include CIDR IP ranges, Default Tags (VirtualNetwork, AzureLoadBalancer, Internet), System Tags, and the asterisk (*). </param>
        /// <param name="destinationAddressPrefixes"> The destination address prefixes. Expected values include CIDR IP ranges, Default Tags (VirtualNetwork, AzureLoadBalancer, Internet), System Tags, and the asterisk (*). </param>
        /// <param name="expandedSourceAddressPrefix"> The expanded source address prefix. </param>
        /// <param name="expandedDestinationAddressPrefix"> Expanded destination address prefix. </param>
        /// <param name="access"> Whether network traffic is allowed or denied. </param>
        /// <param name="priority"> The priority of the rule. </param>
        /// <param name="direction"> The direction of the rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EffectiveNetworkSecurityRule(string name, EffectiveSecurityRuleProtocol? protocol, string sourcePortRange, string destinationPortRange, IReadOnlyList<string> sourcePortRanges, IReadOnlyList<string> destinationPortRanges, string sourceAddressPrefix, string destinationAddressPrefix, IReadOnlyList<string> sourceAddressPrefixes, IReadOnlyList<string> destinationAddressPrefixes, IReadOnlyList<string> expandedSourceAddressPrefix, IReadOnlyList<string> expandedDestinationAddressPrefix, SecurityRuleAccess? access, int? priority, SecurityRuleDirection? direction, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Protocol = protocol;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            SourceAddressPrefix = sourceAddressPrefix;
            DestinationAddressPrefix = destinationAddressPrefix;
            SourceAddressPrefixes = sourceAddressPrefixes;
            DestinationAddressPrefixes = destinationAddressPrefixes;
            ExpandedSourceAddressPrefix = expandedSourceAddressPrefix;
            ExpandedDestinationAddressPrefix = expandedDestinationAddressPrefix;
            Access = access;
            Priority = priority;
            Direction = direction;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the security rule specified by the user (if created by the user). </summary>
        public string Name { get; }
        /// <summary> The network protocol this rule applies to. </summary>
        public EffectiveSecurityRuleProtocol? Protocol { get; }
        /// <summary> The source port or range. </summary>
        public string SourcePortRange { get; }
        /// <summary> The destination port or range. </summary>
        public string DestinationPortRange { get; }
        /// <summary> The source port ranges. Expected values include a single integer between 0 and 65535, a range using '-' as separator (e.g. 100-400), or an asterisk (*). </summary>
        public IReadOnlyList<string> SourcePortRanges { get; }
        /// <summary> The destination port ranges. Expected values include a single integer between 0 and 65535, a range using '-' as separator (e.g. 100-400), or an asterisk (*). </summary>
        public IReadOnlyList<string> DestinationPortRanges { get; }
        /// <summary> The source address prefix. </summary>
        public string SourceAddressPrefix { get; }
        /// <summary> The destination address prefix. </summary>
        public string DestinationAddressPrefix { get; }
        /// <summary> The source address prefixes. Expected values include CIDR IP ranges, Default Tags (VirtualNetwork, AzureLoadBalancer, Internet), System Tags, and the asterisk (*). </summary>
        public IReadOnlyList<string> SourceAddressPrefixes { get; }
        /// <summary> The destination address prefixes. Expected values include CIDR IP ranges, Default Tags (VirtualNetwork, AzureLoadBalancer, Internet), System Tags, and the asterisk (*). </summary>
        public IReadOnlyList<string> DestinationAddressPrefixes { get; }
        /// <summary> The expanded source address prefix. </summary>
        public IReadOnlyList<string> ExpandedSourceAddressPrefix { get; }
        /// <summary> Expanded destination address prefix. </summary>
        public IReadOnlyList<string> ExpandedDestinationAddressPrefix { get; }
        /// <summary> Whether network traffic is allowed or denied. </summary>
        public SecurityRuleAccess? Access { get; }
        /// <summary> The priority of the rule. </summary>
        public int? Priority { get; }
        /// <summary> The direction of the rule. </summary>
        public SecurityRuleDirection? Direction { get; }
    }
}
