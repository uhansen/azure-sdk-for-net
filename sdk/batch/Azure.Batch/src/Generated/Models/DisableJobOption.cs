// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Models
{
    /// <summary> What to do with active Tasks associated with the Job. </summary>
    public enum DisableJobOption
    {
        /// <summary> Terminate running Tasks and requeue them. The Tasks will run again when the Job is enabled. </summary>
        Requeue,
        /// <summary> Terminate running Tasks. The Tasks will be completed with failureInfo indicating that they were terminated, and will not run again. </summary>
        Terminate,
        /// <summary> Allow currently running Tasks to complete. </summary>
        Wait
    }
}
