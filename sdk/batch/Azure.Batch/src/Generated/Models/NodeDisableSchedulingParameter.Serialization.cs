// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class NodeDisableSchedulingParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NodeDisableSchedulingOption))
            {
                writer.WritePropertyName("nodeDisableSchedulingOption");
                writer.WriteStringValue(NodeDisableSchedulingOption.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }
    }
}
