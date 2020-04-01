// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class DotFishMarket
    {
        internal static DotFishMarket DeserializeDotFishMarket(JsonElement element)
        {
            DotSalmon sampleSalmon = default;
            IReadOnlyList<DotSalmon> salmons = default;
            DotFish sampleFish = default;
            IReadOnlyList<DotFish> fishes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sampleSalmon"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sampleSalmon = DotSalmon.DeserializeDotSalmon(property.Value);
                    continue;
                }
                if (property.NameEquals("salmons"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DotSalmon> array = new List<DotSalmon>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DotSalmon.DeserializeDotSalmon(item));
                        }
                    }
                    salmons = array;
                    continue;
                }
                if (property.NameEquals("sampleFish"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sampleFish = DotFish.DeserializeDotFish(property.Value);
                    continue;
                }
                if (property.NameEquals("fishes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DotFish> array = new List<DotFish>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DotFish.DeserializeDotFish(item));
                        }
                    }
                    fishes = array;
                    continue;
                }
            }
            return new DotFishMarket(sampleSalmon, salmons, sampleFish, fishes);
        }
    }
}
