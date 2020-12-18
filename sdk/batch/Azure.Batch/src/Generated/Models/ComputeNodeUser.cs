// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    /// <summary> A user Account for RDP or SSH access on a Compute Node. </summary>
    public partial class ComputeNodeUser
    {
        /// <summary> Initializes a new instance of ComputeNodeUser. </summary>
        /// <param name="name"> The user name of the Account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ComputeNodeUser(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> The user name of the Account. </summary>
        public string Name { get; }
        /// <summary> The default value is false. </summary>
        public bool? IsAdmin { get; set; }
        /// <summary> If omitted, the default is 1 day from the current time. For Linux Compute Nodes, the expiryTime has a precision up to a day. </summary>
        public DateTimeOffset? ExpiryTime { get; set; }
        /// <summary> The password is required for Windows Compute Nodes (those created with &apos;cloudServiceConfiguration&apos;, or created with &apos;virtualMachineConfiguration&apos; using a Windows Image reference). For Linux Compute Nodes, the password can optionally be specified along with the sshPublicKey property. </summary>
        public string Password { get; set; }
        /// <summary> The public key should be compatible with OpenSSH encoding and should be base 64 encoded. This property can be specified only for Linux Compute Nodes. If this is specified for a Windows Compute Node, then the Batch service rejects the request; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public string SshPublicKey { get; set; }
    }
}
