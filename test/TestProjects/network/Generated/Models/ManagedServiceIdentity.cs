// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace network.Models
{
    /// <summary> Identity for the resource. </summary>
    internal partial class ManagedServiceIdentity
    {
        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        internal ManagedServiceIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, Components1Jq1T4ISchemasManagedserviceidentityPropertiesUserassignedidentitiesAdditionalproperties>();
        }

        /// <summary> The principal id of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant id of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public string TenantId { get; }
        /// <summary> The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual machine. </summary>
        public ResourceIdentityType? Type { get; }
        /// <summary> The list of user identities associated with resource. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </summary>
        public IReadOnlyDictionary<string, Components1Jq1T4ISchemasManagedserviceidentityPropertiesUserassignedidentitiesAdditionalproperties> UserAssignedIdentities { get; }
    }
}
