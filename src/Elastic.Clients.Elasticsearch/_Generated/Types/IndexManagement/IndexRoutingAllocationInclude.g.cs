// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class IndexRoutingAllocationInclude
	{
		[JsonInclude]
		[JsonPropertyName("_tier_preference")]
		public string? TierPreference { get; set; }

		[JsonInclude]
		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id? Id { get; set; }
	}

	public sealed partial class IndexRoutingAllocationIncludeDescriptor : DescriptorBase<IndexRoutingAllocationIncludeDescriptor>
	{
		public IndexRoutingAllocationIncludeDescriptor()
		{
		}

		internal IndexRoutingAllocationIncludeDescriptor(Action<IndexRoutingAllocationIncludeDescriptor> configure) => configure.Invoke(this);
		internal string? TierPreferenceValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Id? IdValue { get; private set; }

		public IndexRoutingAllocationIncludeDescriptor TierPreference(string? tierPreference) => Assign(tierPreference, (a, v) => a.TierPreferenceValue = v);
		public IndexRoutingAllocationIncludeDescriptor Id(Elastic.Clients.Elasticsearch.Id? id) => Assign(id, (a, v) => a.IdValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(TierPreferenceValue))
			{
				writer.WritePropertyName("_tier_preference");
				writer.WriteStringValue(TierPreferenceValue);
			}

			if (IdValue is not null)
			{
				writer.WritePropertyName("_id");
				JsonSerializer.Serialize(writer, IdValue, options);
			}

			writer.WriteEndObject();
		}
	}
}