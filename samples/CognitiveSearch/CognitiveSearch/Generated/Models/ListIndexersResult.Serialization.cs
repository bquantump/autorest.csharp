// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ListIndexersResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Indexers != null)
            {
                writer.WritePropertyName("value");
                writer.WriteStartArray();
                foreach (var item in Indexers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static ListIndexersResult DeserializeListIndexersResult(JsonElement element)
        {
            ListIndexersResult result = new ListIndexersResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Indexers = new List<Indexer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Indexers.Add(Indexer.DeserializeIndexer(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}