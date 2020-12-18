// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class PublicIPAddressConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Provision))
            {
                writer.WritePropertyName("provision");
                writer.WriteStringValue(Provision.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(IpAddressIds))
            {
                writer.WritePropertyName("ipAddressIds");
                writer.WriteStartArray();
                foreach (var item in IpAddressIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PublicIPAddressConfiguration DeserializePublicIPAddressConfiguration(JsonElement element)
        {
            Optional<IPAddressProvisioningType> provision = default;
            Optional<IList<string>> ipAddressIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provision"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provision = property.Value.GetString().ToIPAddressProvisioningType();
                    continue;
                }
                if (property.NameEquals("ipAddressIds"))
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
                    ipAddressIds = array;
                    continue;
                }
            }
            return new PublicIPAddressConfiguration(Optional.ToNullable(provision), Optional.ToList(ipAddressIds));
        }
    }
}
