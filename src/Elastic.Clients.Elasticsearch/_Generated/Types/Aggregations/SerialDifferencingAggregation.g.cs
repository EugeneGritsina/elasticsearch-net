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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class SerialDifferencingAggregation : Aggregations.PipelineAggregationBase, IAggregationContainerVariant
	{
		public SerialDifferencingAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "serial_diff";
		[JsonInclude]
		[JsonPropertyName("lag")]
		public int? Lag { get; set; }
	}

	public sealed partial class SerialDifferencingAggregationDescriptor : DescriptorBase<SerialDifferencingAggregationDescriptor>
	{
		public SerialDifferencingAggregationDescriptor()
		{
		}

		internal SerialDifferencingAggregationDescriptor(Action<SerialDifferencingAggregationDescriptor> configure) => configure.Invoke(this);
		internal int? LagValue { get; private set; }

		public SerialDifferencingAggregationDescriptor Lag(int? lag) => Assign(lag, (a, v) => a.LagValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (LagValue.HasValue)
			{
				writer.WritePropertyName("lag");
				writer.WriteNumberValue(LagValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}