// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class JobExecutionInformation
    {
        internal static JobExecutionInformation DeserializeJobExecutionInformation(JsonElement element)
        {
            DateTimeOffset startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> poolId = default;
            Optional<JobSchedulingError> schedulingError = default;
            Optional<string> terminateReason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("poolId"))
                {
                    poolId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schedulingError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schedulingError = JobSchedulingError.DeserializeJobSchedulingError(property.Value);
                    continue;
                }
                if (property.NameEquals("terminateReason"))
                {
                    terminateReason = property.Value.GetString();
                    continue;
                }
            }
            return new JobExecutionInformation(startTime, Optional.ToNullable(endTime), poolId.Value, schedulingError.Value, terminateReason.Value);
        }
    }
}
