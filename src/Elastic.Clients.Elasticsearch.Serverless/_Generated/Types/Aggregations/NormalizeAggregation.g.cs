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

#nullable restore

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

public sealed partial class NormalizeAggregation
{
	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("buckets_path")]
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.BucketsPath? BucketsPath { get; set; }

	/// <summary>
	/// <para>`DecimalFormat` pattern for the output value.<br/>If specified, the formatted value is returned in the aggregation’s `value_as_string` property.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	/// <summary>
	/// <para>Policy to apply when gaps are found in the data.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("gap_policy")]
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? GapPolicy { get; set; }
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, object>? Meta { get; set; }

	/// <summary>
	/// <para>The specific method to apply.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("method")]
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.NormalizeMethod? Method { get; set; }
	[JsonInclude, JsonPropertyName("name")]
	public string? Name { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation(NormalizeAggregation normalizeAggregation) => Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation.Normalize(normalizeAggregation);
}

public sealed partial class NormalizeAggregationDescriptor : SerializableDescriptor<NormalizeAggregationDescriptor>
{
	internal NormalizeAggregationDescriptor(Action<NormalizeAggregationDescriptor> configure) => configure.Invoke(this);

	public NormalizeAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.BucketsPath? BucketsPathValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? GapPolicyValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.NormalizeMethod? MethodValue { get; set; }
	private string? NameValue { get; set; }

	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	public NormalizeAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Serverless.Aggregations.BucketsPath? bucketsPath)
	{
		BucketsPathValue = bucketsPath;
		return Self;
	}

	/// <summary>
	/// <para>`DecimalFormat` pattern for the output value.<br/>If specified, the formatted value is returned in the aggregation’s `value_as_string` property.</para>
	/// </summary>
	public NormalizeAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Policy to apply when gaps are found in the data.</para>
	/// </summary>
	public NormalizeAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? gapPolicy)
	{
		GapPolicyValue = gapPolicy;
		return Self;
	}

	public NormalizeAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The specific method to apply.</para>
	/// </summary>
	public NormalizeAggregationDescriptor Method(Elastic.Clients.Elasticsearch.Serverless.Aggregations.NormalizeMethod? method)
	{
		MethodValue = method;
		return Self;
	}

	public NormalizeAggregationDescriptor Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BucketsPathValue is not null)
		{
			writer.WritePropertyName("buckets_path");
			JsonSerializer.Serialize(writer, BucketsPathValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (GapPolicyValue is not null)
		{
			writer.WritePropertyName("gap_policy");
			JsonSerializer.Serialize(writer, GapPolicyValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (MethodValue is not null)
		{
			writer.WritePropertyName("method");
			JsonSerializer.Serialize(writer, MethodValue, options);
		}

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		writer.WriteEndObject();
	}
}