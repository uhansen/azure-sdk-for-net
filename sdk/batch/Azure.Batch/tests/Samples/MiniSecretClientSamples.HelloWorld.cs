﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.Batch.Models;
using NUnit.Framework;
using Azure.Template;

namespace Azure.Batch.Tests.Samples
{
    public class MiniSecretClientSamples: SamplesBase<MiniSecretClientTestEnvironment>
    {
        [Test]
        public void GettingASecret()
        {
            var endpoint = TestEnvironment.KeyVaultUri;

            #region Snippet:GetSecret
            var client = new MiniSecretClient(new Uri(endpoint), new DefaultAzureCredential());

            SecretBundle secret = client.GetSecret("TestSecret");

            Console.WriteLine(secret.Value);
            #endregion
        }
    }
}
