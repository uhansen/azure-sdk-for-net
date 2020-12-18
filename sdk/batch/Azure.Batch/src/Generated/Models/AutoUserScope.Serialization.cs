// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    internal static class AutoUserScopeExtensions
    {
        public static string ToSerialString(this AutoUserScope value) => value switch
        {
            AutoUserScope.Task => "task",
            AutoUserScope.Pool => "pool",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoUserScope value.")
        };

        public static AutoUserScope ToAutoUserScope(this string value)
        {
            if (string.Equals(value, "task", StringComparison.InvariantCultureIgnoreCase)) return AutoUserScope.Task;
            if (string.Equals(value, "pool", StringComparison.InvariantCultureIgnoreCase)) return AutoUserScope.Pool;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoUserScope value.");
        }
    }
}
