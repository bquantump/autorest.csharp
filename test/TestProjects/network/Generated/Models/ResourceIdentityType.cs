// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace network.Models
{
    /// <summary> The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual machine. </summary>
    internal enum ResourceIdentityType
    {
        /// <summary> SystemAssigned. </summary>
        SystemAssigned,
        /// <summary> UserAssigned. </summary>
        UserAssigned,
        /// <summary> SystemAssigned, UserAssigned. </summary>
        SystemAssignedUserAssigned,
        /// <summary> None. </summary>
        None
    }
}