// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    internal static class TaskAddStatusExtensions
    {
        public static string ToSerialString(this TaskAddStatus value) => value switch
        {
            TaskAddStatus.Success => "success",
            TaskAddStatus.ClientError => "clienterror",
            TaskAddStatus.ServerError => "servererror",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TaskAddStatus value.")
        };

        public static TaskAddStatus ToTaskAddStatus(this string value)
        {
            if (string.Equals(value, "success", StringComparison.InvariantCultureIgnoreCase)) return TaskAddStatus.Success;
            if (string.Equals(value, "clienterror", StringComparison.InvariantCultureIgnoreCase)) return TaskAddStatus.ClientError;
            if (string.Equals(value, "servererror", StringComparison.InvariantCultureIgnoreCase)) return TaskAddStatus.ServerError;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TaskAddStatus value.");
        }
    }
}
