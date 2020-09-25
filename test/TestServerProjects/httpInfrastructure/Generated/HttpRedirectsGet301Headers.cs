// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace httpInfrastructure
{
    internal class HttpRedirectsGet301Headers
    {
        private readonly Response _response;
        public HttpRedirectsGet301Headers(Response response)
        {
            _response = response;
        }
        /// <summary> The redirect location for this request. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}