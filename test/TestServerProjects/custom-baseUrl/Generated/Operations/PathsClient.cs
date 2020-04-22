// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace custom_baseUrl
{
    /// <summary> The Paths service client. </summary>
    public partial class PathsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PathsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PathsClient for mocking. </summary>
        protected PathsClient()
        {
        }
        /// <summary> Initializes a new instance of PathsClient. </summary>
        internal PathsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "host")
        {
            RestClient = new PathsRestClient(clientDiagnostics, pipeline, host);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get a 200 to test a valid base uri. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetEmptyAsync(string accountName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetEmptyAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get a 200 to test a valid base uri. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetEmpty(string accountName, CancellationToken cancellationToken = default)
        {
            return RestClient.GetEmpty(accountName, cancellationToken);
        }
    }
}
