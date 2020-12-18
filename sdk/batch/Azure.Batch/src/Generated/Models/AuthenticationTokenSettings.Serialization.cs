// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class AuthenticationTokenSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Access))
            {
                writer.WritePropertyName("access");
                writer.WriteStartArray();
                foreach (var item in Access)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AuthenticationTokenSettings DeserializeAuthenticationTokenSettings(JsonElement element)
        {
            Optional<IList<string>> access = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("access"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    access = array;
                    continue;
                }
            }
            return new AuthenticationTokenSettings(Optional.ToList(access));
        }
    }
}
