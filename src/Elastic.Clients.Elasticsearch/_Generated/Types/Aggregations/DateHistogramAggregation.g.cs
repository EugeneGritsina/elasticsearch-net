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

public sealed partial class DateHistogramAggregation
{
	/// <summary>
	/// <para>Calendar-aware interval.<br/>Can be specified using the unit name, such as `month`, or as a single unit quantity, such as `1M`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("calendar_interval")]
	public Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? CalendarInterval { get; set; }

	/// <summary>
	/// <para>Enables extending the bounds of the histogram beyond the data itself.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("extended_bounds")]
	public Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? ExtendedBounds { get; set; }

	/// <summary>
	/// <para>The date field whose values are use to build a histogram.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	/// <summary>
	/// <para>Fixed intervals: a fixed number of SI units and never deviate, regardless of where they fall on the calendar.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fixed_interval")]
	public Elastic.Clients.Elasticsearch.Duration? FixedInterval { get; set; }

	/// <summary>
	/// <para>The date format used to format `key_as_string` in the response.<br/>If no `format` is specified, the first date format specified in the field mapping is used.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	/// <summary>
	/// <para>Limits the histogram to specified bounds.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("hard_bounds")]
	public Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? HardBounds { get; set; }

	/// <summary>
	/// <para>Only returns buckets that have `min_doc_count` number of documents.<br/>By default, all buckets between the first bucket that matches documents and the last one are returned.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("min_doc_count")]
	public int? MinDocCount { get; set; }

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("missing")]
	public DateTimeOffset? Missing { get; set; }

	/// <summary>
	/// <para>Changes the start value of each bucket by the specified positive (`+`) or negative offset (`-`) duration.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("offset")]
	public Elastic.Clients.Elasticsearch.Duration? Offset { get; set; }

	/// <summary>
	/// <para>The sort order of the returned buckets.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("order")]
	[SingleOrManyCollectionConverter(typeof(KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>))]
	public ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? Order { get; set; }
	[JsonInclude, JsonPropertyName("params")]
	public IDictionary<string, object>? Params { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	/// <summary>
	/// <para>Time zone used for bucketing and rounding.<br/>Defaults to Coordinated Universal Time (UTC).</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_zone")]
	public string? TimeZone { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(DateHistogramAggregation dateHistogramAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.DateHistogram(dateHistogramAggregation);
	public static implicit operator Elastic.Clients.Elasticsearch.TransformManagement.PivotGroupBy(DateHistogramAggregation dateHistogramAggregation) => Elastic.Clients.Elasticsearch.TransformManagement.PivotGroupBy.DateHistogram(dateHistogramAggregation);
}

public sealed partial class DateHistogramAggregationDescriptor<TDocument> : SerializableDescriptor<DateHistogramAggregationDescriptor<TDocument>>
{
	internal DateHistogramAggregationDescriptor(Action<DateHistogramAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DateHistogramAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? CalendarIntervalValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? ExtendedBoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor ExtendedBoundsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor> ExtendedBoundsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? FixedIntervalValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? HardBoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor HardBoundsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor> HardBoundsDescriptorAction { get; set; }
	private int? MinDocCountValue { get; set; }
	private DateTimeOffset? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? OffsetValue { get; set; }
	private ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? OrderValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private string? TimeZoneValue { get; set; }

	/// <summary>
	/// <para>Calendar-aware interval.<br/>Can be specified using the unit name, such as `month`, or as a single unit quantity, such as `1M`.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> CalendarInterval(Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? calendarInterval)
	{
		CalendarIntervalValue = calendarInterval;
		return Self;
	}

	/// <summary>
	/// <para>Enables extending the bounds of the histogram beyond the data itself.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> ExtendedBounds(Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? extendedBounds)
	{
		ExtendedBoundsDescriptor = null;
		ExtendedBoundsDescriptorAction = null;
		ExtendedBoundsValue = extendedBounds;
		return Self;
	}

	public DateHistogramAggregationDescriptor<TDocument> ExtendedBounds(Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor descriptor)
	{
		ExtendedBoundsValue = null;
		ExtendedBoundsDescriptorAction = null;
		ExtendedBoundsDescriptor = descriptor;
		return Self;
	}

	public DateHistogramAggregationDescriptor<TDocument> ExtendedBounds(Action<Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor> configure)
	{
		ExtendedBoundsValue = null;
		ExtendedBoundsDescriptor = null;
		ExtendedBoundsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The date field whose values are use to build a histogram.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date field whose values are use to build a histogram.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date field whose values are use to build a histogram.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Fixed intervals: a fixed number of SI units and never deviate, regardless of where they fall on the calendar.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> FixedInterval(Elastic.Clients.Elasticsearch.Duration? fixedInterval)
	{
		FixedIntervalValue = fixedInterval;
		return Self;
	}

	/// <summary>
	/// <para>The date format used to format `key_as_string` in the response.<br/>If no `format` is specified, the first date format specified in the field mapping is used.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Limits the histogram to specified bounds.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> HardBounds(Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? hardBounds)
	{
		HardBoundsDescriptor = null;
		HardBoundsDescriptorAction = null;
		HardBoundsValue = hardBounds;
		return Self;
	}

	public DateHistogramAggregationDescriptor<TDocument> HardBounds(Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor descriptor)
	{
		HardBoundsValue = null;
		HardBoundsDescriptorAction = null;
		HardBoundsDescriptor = descriptor;
		return Self;
	}

	public DateHistogramAggregationDescriptor<TDocument> HardBounds(Action<Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor> configure)
	{
		HardBoundsValue = null;
		HardBoundsDescriptor = null;
		HardBoundsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Only returns buckets that have `min_doc_count` number of documents.<br/>By default, all buckets between the first bucket that matches documents and the last one are returned.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> MinDocCount(int? minDocCount)
	{
		MinDocCountValue = minDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> Missing(DateTimeOffset? missing)
	{
		MissingValue = missing;
		return Self;
	}

	/// <summary>
	/// <para>Changes the start value of each bucket by the specified positive (`+`) or negative offset (`-`) duration.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> Offset(Elastic.Clients.Elasticsearch.Duration? offset)
	{
		OffsetValue = offset;
		return Self;
	}

	/// <summary>
	/// <para>The sort order of the returned buckets.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> Order(ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	public DateHistogramAggregationDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public DateHistogramAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Time zone used for bucketing and rounding.<br/>Defaults to Coordinated Universal Time (UTC).</para>
	/// </summary>
	public DateHistogramAggregationDescriptor<TDocument> TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CalendarIntervalValue is not null)
		{
			writer.WritePropertyName("calendar_interval");
			JsonSerializer.Serialize(writer, CalendarIntervalValue, options);
		}

		if (ExtendedBoundsDescriptor is not null)
		{
			writer.WritePropertyName("extended_bounds");
			JsonSerializer.Serialize(writer, ExtendedBoundsDescriptor, options);
		}
		else if (ExtendedBoundsDescriptorAction is not null)
		{
			writer.WritePropertyName("extended_bounds");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor(ExtendedBoundsDescriptorAction), options);
		}
		else if (ExtendedBoundsValue is not null)
		{
			writer.WritePropertyName("extended_bounds");
			JsonSerializer.Serialize(writer, ExtendedBoundsValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (FixedIntervalValue is not null)
		{
			writer.WritePropertyName("fixed_interval");
			JsonSerializer.Serialize(writer, FixedIntervalValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (HardBoundsDescriptor is not null)
		{
			writer.WritePropertyName("hard_bounds");
			JsonSerializer.Serialize(writer, HardBoundsDescriptor, options);
		}
		else if (HardBoundsDescriptorAction is not null)
		{
			writer.WritePropertyName("hard_bounds");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor(HardBoundsDescriptorAction), options);
		}
		else if (HardBoundsValue is not null)
		{
			writer.WritePropertyName("hard_bounds");
			JsonSerializer.Serialize(writer, HardBoundsValue, options);
		}

		if (MinDocCountValue.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(MinDocCountValue.Value);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (OffsetValue is not null)
		{
			writer.WritePropertyName("offset");
			JsonSerializer.Serialize(writer, OffsetValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>(OrderValue, writer, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DateHistogramAggregationDescriptor : SerializableDescriptor<DateHistogramAggregationDescriptor>
{
	internal DateHistogramAggregationDescriptor(Action<DateHistogramAggregationDescriptor> configure) => configure.Invoke(this);

	public DateHistogramAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? CalendarIntervalValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? ExtendedBoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor ExtendedBoundsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor> ExtendedBoundsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? FixedIntervalValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? HardBoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor HardBoundsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor> HardBoundsDescriptorAction { get; set; }
	private int? MinDocCountValue { get; set; }
	private DateTimeOffset? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? OffsetValue { get; set; }
	private ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? OrderValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private string? TimeZoneValue { get; set; }

	/// <summary>
	/// <para>Calendar-aware interval.<br/>Can be specified using the unit name, such as `month`, or as a single unit quantity, such as `1M`.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor CalendarInterval(Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? calendarInterval)
	{
		CalendarIntervalValue = calendarInterval;
		return Self;
	}

	/// <summary>
	/// <para>Enables extending the bounds of the histogram beyond the data itself.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor ExtendedBounds(Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? extendedBounds)
	{
		ExtendedBoundsDescriptor = null;
		ExtendedBoundsDescriptorAction = null;
		ExtendedBoundsValue = extendedBounds;
		return Self;
	}

	public DateHistogramAggregationDescriptor ExtendedBounds(Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor descriptor)
	{
		ExtendedBoundsValue = null;
		ExtendedBoundsDescriptorAction = null;
		ExtendedBoundsDescriptor = descriptor;
		return Self;
	}

	public DateHistogramAggregationDescriptor ExtendedBounds(Action<Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor> configure)
	{
		ExtendedBoundsValue = null;
		ExtendedBoundsDescriptor = null;
		ExtendedBoundsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The date field whose values are use to build a histogram.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date field whose values are use to build a histogram.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date field whose values are use to build a histogram.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Fixed intervals: a fixed number of SI units and never deviate, regardless of where they fall on the calendar.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor FixedInterval(Elastic.Clients.Elasticsearch.Duration? fixedInterval)
	{
		FixedIntervalValue = fixedInterval;
		return Self;
	}

	/// <summary>
	/// <para>The date format used to format `key_as_string` in the response.<br/>If no `format` is specified, the first date format specified in the field mapping is used.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Limits the histogram to specified bounds.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor HardBounds(Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDate? hardBounds)
	{
		HardBoundsDescriptor = null;
		HardBoundsDescriptorAction = null;
		HardBoundsValue = hardBounds;
		return Self;
	}

	public DateHistogramAggregationDescriptor HardBounds(Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor descriptor)
	{
		HardBoundsValue = null;
		HardBoundsDescriptorAction = null;
		HardBoundsDescriptor = descriptor;
		return Self;
	}

	public DateHistogramAggregationDescriptor HardBounds(Action<Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor> configure)
	{
		HardBoundsValue = null;
		HardBoundsDescriptor = null;
		HardBoundsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Only returns buckets that have `min_doc_count` number of documents.<br/>By default, all buckets between the first bucket that matches documents and the last one are returned.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor MinDocCount(int? minDocCount)
	{
		MinDocCountValue = minDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor Missing(DateTimeOffset? missing)
	{
		MissingValue = missing;
		return Self;
	}

	/// <summary>
	/// <para>Changes the start value of each bucket by the specified positive (`+`) or negative offset (`-`) duration.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor Offset(Elastic.Clients.Elasticsearch.Duration? offset)
	{
		OffsetValue = offset;
		return Self;
	}

	/// <summary>
	/// <para>The sort order of the returned buckets.</para>
	/// </summary>
	public DateHistogramAggregationDescriptor Order(ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	public DateHistogramAggregationDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public DateHistogramAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Time zone used for bucketing and rounding.<br/>Defaults to Coordinated Universal Time (UTC).</para>
	/// </summary>
	public DateHistogramAggregationDescriptor TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CalendarIntervalValue is not null)
		{
			writer.WritePropertyName("calendar_interval");
			JsonSerializer.Serialize(writer, CalendarIntervalValue, options);
		}

		if (ExtendedBoundsDescriptor is not null)
		{
			writer.WritePropertyName("extended_bounds");
			JsonSerializer.Serialize(writer, ExtendedBoundsDescriptor, options);
		}
		else if (ExtendedBoundsDescriptorAction is not null)
		{
			writer.WritePropertyName("extended_bounds");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor(ExtendedBoundsDescriptorAction), options);
		}
		else if (ExtendedBoundsValue is not null)
		{
			writer.WritePropertyName("extended_bounds");
			JsonSerializer.Serialize(writer, ExtendedBoundsValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (FixedIntervalValue is not null)
		{
			writer.WritePropertyName("fixed_interval");
			JsonSerializer.Serialize(writer, FixedIntervalValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (HardBoundsDescriptor is not null)
		{
			writer.WritePropertyName("hard_bounds");
			JsonSerializer.Serialize(writer, HardBoundsDescriptor, options);
		}
		else if (HardBoundsDescriptorAction is not null)
		{
			writer.WritePropertyName("hard_bounds");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.ExtendedBoundsDateDescriptor(HardBoundsDescriptorAction), options);
		}
		else if (HardBoundsValue is not null)
		{
			writer.WritePropertyName("hard_bounds");
			JsonSerializer.Serialize(writer, HardBoundsValue, options);
		}

		if (MinDocCountValue.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(MinDocCountValue.Value);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (OffsetValue is not null)
		{
			writer.WritePropertyName("offset");
			JsonSerializer.Serialize(writer, OffsetValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>(OrderValue, writer, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		writer.WriteEndObject();
	}
}