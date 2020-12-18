// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    /// <summary> Usage metrics for a Pool across an aggregation interval. </summary>
    public partial class PoolUsageMetrics
    {
        /// <summary> Initializes a new instance of PoolUsageMetrics. </summary>
        /// <param name="poolId"> The ID of the Pool whose metrics are aggregated in this entry. </param>
        /// <param name="startTime"> The start time of the aggregation interval covered by this entry. </param>
        /// <param name="endTime"> The end time of the aggregation interval covered by this entry. </param>
        /// <param name="vmSize"> For information about available sizes of virtual machines in Pools, see Choose a VM size for Compute Nodes in an Azure Batch Pool (https://docs.microsoft.com/azure/batch/batch-pool-vm-sizes). </param>
        /// <param name="totalCoreHours"> The total core hours used in the Pool during this aggregation interval. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="poolId"/> or <paramref name="vmSize"/> is null. </exception>
        internal PoolUsageMetrics(string poolId, DateTimeOffset startTime, DateTimeOffset endTime, string vmSize, double totalCoreHours)
        {
            if (poolId == null)
            {
                throw new ArgumentNullException(nameof(poolId));
            }
            if (vmSize == null)
            {
                throw new ArgumentNullException(nameof(vmSize));
            }

            PoolId = poolId;
            StartTime = startTime;
            EndTime = endTime;
            VmSize = vmSize;
            TotalCoreHours = totalCoreHours;
        }

        /// <summary> The ID of the Pool whose metrics are aggregated in this entry. </summary>
        public string PoolId { get; }
        /// <summary> The start time of the aggregation interval covered by this entry. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> The end time of the aggregation interval covered by this entry. </summary>
        public DateTimeOffset EndTime { get; }
        /// <summary> For information about available sizes of virtual machines in Pools, see Choose a VM size for Compute Nodes in an Azure Batch Pool (https://docs.microsoft.com/azure/batch/batch-pool-vm-sizes). </summary>
        public string VmSize { get; }
        /// <summary> The total core hours used in the Pool during this aggregation interval. </summary>
        public double TotalCoreHours { get; }
    }
}
