// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.AI.MetricsAdvisor;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MetricSeriesList. </summary>
    internal partial class MetricSeriesList
    {
        /// <summary> Initializes a new instance of <see cref="MetricSeriesList"/>. </summary>
        internal MetricSeriesList()
        {
            Value = new ChangeTrackingList<MetricSeriesDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="MetricSeriesList"/>. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value"></param>
        internal MetricSeriesList(string nextLink, IReadOnlyList<MetricSeriesDefinition> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<MetricSeriesDefinition> Value { get; }
    }
}
