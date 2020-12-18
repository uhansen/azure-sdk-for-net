// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class PoolUsageMetrics
    {
        internal static PoolUsageMetrics DeserializePoolUsageMetrics(JsonElement element)
        {
            string poolId = default;
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            string vmSize = default;
            double totalCoreHours = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("poolId"))
                {
                    poolId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("vmSize"))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalCoreHours"))
                {
                    totalCoreHours = property.Value.GetDouble();
                    continue;
                }
            }
            return new PoolUsageMetrics(poolId, startTime, endTime, vmSize, totalCoreHours);
        }
    }
}
