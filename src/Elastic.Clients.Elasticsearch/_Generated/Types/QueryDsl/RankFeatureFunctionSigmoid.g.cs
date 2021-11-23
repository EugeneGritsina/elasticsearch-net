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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class RankFeatureFunctionSigmoid : QueryDsl.RankFeatureFunction
	{
		[JsonInclude]
		[JsonPropertyName("pivot")]
		public float Pivot { get; set; }

		[JsonInclude]
		[JsonPropertyName("exponent")]
		public float Exponent { get; set; }
	}

	public sealed partial class RankFeatureFunctionSigmoidDescriptor : DescriptorBase<RankFeatureFunctionSigmoidDescriptor>
	{
		public RankFeatureFunctionSigmoidDescriptor()
		{
		}

		internal RankFeatureFunctionSigmoidDescriptor(Action<RankFeatureFunctionSigmoidDescriptor> configure) => configure.Invoke(this);
		internal float PivotValue { get; private set; }

		internal float ExponentValue { get; private set; }

		public RankFeatureFunctionSigmoidDescriptor Pivot(float pivot) => Assign(pivot, (a, v) => a.PivotValue = v);
		public RankFeatureFunctionSigmoidDescriptor Exponent(float exponent) => Assign(exponent, (a, v) => a.ExponentValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("pivot");
			writer.WriteNumberValue(PivotValue);
			writer.WritePropertyName("exponent");
			writer.WriteNumberValue(ExponentValue);
			writer.WriteEndObject();
		}
	}
}