// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using Azure.Data.Tables;
using Azure.Data.Tables.Models;
using Azure.Data.Tables.Sas;
using Moq;
using NUnit.Framework;

namespace Azure.Tables.Tests
{
    public class TableClientTests : ClientTestBase
    {

        public TableClientTests(bool isAsync) : base(isAsync)
        { }

        private const string tableName = "someTableName";
        internal Mock<TableInternalClient> mockClient { get; set; }
        internal TableClient client_Instrumented { get; set; }
        internal TableClient client { get; set; }
        internal ClientDiagnostics _clientDiagnostics = new ClientDiagnostics(new TableClientOptions());
        internal Dictionary<string, object> entityWithoutPK = new Dictionary<string, object> { { TableConstants.PropertyNames.RowKey, "row" } };
        internal Dictionary<string, object> entityWithoutRK = new Dictionary<string, object> { { TableConstants.PropertyNames.PartitionKey, "partition" } };
        internal Dictionary<string, object> validEntity = new Dictionary<string, object> { { TableConstants.PropertyNames.PartitionKey, "partition" }, { TableConstants.PropertyNames.RowKey, "row" } };

        [SetUp]
        public void TestSetup()
        {
            mockClient = new Mock<TableInternalClient>();
            var service_Instrumented = InstrumentClient(new TableServiceClient(mockClient.Object));
            client_Instrumented = service_Instrumented.GetTableClient(tableName);

            var service = new TableServiceClient(mockClient.Object);
            client = service.GetTableClient(tableName);
        }

        /// <summary>
        /// Validates the functionality of the TableClient.
        /// </summary>
        [Test]
        public void ServiceMethodsValidateArguments()
        {
            Assert.That(async () => await client_Instrumented.InsertAsync(null), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.InsertAsync<TableEntity>(null), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.UpsertAsync<TableEntity>(null), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.UpsertAsync(new TableEntity { PartitionKey = null, RowKey = "row" }), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.PartitionKey}.");

            Assert.That(async () => await client_Instrumented.UpsertAsync(new TableEntity { PartitionKey = "partition", RowKey = null }), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.RowKey}.");

            Assert.That(async () => await client_Instrumented.UpsertAsync(null), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.UpsertAsync(entityWithoutPK), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.PartitionKey}.");

            Assert.That(async () => await client_Instrumented.UpsertAsync(entityWithoutRK), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.RowKey}.");

            Assert.That(async () => await client_Instrumented.UpdateAsync(null, "etag"), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.UpdateAsync(validEntity, null), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.UpdateAsync(entityWithoutPK, "etag"), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.PartitionKey}.");

            Assert.That(async () => await client_Instrumented.UpdateAsync(entityWithoutRK, "etag"), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.RowKey}.");

            Assert.That(async () => await client_Instrumented.MergeAsync(null, "etag"), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.MergeAsync(entityWithoutPK, "etag"), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.PartitionKey}.");

            Assert.That(async () => await client_Instrumented.MergeAsync(entityWithoutRK, "etag"), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.RowKey}.");
        }

        [Test]
        public void GetSasBuilderPopulatesPermissionsAndExpiry()
        {
            var expiry = DateTimeOffset.Now.AddDays(1);
            var permissions = TableSasPermissions.All;

            var sas = client_Instrumented.GetSasBuilder(permissions, expiry);

            Assert.That(sas.Permissions, Is.EqualTo(permissions.ToPermissionsString()));
            Assert.That(sas.ExpiresOn, Is.EqualTo(expiry));
        }

        [Test]
        public void GetSasBuilderPopulatesRawPermissionsAndExpiry()
        {
            var expiry = DateTimeOffset.Now.AddDays(1);
            var permissions = TableSasPermissions.All;

            var sas = client_Instrumented.GetSasBuilder(permissions.ToPermissionsString(), expiry);

            Assert.That(sas.Permissions, Is.EqualTo(permissions.ToPermissionsString()));
            Assert.That(sas.ExpiresOn, Is.EqualTo(expiry));
        }

        [Test]
        public async Task CreateCallsInternalCreate()
        {
            if (IsAsync)
            {
                mockClient
                    .Setup(m => m.CreateAsync(It.IsAny<TableProperties>(), null, null, It.IsAny<QueryOptions>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(Response.FromValue(new TableResponse(tableName, null, null, null, null), Mock.Of<Response>()))
                    .Verifiable();

                await client.CreateAsync();
            }
            else
            {
                mockClient
                    .Setup(m => m.Create(It.IsAny<TableProperties>(), null, null, It.IsAny<QueryOptions>(), It.IsAny<CancellationToken>()))
                    .Returns(Response.FromValue(new TableResponse(tableName, null, null, null, null), Mock.Of<Response>()))
                    .Verifiable();

                client.Create();
            }

            mockClient.Verify();
        }
    }
}
