// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class JobSchedulingError
    {
        internal static JobSchedulingError DeserializeJobSchedulingError(JsonElement element)
        {
            ErrorCategory category = default;
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<IReadOnlyList<NameValuePair>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString().ToErrorCategory();
                    continue;
                }
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NameValuePair> array = new List<NameValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NameValuePair.DeserializeNameValuePair(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new JobSchedulingError(category, code.Value, message.Value, Optional.ToList(details));
        }
    }
}
