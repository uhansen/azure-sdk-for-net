// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class BatchErrorDetail
    {
        internal static BatchErrorDetail DeserializeBatchErrorDetail(JsonElement element)
        {
            Optional<string> key = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new BatchErrorDetail(key.Value, value.Value);
        }
    }
}
