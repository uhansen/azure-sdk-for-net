// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Batch.Tests
{
    public class MiniSecretClientTestEnvironment : TestEnvironment
    {
        public MiniSecretClientTestEnvironment() : base("template")
        {
        }

        public string KeyVaultUri => GetRecordedVariable("KEYVAULT_URL");
    }
}
