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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Aggregations;

public sealed partial class GeohashGridAggregation
{
	/// <summary>
	/// <para>The bounding box to filter the points in each bucket.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("bounds")]
	public Elastic.Clients.Elasticsearch.GeoBounds? Bounds { get; set; }

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, object>? Meta { get; set; }
	[JsonInclude, JsonPropertyName("name")]
	public string? Name { get; set; }

	/// <summary>
	/// <para>The string length of the geohashes used to define cells/buckets in the results.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("precision")]
	public Elastic.Clients.Elasticsearch.GeohashPrecision? Precision { get; set; }

	/// <summary>
	/// <para>Allows for more accurate counting of the top cells returned in the final result the aggregation.<br/>Defaults to returning `max(10,(size x number-of-shards))` buckets from each shard.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("shard_size")]
	public int? ShardSize { get; set; }

	/// <summary>
	/// <para>The maximum number of geohash buckets to return.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("size")]
	public int? Size { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(GeohashGridAggregation geohashGridAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.GeohashGrid(geohashGridAggregation);
}

public sealed partial class GeohashGridAggregationDescriptor<TDocument> : SerializableDescriptor<GeohashGridAggregationDescriptor<TDocument>>
{
	internal GeohashGridAggregationDescriptor(Action<GeohashGridAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeohashGridAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.GeoBounds? BoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private string? NameValue { get; set; }
	private Elastic.Clients.Elasticsearch.GeohashPrecision? PrecisionValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private int? SizeValue { get; set; }

	/// <summary>
	/// <para>The bounding box to filter the points in each bucket.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Bounds(Elastic.Clients.Elasticsearch.GeoBounds? bounds)
	{
		BoundsValue = bounds;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeohashGridAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public GeohashGridAggregationDescriptor<TDocument> Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>The string length of the geohashes used to define cells/buckets in the results.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Precision(Elastic.Clients.Elasticsearch.GeohashPrecision? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	/// <summary>
	/// <para>Allows for more accurate counting of the top cells returned in the final result the aggregation.<br/>Defaults to returning `max(10,(size x number-of-shards))` buckets from each shard.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of geohash buckets to return.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoundsValue is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, BoundsValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		if (PrecisionValue is not null)
		{
			writer.WritePropertyName("precision");
			JsonSerializer.Serialize(writer, PrecisionValue, options);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeohashGridAggregationDescriptor : SerializableDescriptor<GeohashGridAggregationDescriptor>
{
	internal GeohashGridAggregationDescriptor(Action<GeohashGridAggregationDescriptor> configure) => configure.Invoke(this);

	public GeohashGridAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.GeoBounds? BoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private string? NameValue { get; set; }
	private Elastic.Clients.Elasticsearch.GeohashPrecision? PrecisionValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private int? SizeValue { get; set; }

	/// <summary>
	/// <para>The bounding box to filter the points in each bucket.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Bounds(Elastic.Clients.Elasticsearch.GeoBounds? bounds)
	{
		BoundsValue = bounds;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeohashGridAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public GeohashGridAggregationDescriptor Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>The string length of the geohashes used to define cells/buckets in the results.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Precision(Elastic.Clients.Elasticsearch.GeohashPrecision? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	/// <summary>
	/// <para>Allows for more accurate counting of the top cells returned in the final result the aggregation.<br/>Defaults to returning `max(10,(size x number-of-shards))` buckets from each shard.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of geohash buckets to return.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoundsValue is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, BoundsValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		if (PrecisionValue is not null)
		{
			writer.WritePropertyName("precision");
			JsonSerializer.Serialize(writer, PrecisionValue, options);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
	}
}