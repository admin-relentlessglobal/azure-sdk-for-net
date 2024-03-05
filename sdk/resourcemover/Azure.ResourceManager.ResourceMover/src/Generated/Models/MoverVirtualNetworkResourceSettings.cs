// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the virtual network resource settings. </summary>
    public partial class MoverVirtualNetworkResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of <see cref="MoverVirtualNetworkResourceSettings"/>. </summary>
        public MoverVirtualNetworkResourceSettings()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            AddressSpace = new ChangeTrackingList<string>();
            DnsServers = new ChangeTrackingList<string>();
            Subnets = new ChangeTrackingList<SubnetResourceSettings>();
            ResourceType = "Microsoft.Network/virtualNetworks";
        }

        /// <summary> Initializes a new instance of <see cref="MoverVirtualNetworkResourceSettings"/>. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="targetResourceGroupName"> Gets or sets the target resource group name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="enableDdosProtection">
        /// Gets or sets a value indicating whether gets or sets whether the
        /// DDOS protection should be switched on.
        /// </param>
        /// <param name="addressSpace"> Gets or sets the address prefixes for the virtual network. </param>
        /// <param name="dnsServers">
        /// Gets or sets DHCPOptions that contains an array of DNS servers available to VMs
        /// deployed in the virtual network.
        /// </param>
        /// <param name="subnets"> Gets or sets List of subnets in a VirtualNetwork. </param>
        internal MoverVirtualNetworkResourceSettings(string resourceType, string targetResourceName, string targetResourceGroupName, IDictionary<string, BinaryData> serializedAdditionalRawData, IDictionary<string, string> tags, bool? enableDdosProtection, IList<string> addressSpace, IList<string> dnsServers, IList<SubnetResourceSettings> subnets) : base(resourceType, targetResourceName, targetResourceGroupName, serializedAdditionalRawData)
        {
            Tags = tags;
            EnableDdosProtection = enableDdosProtection;
            AddressSpace = addressSpace;
            DnsServers = dnsServers;
            Subnets = subnets;
            ResourceType = resourceType ?? "Microsoft.Network/virtualNetworks";
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets whether the
        /// DDOS protection should be switched on.
        /// </summary>
        public bool? EnableDdosProtection { get; set; }
        /// <summary> Gets or sets the address prefixes for the virtual network. </summary>
        public IList<string> AddressSpace { get; set; }
        /// <summary>
        /// Gets or sets DHCPOptions that contains an array of DNS servers available to VMs
        /// deployed in the virtual network.
        /// </summary>
        public IList<string> DnsServers { get; set; }
        /// <summary> Gets or sets List of subnets in a VirtualNetwork. </summary>
        public IList<SubnetResourceSettings> Subnets { get; set; }
    }
}
