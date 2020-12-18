// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class InboundEndpoint
    {
        internal static InboundEndpoint DeserializeInboundEndpoint(JsonElement element)
        {
            string name = default;
            InboundEndpointProtocol protocol = default;
            string publicIPAddress = default;
            string publicFQDN = default;
            int frontendPort = default;
            int backendPort = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    protocol = property.Value.GetString().ToInboundEndpointProtocol();
                    continue;
                }
                if (property.NameEquals("publicIPAddress"))
                {
                    publicIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicFQDN"))
                {
                    publicFQDN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontendPort"))
                {
                    frontendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendPort"))
                {
                    backendPort = property.Value.GetInt32();
                    continue;
                }
            }
            return new InboundEndpoint(name, protocol, publicIPAddress, publicFQDN, frontendPort, backendPort);
        }
    }
}
