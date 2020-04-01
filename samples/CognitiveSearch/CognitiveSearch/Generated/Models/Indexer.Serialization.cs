// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Indexer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("dataSourceName");
            writer.WriteStringValue(DataSourceName);
            if (SkillsetName != null)
            {
                writer.WritePropertyName("skillsetName");
                writer.WriteStringValue(SkillsetName);
            }
            writer.WritePropertyName("targetIndexName");
            writer.WriteStringValue(TargetIndexName);
            if (Schedule != null)
            {
                writer.WritePropertyName("schedule");
                writer.WriteObjectValue(Schedule);
            }
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            if (FieldMappings != null)
            {
                writer.WritePropertyName("fieldMappings");
                writer.WriteStartArray();
                foreach (var item in FieldMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OutputFieldMappings != null)
            {
                writer.WritePropertyName("outputFieldMappings");
                writer.WriteStartArray();
                foreach (var item in OutputFieldMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsDisabled != null)
            {
                writer.WritePropertyName("disabled");
                writer.WriteBooleanValue(IsDisabled.Value);
            }
            if (ETag != null)
            {
                writer.WritePropertyName("@odata.etag");
                writer.WriteStringValue(ETag);
            }
            writer.WriteEndObject();
        }

        internal static Indexer DeserializeIndexer(JsonElement element)
        {
            string name = default;
            string description = default;
            string dataSourceName = default;
            string skillsetName = default;
            string targetIndexName = default;
            IndexingSchedule schedule = default;
            IndexingParameters parameters = default;
            IList<FieldMapping> fieldMappings = default;
            IList<FieldMapping> outputFieldMappings = default;
            bool? disabled = default;
            string odataetag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceName"))
                {
                    dataSourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skillsetName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skillsetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetIndexName"))
                {
                    targetIndexName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schedule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedule = IndexingSchedule.DeserializeIndexingSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = IndexingParameters.DeserializeIndexingParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("fieldMappings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldMapping> array = new List<FieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(FieldMapping.DeserializeFieldMapping(item));
                        }
                    }
                    fieldMappings = array;
                    continue;
                }
                if (property.NameEquals("outputFieldMappings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldMapping> array = new List<FieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(FieldMapping.DeserializeFieldMapping(item));
                        }
                    }
                    outputFieldMappings = array;
                    continue;
                }
                if (property.NameEquals("disabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataetag = property.Value.GetString();
                    continue;
                }
            }
            return new Indexer(name, description, dataSourceName, skillsetName, targetIndexName, schedule, parameters, fieldMappings, outputFieldMappings, disabled, odataetag);
        }
    }
}
