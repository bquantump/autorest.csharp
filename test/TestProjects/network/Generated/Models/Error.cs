// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace network.Models
{
    /// <summary> Common error representation. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
            Details = new ChangeTrackingList<ErrorDetails>();
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Error target. </summary>
        public string Target { get; }
        /// <summary> Error details. </summary>
        public IReadOnlyList<ErrorDetails> Details { get; }
        /// <summary> Inner error message. </summary>
        public string InnerError { get; }
    }
}
