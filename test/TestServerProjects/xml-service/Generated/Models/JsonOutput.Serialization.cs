// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace xml_service.Models
{
    public partial class JsonOutput
    {
        internal static JsonOutput DeserializeJsonOutput(JsonElement element)
        {
            int? id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt32();
                    continue;
                }
            }
            return new JsonOutput(id);
        }
    }
}
