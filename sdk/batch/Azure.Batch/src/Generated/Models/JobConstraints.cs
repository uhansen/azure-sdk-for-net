// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    /// <summary> The execution constraints for a Job. </summary>
    public partial class JobConstraints
    {
        /// <summary> Initializes a new instance of JobConstraints. </summary>
        public JobConstraints()
        {
        }

        /// <summary> Initializes a new instance of JobConstraints. </summary>
        /// <param name="maxWallClockTime"> If the Job does not complete within the time limit, the Batch service terminates it and any Tasks that are still running. In this case, the termination reason will be MaxWallClockTimeExpiry. If this property is not specified, there is no time limit on how long the Job may run. </param>
        /// <param name="maxTaskRetryCount"> Note that this value specifically controls the number of retries. The Batch service will try each Task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries a Task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry Tasks. If the maximum retry count is -1, the Batch service retries Tasks without limit. The default value is 0 (no retries). </param>
        internal JobConstraints(TimeSpan? maxWallClockTime, int? maxTaskRetryCount)
        {
            MaxWallClockTime = maxWallClockTime;
            MaxTaskRetryCount = maxTaskRetryCount;
        }

        /// <summary> If the Job does not complete within the time limit, the Batch service terminates it and any Tasks that are still running. In this case, the termination reason will be MaxWallClockTimeExpiry. If this property is not specified, there is no time limit on how long the Job may run. </summary>
        public TimeSpan? MaxWallClockTime { get; set; }
        /// <summary> Note that this value specifically controls the number of retries. The Batch service will try each Task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries a Task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry Tasks. If the maximum retry count is -1, the Batch service retries Tasks without limit. The default value is 0 (no retries). </summary>
        public int? MaxTaskRetryCount { get; set; }
    }
}
