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

namespace Elastic.Clients.Elasticsearch.Serverless.Mapping;

/// <summary>
/// <para>The `geo_shape` data type facilitates the indexing of and searching with arbitrary geo shapes such as rectangles<br/>and polygons.</para>
/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/geo-shape.html">Learn more about this API in the Elasticsearch documentation.</see></para>
/// </summary>
public sealed partial class GeoShapeProperty : IProperty
{
	[JsonInclude, JsonPropertyName("coerce")]
	public bool? Coerce { get; set; }
	[JsonInclude, JsonPropertyName("copy_to")]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? CopyTo { get; set; }
	[JsonInclude, JsonPropertyName("doc_values")]
	public bool? DocValues { get; set; }
	[JsonInclude, JsonPropertyName("dynamic")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? Dynamic { get; set; }
	[JsonInclude, JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? Fields { get; set; }
	[JsonInclude, JsonPropertyName("ignore_above")]
	public int? IgnoreAbove { get; set; }
	[JsonInclude, JsonPropertyName("ignore_malformed")]
	public bool? IgnoreMalformed { get; set; }
	[JsonInclude, JsonPropertyName("ignore_z_value")]
	public bool? IgnoreZValue { get; set; }

	/// <summary>
	/// <para>Metadata about the field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, string>? Meta { get; set; }
	[JsonInclude, JsonPropertyName("orientation")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoOrientation? Orientation { get; set; }
	[JsonInclude, JsonPropertyName("properties")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? Properties { get; set; }
	[JsonInclude, JsonPropertyName("similarity")]
	public string? Similarity { get; set; }
	[JsonInclude, JsonPropertyName("store")]
	public bool? Store { get; set; }
	[JsonInclude, JsonPropertyName("strategy")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoStrategy? Strategy { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "geo_shape";
}

/// <summary>
/// <para>The `geo_shape` data type facilitates the indexing of and searching with arbitrary geo shapes such as rectangles<br/>and polygons.</para>
/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/geo-shape.html">Learn more about this API in the Elasticsearch documentation.</see></para>
/// </summary>
public sealed partial class GeoShapePropertyDescriptor<TDocument> : SerializableDescriptor<GeoShapePropertyDescriptor<TDocument>>, IBuildableDescriptor<GeoShapeProperty>
{
	internal GeoShapePropertyDescriptor(Action<GeoShapePropertyDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoShapePropertyDescriptor() : base()
	{
	}

	private bool? CoerceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? DynamicValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private bool? IgnoreMalformedValue { get; set; }
	private bool? IgnoreZValueValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoOrientation? OrientationValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? PropertiesValue { get; set; }
	private string? SimilarityValue { get; set; }
	private bool? StoreValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoStrategy? StrategyValue { get; set; }

	public GeoShapePropertyDescriptor<TDocument> Coerce(bool? coerce = true)
	{
		CoerceValue = coerce;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Serverless.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Fields(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> IgnoreZValue(bool? ignoreZValue = true)
	{
		IgnoreZValueValue = ignoreZValue;
		return Self;
	}

	/// <summary>
	/// <para>Metadata about the field.</para>
	/// </summary>
	public GeoShapePropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Orientation(Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoOrientation? orientation)
	{
		OrientationValue = orientation;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Properties(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	public GeoShapePropertyDescriptor<TDocument> Strategy(Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoStrategy? strategy)
	{
		StrategyValue = strategy;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CoerceValue.HasValue)
		{
			writer.WritePropertyName("coerce");
			writer.WriteBooleanValue(CoerceValue.Value);
		}

		if (CopyToValue is not null)
		{
			writer.WritePropertyName("copy_to");
			JsonSerializer.Serialize(writer, CopyToValue, options);
		}

		if (DocValuesValue.HasValue)
		{
			writer.WritePropertyName("doc_values");
			writer.WriteBooleanValue(DocValuesValue.Value);
		}

		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (IgnoreMalformedValue.HasValue)
		{
			writer.WritePropertyName("ignore_malformed");
			writer.WriteBooleanValue(IgnoreMalformedValue.Value);
		}

		if (IgnoreZValueValue.HasValue)
		{
			writer.WritePropertyName("ignore_z_value");
			writer.WriteBooleanValue(IgnoreZValueValue.Value);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (OrientationValue is not null)
		{
			writer.WritePropertyName("orientation");
			JsonSerializer.Serialize(writer, OrientationValue, options);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (!string.IsNullOrEmpty(SimilarityValue))
		{
			writer.WritePropertyName("similarity");
			writer.WriteStringValue(SimilarityValue);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		if (StrategyValue is not null)
		{
			writer.WritePropertyName("strategy");
			JsonSerializer.Serialize(writer, StrategyValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("geo_shape");
		writer.WriteEndObject();
	}

	GeoShapeProperty IBuildableDescriptor<GeoShapeProperty>.Build() => new()
	{
		Coerce = CoerceValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		IgnoreMalformed = IgnoreMalformedValue,
		IgnoreZValue = IgnoreZValueValue,
		Meta = MetaValue,
		Orientation = OrientationValue,
		Properties = PropertiesValue,
		Similarity = SimilarityValue,
		Store = StoreValue,
		Strategy = StrategyValue
	};
}

/// <summary>
/// <para>The `geo_shape` data type facilitates the indexing of and searching with arbitrary geo shapes such as rectangles<br/>and polygons.</para>
/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/geo-shape.html">Learn more about this API in the Elasticsearch documentation.</see></para>
/// </summary>
public sealed partial class GeoShapePropertyDescriptor : SerializableDescriptor<GeoShapePropertyDescriptor>, IBuildableDescriptor<GeoShapeProperty>
{
	internal GeoShapePropertyDescriptor(Action<GeoShapePropertyDescriptor> configure) => configure.Invoke(this);

	public GeoShapePropertyDescriptor() : base()
	{
	}

	private bool? CoerceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? DynamicValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private bool? IgnoreMalformedValue { get; set; }
	private bool? IgnoreZValueValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoOrientation? OrientationValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? PropertiesValue { get; set; }
	private string? SimilarityValue { get; set; }
	private bool? StoreValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoStrategy? StrategyValue { get; set; }

	public GeoShapePropertyDescriptor Coerce(bool? coerce = true)
	{
		CoerceValue = coerce;
		return Self;
	}

	public GeoShapePropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Serverless.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public GeoShapePropertyDescriptor DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public GeoShapePropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public GeoShapePropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public GeoShapePropertyDescriptor Fields<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoShapePropertyDescriptor Fields<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoShapePropertyDescriptor IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public GeoShapePropertyDescriptor IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public GeoShapePropertyDescriptor IgnoreZValue(bool? ignoreZValue = true)
	{
		IgnoreZValueValue = ignoreZValue;
		return Self;
	}

	/// <summary>
	/// <para>Metadata about the field.</para>
	/// </summary>
	public GeoShapePropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public GeoShapePropertyDescriptor Orientation(Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoOrientation? orientation)
	{
		OrientationValue = orientation;
		return Self;
	}

	public GeoShapePropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public GeoShapePropertyDescriptor Properties<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoShapePropertyDescriptor Properties<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoShapePropertyDescriptor Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public GeoShapePropertyDescriptor Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	public GeoShapePropertyDescriptor Strategy(Elastic.Clients.Elasticsearch.Serverless.Mapping.GeoStrategy? strategy)
	{
		StrategyValue = strategy;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CoerceValue.HasValue)
		{
			writer.WritePropertyName("coerce");
			writer.WriteBooleanValue(CoerceValue.Value);
		}

		if (CopyToValue is not null)
		{
			writer.WritePropertyName("copy_to");
			JsonSerializer.Serialize(writer, CopyToValue, options);
		}

		if (DocValuesValue.HasValue)
		{
			writer.WritePropertyName("doc_values");
			writer.WriteBooleanValue(DocValuesValue.Value);
		}

		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (IgnoreMalformedValue.HasValue)
		{
			writer.WritePropertyName("ignore_malformed");
			writer.WriteBooleanValue(IgnoreMalformedValue.Value);
		}

		if (IgnoreZValueValue.HasValue)
		{
			writer.WritePropertyName("ignore_z_value");
			writer.WriteBooleanValue(IgnoreZValueValue.Value);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (OrientationValue is not null)
		{
			writer.WritePropertyName("orientation");
			JsonSerializer.Serialize(writer, OrientationValue, options);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (!string.IsNullOrEmpty(SimilarityValue))
		{
			writer.WritePropertyName("similarity");
			writer.WriteStringValue(SimilarityValue);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		if (StrategyValue is not null)
		{
			writer.WritePropertyName("strategy");
			JsonSerializer.Serialize(writer, StrategyValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("geo_shape");
		writer.WriteEndObject();
	}

	GeoShapeProperty IBuildableDescriptor<GeoShapeProperty>.Build() => new()
	{
		Coerce = CoerceValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		IgnoreMalformed = IgnoreMalformedValue,
		IgnoreZValue = IgnoreZValueValue,
		Meta = MetaValue,
		Orientation = OrientationValue,
		Properties = PropertiesValue,
		Similarity = SimilarityValue,
		Store = StoreValue,
		Strategy = StrategyValue
	};
}