// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class PatternAnalyzer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (LowerCaseTerms != null)
            {
                writer.WritePropertyName("lowercase");
                writer.WriteBooleanValue(LowerCaseTerms.Value);
            }
            if (Pattern != null)
            {
                writer.WritePropertyName("pattern");
                writer.WriteStringValue(Pattern);
            }
            if (Flags != null)
            {
                writer.WritePropertyName("flags");
                writer.WriteStringValue(Flags.Value.ToString());
            }
            if (Stopwords != null)
            {
                writer.WritePropertyName("stopwords");
                writer.WriteStartArray();
                foreach (var item in Stopwords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static PatternAnalyzer DeserializePatternAnalyzer(JsonElement element)
        {
            bool? lowercase = default;
            string pattern = default;
            RegexFlags? flags = default;
            IList<string> stopwords = default;
            string odatatype = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lowercase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lowercase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("pattern"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("flags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    flags = new RegexFlags(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stopwords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    stopwords = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odatatype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new PatternAnalyzer(odatatype, name, lowercase, pattern, flags, stopwords);
        }
    }
}
