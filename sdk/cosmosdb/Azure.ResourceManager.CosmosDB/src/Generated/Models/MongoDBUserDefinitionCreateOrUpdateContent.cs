// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update an Azure Cosmos DB Mongo User Definition. </summary>
    public partial class MongoDBUserDefinitionCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="MongoDBUserDefinitionCreateOrUpdateContent"/>. </summary>
        public MongoDBUserDefinitionCreateOrUpdateContent()
        {
            Roles = new ChangeTrackingList<MongoDBRole>();
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBUserDefinitionCreateOrUpdateContent"/>. </summary>
        /// <param name="userName"> The user name for User Definition. </param>
        /// <param name="password"> The password for User Definition. Response does not contain user password. </param>
        /// <param name="databaseName"> The database name for which access is being granted for this User Definition. </param>
        /// <param name="customData"> A custom definition for the USer Definition. </param>
        /// <param name="roles"> The set of roles inherited by the User Definition. </param>
        /// <param name="mechanisms"> The Mongo Auth mechanism. For now, we only support auth mechanism SCRAM-SHA-256. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBUserDefinitionCreateOrUpdateContent(string userName, string password, string databaseName, string customData, IList<MongoDBRole> roles, string mechanisms, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserName = userName;
            Password = password;
            DatabaseName = databaseName;
            CustomData = customData;
            Roles = roles;
            Mechanisms = mechanisms;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The user name for User Definition. </summary>
        public string UserName { get; set; }
        /// <summary> The password for User Definition. Response does not contain user password. </summary>
        public string Password { get; set; }
        /// <summary> The database name for which access is being granted for this User Definition. </summary>
        public string DatabaseName { get; set; }
        /// <summary> A custom definition for the USer Definition. </summary>
        public string CustomData { get; set; }
        /// <summary> The set of roles inherited by the User Definition. </summary>
        public IList<MongoDBRole> Roles { get; }
        /// <summary> The Mongo Auth mechanism. For now, we only support auth mechanism SCRAM-SHA-256. </summary>
        public string Mechanisms { get; set; }
    }
}
