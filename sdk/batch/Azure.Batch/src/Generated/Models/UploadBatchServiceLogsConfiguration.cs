// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    /// <summary> The Azure Batch service log files upload configuration for a Compute Node. </summary>
    public partial class UploadBatchServiceLogsConfiguration
    {
        /// <summary> Initializes a new instance of UploadBatchServiceLogsConfiguration. </summary>
        /// <param name="containerUrl"> The URL must include a Shared Access Signature (SAS) granting write permissions to the container. The SAS duration must allow enough time for the upload to finish. The start time for SAS is optional and recommended to not be specified. </param>
        /// <param name="startTime"> Any log file containing a log message in the time range will be uploaded. This means that the operation might retrieve more logs than have been requested since the entire log file is always uploaded, but the operation should not retrieve fewer logs than have been requested. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerUrl"/> is null. </exception>
        public UploadBatchServiceLogsConfiguration(string containerUrl, DateTimeOffset startTime)
        {
            if (containerUrl == null)
            {
                throw new ArgumentNullException(nameof(containerUrl));
            }

            ContainerUrl = containerUrl;
            StartTime = startTime;
        }

        /// <summary> The URL must include a Shared Access Signature (SAS) granting write permissions to the container. The SAS duration must allow enough time for the upload to finish. The start time for SAS is optional and recommended to not be specified. </summary>
        public string ContainerUrl { get; }
        /// <summary> Any log file containing a log message in the time range will be uploaded. This means that the operation might retrieve more logs than have been requested since the entire log file is always uploaded, but the operation should not retrieve fewer logs than have been requested. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> Any log file containing a log message in the time range will be uploaded. This means that the operation might retrieve more logs than have been requested since the entire log file is always uploaded, but the operation should not retrieve fewer logs than have been requested. If omitted, the default is to upload all logs available after the startTime. </summary>
        public DateTimeOffset? EndTime { get; set; }
    }
}
