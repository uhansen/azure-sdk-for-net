// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    /// <summary> A Certificate that can be installed on Compute Nodes and can be used to authenticate operations on the machine. </summary>
    public partial class Certificate
    {
        /// <summary> Initializes a new instance of Certificate. </summary>
        internal Certificate()
        {
        }

        /// <summary> Initializes a new instance of Certificate. </summary>
        /// <param name="thumbprint"> The X.509 thumbprint of the Certificate. This is a sequence of up to 40 hex digits. </param>
        /// <param name="thumbprintAlgorithm"> The algorithm used to derive the thumbprint. </param>
        /// <param name="url"> The URL of the Certificate. </param>
        /// <param name="state"> The state of the Certificate. </param>
        /// <param name="stateTransitionTime"> The time at which the Certificate entered its current state. </param>
        /// <param name="previousState"> This property is not set if the Certificate is in its initial active state. </param>
        /// <param name="previousStateTransitionTime"> This property is not set if the Certificate is in its initial Active state. </param>
        /// <param name="publicData"> The public part of the Certificate as a base-64 encoded .cer file. </param>
        /// <param name="deleteCertificateError"> This property is set only if the Certificate is in the DeleteFailed state. </param>
        internal Certificate(string thumbprint, string thumbprintAlgorithm, string url, CertificateState? state, DateTimeOffset? stateTransitionTime, CertificateState? previousState, DateTimeOffset? previousStateTransitionTime, string publicData, DeleteCertificateError deleteCertificateError)
        {
            Thumbprint = thumbprint;
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Url = url;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            PublicData = publicData;
            DeleteCertificateError = deleteCertificateError;
        }

        /// <summary> The X.509 thumbprint of the Certificate. This is a sequence of up to 40 hex digits. </summary>
        public string Thumbprint { get; }
        /// <summary> The algorithm used to derive the thumbprint. </summary>
        public string ThumbprintAlgorithm { get; }
        /// <summary> The URL of the Certificate. </summary>
        public string Url { get; }
        /// <summary> The state of the Certificate. </summary>
        public CertificateState? State { get; }
        /// <summary> The time at which the Certificate entered its current state. </summary>
        public DateTimeOffset? StateTransitionTime { get; }
        /// <summary> This property is not set if the Certificate is in its initial active state. </summary>
        public CertificateState? PreviousState { get; }
        /// <summary> This property is not set if the Certificate is in its initial Active state. </summary>
        public DateTimeOffset? PreviousStateTransitionTime { get; }
        /// <summary> The public part of the Certificate as a base-64 encoded .cer file. </summary>
        public string PublicData { get; }
        /// <summary> This property is set only if the Certificate is in the DeleteFailed state. </summary>
        public DeleteCertificateError DeleteCertificateError { get; }
    }
}
