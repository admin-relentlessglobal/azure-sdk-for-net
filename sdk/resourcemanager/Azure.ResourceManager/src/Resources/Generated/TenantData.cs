// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the Tenant data model.
    /// Tenant Id information.
    /// </summary>
    public partial class TenantData
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

        /// <summary> Initializes a new instance of <see cref="TenantData"/>. </summary>
        internal TenantData()
        {
            Domains = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="TenantData"/>. </summary>
        /// <param name="id"> The fully qualified ID of the tenant. For example, /tenants/8d65815f-a5b6-402f-9298-045155da7d74. </param>
        /// <param name="tenantId"> The tenant ID. For example, 8d65815f-a5b6-402f-9298-045155da7d74. </param>
        /// <param name="tenantCategory"> Category of the tenant. </param>
        /// <param name="country"> Country/region name of the address for the tenant. </param>
        /// <param name="countryCode"> Country/region abbreviation for the tenant. </param>
        /// <param name="displayName"> The display name of the tenant. </param>
        /// <param name="domains"> The list of domains for the tenant. </param>
        /// <param name="defaultDomain"> The default domain for the tenant. </param>
        /// <param name="tenantType"> The tenant type. Only available for 'Home' tenant category. </param>
        /// <param name="tenantBrandingLogoUri"> The tenant's branding logo URL. Only available for 'Home' tenant category. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TenantData(string id, Guid? tenantId, TenantCategory? tenantCategory, string country, string countryCode, string displayName, IReadOnlyList<string> domains, string defaultDomain, string tenantType, Uri tenantBrandingLogoUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            TenantId = tenantId;
            TenantCategory = tenantCategory;
            Country = country;
            CountryCode = countryCode;
            DisplayName = displayName;
            Domains = domains;
            DefaultDomain = defaultDomain;
            TenantType = tenantType;
            TenantBrandingLogoUri = tenantBrandingLogoUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The fully qualified ID of the tenant. For example, /tenants/8d65815f-a5b6-402f-9298-045155da7d74. </summary>
        public string Id { get; }
        /// <summary> The tenant ID. For example, 8d65815f-a5b6-402f-9298-045155da7d74. </summary>
        public Guid? TenantId { get; }
        /// <summary> Category of the tenant. </summary>
        public TenantCategory? TenantCategory { get; }
        /// <summary> Country/region name of the address for the tenant. </summary>
        public string Country { get; }
        /// <summary> Country/region abbreviation for the tenant. </summary>
        public string CountryCode { get; }
        /// <summary> The display name of the tenant. </summary>
        public string DisplayName { get; }
        /// <summary> The list of domains for the tenant. </summary>
        public IReadOnlyList<string> Domains { get; }
        /// <summary> The default domain for the tenant. </summary>
        public string DefaultDomain { get; }
        /// <summary> The tenant type. Only available for 'Home' tenant category. </summary>
        public string TenantType { get; }
        /// <summary> The tenant's branding logo URL. Only available for 'Home' tenant category. </summary>
        public Uri TenantBrandingLogoUri { get; }
    }
}
