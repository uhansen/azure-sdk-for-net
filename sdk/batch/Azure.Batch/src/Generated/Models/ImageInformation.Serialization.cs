// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class ImageInformation
    {
        internal static ImageInformation DeserializeImageInformation(JsonElement element)
        {
            string nodeAgentSKUId = default;
            ImageReference imageReference = default;
            OSType osType = default;
            Optional<IReadOnlyList<string>> capabilities = default;
            Optional<DateTimeOffset> batchSupportEndOfLife = default;
            VerificationType verificationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeAgentSKUId"))
                {
                    nodeAgentSKUId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageReference"))
                {
                    imageReference = ImageReference.DeserializeImageReference(property.Value);
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString().ToOSType();
                    continue;
                }
                if (property.NameEquals("capabilities"))
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
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("batchSupportEndOfLife"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    batchSupportEndOfLife = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("verificationType"))
                {
                    verificationType = property.Value.GetString().ToVerificationType();
                    continue;
                }
            }
            return new ImageInformation(nodeAgentSKUId, imageReference, osType, Optional.ToList(capabilities), Optional.ToNullable(batchSupportEndOfLife), verificationType);
        }
    }
}
