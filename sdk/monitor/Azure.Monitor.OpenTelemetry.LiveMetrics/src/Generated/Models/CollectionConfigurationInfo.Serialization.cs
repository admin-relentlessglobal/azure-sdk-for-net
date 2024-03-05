// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Monitor.OpenTelemetry.LiveMetrics;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class CollectionConfigurationInfo
    {
        internal static CollectionConfigurationInfo DeserializeCollectionConfigurationInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string etag = default;
            IReadOnlyList<DerivedMetricInfo> metrics = default;
            IReadOnlyList<DocumentStreamInfo> documentStreams = default;
            QuotaConfigurationInfo quotaInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DerivedMetricInfo> array = new List<DerivedMetricInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DerivedMetricInfo.DeserializeDerivedMetricInfo(item));
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("DocumentStreams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentStreamInfo> array = new List<DocumentStreamInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentStreamInfo.DeserializeDocumentStreamInfo(item));
                    }
                    documentStreams = array;
                    continue;
                }
                if (property.NameEquals("QuotaInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quotaInfo = QuotaConfigurationInfo.DeserializeQuotaConfigurationInfo(property.Value);
                    continue;
                }
            }
            return new CollectionConfigurationInfo(etag, metrics ?? new ChangeTrackingList<DerivedMetricInfo>(), documentStreams ?? new ChangeTrackingList<DocumentStreamInfo>(), quotaInfo);
        }
    }
}
