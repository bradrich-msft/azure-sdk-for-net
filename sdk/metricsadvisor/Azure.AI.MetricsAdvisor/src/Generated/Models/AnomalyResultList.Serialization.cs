// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AnomalyResultList
    {
        internal static AnomalyResultList DeserializeAnomalyResultList(JsonElement element)
        {
            string nextLink = default;
            IReadOnlyList<DataAnomaly> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<DataAnomaly> array = new List<DataAnomaly>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataAnomaly.DeserializeDataAnomaly(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AnomalyResultList(nextLink, value);
        }
    }
}
