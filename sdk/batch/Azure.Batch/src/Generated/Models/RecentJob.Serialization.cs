// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class RecentJob
    {
        internal static RecentJob DeserializeRecentJob(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new RecentJob(id.Value, url.Value);
        }
    }
}
