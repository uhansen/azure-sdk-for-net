// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Batch.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Batch
{
    internal partial class ApplicationRestClient
    {
        private string batchUrl;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ApplicationRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="batchUrl"> The base URL for all Azure Batch service requests. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="batchUrl"/> is null. </exception>
        public ApplicationRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string batchUrl)
        {
            if (batchUrl == null)
            {
                throw new ArgumentNullException(nameof(batchUrl));
            }

            this.batchUrl = batchUrl;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(ApplicationListOptions applicationListOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(batchUrl, false);
            uri.AppendPath("/applications", false);
            if (applicationListOptions?.MaxResults != null)
            {
                uri.AppendQuery("maxresults", applicationListOptions.MaxResults.Value, true);
            }
            if (applicationListOptions?.Timeout != null)
            {
                uri.AppendQuery("timeout", applicationListOptions.Timeout.Value, true);
            }
            uri.AppendQuery("api-version", "2020-09-01.12.0", true);
            request.Uri = uri;
            if (applicationListOptions?.ClientRequestId != null)
            {
                request.Headers.Add("client-request-id", applicationListOptions.ClientRequestId.Value);
            }
            if (applicationListOptions?.ReturnClientRequestId != null)
            {
                request.Headers.Add("return-client-request-id", applicationListOptions.ReturnClientRequestId.Value);
            }
            if (applicationListOptions?.OcpDate != null)
            {
                request.Headers.Add("ocp-date", applicationListOptions.OcpDate.Value, "R");
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="applicationListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<ApplicationListResult, ApplicationListHeaders>> ListAsync(ApplicationListOptions applicationListOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(applicationListOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ApplicationListHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationListResult.DeserializeApplicationListResult(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="applicationListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<ApplicationListResult, ApplicationListHeaders> List(ApplicationListOptions applicationListOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(applicationListOptions);
            _pipeline.Send(message, cancellationToken);
            var headers = new ApplicationListHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationListResult.DeserializeApplicationListResult(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string applicationId, ApplicationGetOptions applicationGetOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(batchUrl, false);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(applicationId, true);
            if (applicationGetOptions?.Timeout != null)
            {
                uri.AppendQuery("timeout", applicationGetOptions.Timeout.Value, true);
            }
            uri.AppendQuery("api-version", "2020-09-01.12.0", true);
            request.Uri = uri;
            if (applicationGetOptions?.ClientRequestId != null)
            {
                request.Headers.Add("client-request-id", applicationGetOptions.ClientRequestId.Value);
            }
            if (applicationGetOptions?.ReturnClientRequestId != null)
            {
                request.Headers.Add("return-client-request-id", applicationGetOptions.ReturnClientRequestId.Value);
            }
            if (applicationGetOptions?.OcpDate != null)
            {
                request.Headers.Add("ocp-date", applicationGetOptions.OcpDate.Value, "R");
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about Applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="applicationId"> The ID of the Application. </param>
        /// <param name="applicationGetOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public async Task<ResponseWithHeaders<ApplicationSummary, ApplicationGetHeaders>> GetAsync(string applicationId, ApplicationGetOptions applicationGetOptions = null, CancellationToken cancellationToken = default)
        {
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }

            using var message = CreateGetRequest(applicationId, applicationGetOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ApplicationGetHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationSummary value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationSummary.DeserializeApplicationSummary(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about Applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="applicationId"> The ID of the Application. </param>
        /// <param name="applicationGetOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public ResponseWithHeaders<ApplicationSummary, ApplicationGetHeaders> Get(string applicationId, ApplicationGetOptions applicationGetOptions = null, CancellationToken cancellationToken = default)
        {
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }

            using var message = CreateGetRequest(applicationId, applicationGetOptions);
            _pipeline.Send(message, cancellationToken);
            var headers = new ApplicationGetHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationSummary value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationSummary.DeserializeApplicationSummary(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, ApplicationListOptions applicationListOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(batchUrl, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (applicationListOptions?.ClientRequestId != null)
            {
                request.Headers.Add("client-request-id", applicationListOptions.ClientRequestId.Value);
            }
            if (applicationListOptions?.ReturnClientRequestId != null)
            {
                request.Headers.Add("return-client-request-id", applicationListOptions.ReturnClientRequestId.Value);
            }
            if (applicationListOptions?.OcpDate != null)
            {
                request.Headers.Add("ocp-date", applicationListOptions.OcpDate.Value, "R");
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="applicationListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<ResponseWithHeaders<ApplicationListResult, ApplicationListHeaders>> ListNextPageAsync(string nextLink, ApplicationListOptions applicationListOptions = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, applicationListOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ApplicationListHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationListResult.DeserializeApplicationListResult(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This operation returns only Applications and versions that are available for use on Compute Nodes; that is, that can be used in an Package reference. For administrator information about applications and versions that are not yet available to Compute Nodes, use the Azure portal or the Azure Resource Manager API. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="applicationListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public ResponseWithHeaders<ApplicationListResult, ApplicationListHeaders> ListNextPage(string nextLink, ApplicationListOptions applicationListOptions = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, applicationListOptions);
            _pipeline.Send(message, cancellationToken);
            var headers = new ApplicationListHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationListResult.DeserializeApplicationListResult(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
