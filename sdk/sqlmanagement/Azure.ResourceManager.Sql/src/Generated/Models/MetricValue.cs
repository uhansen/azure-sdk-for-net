// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Represents database metrics. </summary>
    public partial class MetricValue
    {
        /// <summary> Initializes a new instance of MetricValue. </summary>
        internal MetricValue()
        {
        }

        /// <summary> Initializes a new instance of MetricValue. </summary>
        /// <param name="count"> The number of values for the metric. </param>
        /// <param name="average"> The average value of the metric. </param>
        /// <param name="maximum"> The max value of the metric. </param>
        /// <param name="minimum"> The min value of the metric. </param>
        /// <param name="timestamp"> The metric timestamp (ISO-8601 format). </param>
        /// <param name="total"> The total value of the metric. </param>
        internal MetricValue(int? count, double? average, double? maximum, double? minimum, DateTimeOffset? timestamp, double? total)
        {
            Count = count;
            Average = average;
            Maximum = maximum;
            Minimum = minimum;
            Timestamp = timestamp;
            Total = total;
        }

        /// <summary> The number of values for the metric. </summary>
        public int? Count { get; }
        /// <summary> The average value of the metric. </summary>
        public double? Average { get; }
        /// <summary> The max value of the metric. </summary>
        public double? Maximum { get; }
        /// <summary> The min value of the metric. </summary>
        public double? Minimum { get; }
        /// <summary> The metric timestamp (ISO-8601 format). </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The total value of the metric. </summary>
        public double? Total { get; }
    }
}