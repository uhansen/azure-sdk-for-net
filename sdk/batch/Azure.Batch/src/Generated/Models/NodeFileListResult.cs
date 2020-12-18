// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Batch.Models
{
    /// <summary> The result of listing the files on a Compute Node, or the files associated with a Task on a Compute Node. </summary>
    public partial class NodeFileListResult
    {
        /// <summary> Initializes a new instance of NodeFileListResult. </summary>
        internal NodeFileListResult()
        {
            Value = new ChangeTrackingList<NodeFile>();
        }

        /// <summary> Initializes a new instance of NodeFileListResult. </summary>
        /// <param name="value"> The list of files. </param>
        /// <param name="odataNextLink"> The URL to get the next set of results. </param>
        internal NodeFileListResult(IReadOnlyList<NodeFile> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> The list of files. </summary>
        public IReadOnlyList<NodeFile> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string OdataNextLink { get; }
    }
}
