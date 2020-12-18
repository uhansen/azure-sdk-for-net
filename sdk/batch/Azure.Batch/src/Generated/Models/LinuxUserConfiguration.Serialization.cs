// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class LinuxUserConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uid))
            {
                writer.WritePropertyName("uid");
                writer.WriteNumberValue(Uid.Value);
            }
            if (Optional.IsDefined(Gid))
            {
                writer.WritePropertyName("gid");
                writer.WriteNumberValue(Gid.Value);
            }
            if (Optional.IsDefined(SshPrivateKey))
            {
                writer.WritePropertyName("sshPrivateKey");
                writer.WriteStringValue(SshPrivateKey);
            }
            writer.WriteEndObject();
        }

        internal static LinuxUserConfiguration DeserializeLinuxUserConfiguration(JsonElement element)
        {
            Optional<int> uid = default;
            Optional<int> gid = default;
            Optional<string> sshPrivateKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    uid = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("gid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gid = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sshPrivateKey"))
                {
                    sshPrivateKey = property.Value.GetString();
                    continue;
                }
            }
            return new LinuxUserConfiguration(Optional.ToNullable(uid), Optional.ToNullable(gid), sshPrivateKey.Value);
        }
    }
}
