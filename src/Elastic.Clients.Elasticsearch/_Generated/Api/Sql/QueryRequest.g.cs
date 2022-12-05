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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Sql;
public sealed class QueryRequestParameters : RequestParameters
{
}

public sealed partial class QueryRequest : PlainRequest<QueryRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlQuery;
	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	[JsonInclude]
	[JsonPropertyName("catalog")]
	public string? Catalog { get; set; }

	[JsonInclude]
	[JsonPropertyName("columnar")]
	public bool? Columnar { get; set; }

	[JsonInclude]
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; }

	[JsonInclude]
	[JsonPropertyName("fetch_size")]
	public int? FetchSize { get; set; }

	[JsonInclude]
	[JsonPropertyName("filter")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Filter { get; set; }

	[JsonInclude]
	[JsonPropertyName("query")]
	public string? Query { get; set; }

	[JsonInclude]
	[JsonPropertyName("request_timeout")]
	public Elastic.Clients.Elasticsearch.Duration? RequestTimeout { get; set; }

	[JsonInclude]
	[JsonPropertyName("page_timeout")]
	public Elastic.Clients.Elasticsearch.Duration? PageTimeout { get; set; }

	[JsonInclude]
	[JsonPropertyName("time_zone")]
	public string? TimeZone { get; set; }

	[JsonInclude]
	[JsonPropertyName("field_multi_value_leniency")]
	public bool? FieldMultiValueLeniency { get; set; }

	[JsonInclude]
	[JsonPropertyName("runtime_mappings")]
	public Dictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappings { get; set; }

	[JsonInclude]
	[JsonPropertyName("wait_for_completion_timeout")]
	public Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeout { get; set; }

	[JsonInclude]
	[JsonPropertyName("params")]
	public Dictionary<string, object>? Params { get; set; }

	[JsonInclude]
	[JsonPropertyName("keep_alive")]
	public Elastic.Clients.Elasticsearch.Duration? KeepAlive { get; set; }

	[JsonInclude]
	[JsonPropertyName("keep_on_completion")]
	public bool? KeepOnCompletion { get; set; }

	[JsonInclude]
	[JsonPropertyName("index_using_frozen")]
	public bool? IndexUsingFrozen { get; set; }
}

public sealed partial class QueryRequestDescriptor<TDocument> : RequestDescriptor<QueryRequestDescriptor<TDocument>, QueryRequestParameters>
{
	internal QueryRequestDescriptor(Action<QueryRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public QueryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlQuery;
	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? FilterValue { get; set; }

	private QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }

	private string? CatalogValue { get; set; }

	private bool? ColumnarValue { get; set; }

	private string? CursorValue { get; set; }

	private int? FetchSizeValue { get; set; }

	private bool? FieldMultiValueLeniencyValue { get; set; }

	private bool? IndexUsingFrozenValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? KeepAliveValue { get; set; }

	private bool? KeepOnCompletionValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? PageTimeoutValue { get; set; }

	private Dictionary<string, object>? ParamsValue { get; set; }

	private string? QueryValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? RequestTimeoutValue { get; set; }

	private Dictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappingsValue { get; set; }

	private string? TimeZoneValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeoutValue { get; set; }

	public QueryRequestDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> Filter(QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> Filter(Action<QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> Catalog(string? catalog)
	{
		CatalogValue = catalog;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> Columnar(bool? columnar = true)
	{
		ColumnarValue = columnar;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> Cursor(string? cursor)
	{
		CursorValue = cursor;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> FetchSize(int? fetchSize)
	{
		FetchSizeValue = fetchSize;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> FieldMultiValueLeniency(bool? fieldMultiValueLeniency = true)
	{
		FieldMultiValueLeniencyValue = fieldMultiValueLeniency;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> IndexUsingFrozen(bool? indexUsingFrozen = true)
	{
		IndexUsingFrozenValue = indexUsingFrozen;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> KeepAlive(Elastic.Clients.Elasticsearch.Duration? keepAlive)
	{
		KeepAliveValue = keepAlive;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> KeepOnCompletion(bool? keepOnCompletion = true)
	{
		KeepOnCompletionValue = keepOnCompletion;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> PageTimeout(Elastic.Clients.Elasticsearch.Duration? pageTimeout)
	{
		PageTimeoutValue = pageTimeout;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public QueryRequestDescriptor<TDocument> Query(string? query)
	{
		QueryValue = query;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> RequestTimeout(Elastic.Clients.Elasticsearch.Duration? requestTimeout)
	{
		RequestTimeoutValue = requestTimeout;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>());
		return Self;
	}

	public QueryRequestDescriptor<TDocument> TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	public QueryRequestDescriptor<TDocument> WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Duration? waitForCompletionTimeout)
	{
		WaitForCompletionTimeoutValue = waitForCompletionTimeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (!string.IsNullOrEmpty(CatalogValue))
		{
			writer.WritePropertyName("catalog");
			writer.WriteStringValue(CatalogValue);
		}

		if (ColumnarValue.HasValue)
		{
			writer.WritePropertyName("columnar");
			writer.WriteBooleanValue(ColumnarValue.Value);
		}

		if (!string.IsNullOrEmpty(CursorValue))
		{
			writer.WritePropertyName("cursor");
			writer.WriteStringValue(CursorValue);
		}

		if (FetchSizeValue.HasValue)
		{
			writer.WritePropertyName("fetch_size");
			writer.WriteNumberValue(FetchSizeValue.Value);
		}

		if (FieldMultiValueLeniencyValue.HasValue)
		{
			writer.WritePropertyName("field_multi_value_leniency");
			writer.WriteBooleanValue(FieldMultiValueLeniencyValue.Value);
		}

		if (IndexUsingFrozenValue.HasValue)
		{
			writer.WritePropertyName("index_using_frozen");
			writer.WriteBooleanValue(IndexUsingFrozenValue.Value);
		}

		if (KeepAliveValue is not null)
		{
			writer.WritePropertyName("keep_alive");
			JsonSerializer.Serialize(writer, KeepAliveValue, options);
		}

		if (KeepOnCompletionValue.HasValue)
		{
			writer.WritePropertyName("keep_on_completion");
			writer.WriteBooleanValue(KeepOnCompletionValue.Value);
		}

		if (PageTimeoutValue is not null)
		{
			writer.WritePropertyName("page_timeout");
			JsonSerializer.Serialize(writer, PageTimeoutValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (!string.IsNullOrEmpty(QueryValue))
		{
			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
		}

		if (RequestTimeoutValue is not null)
		{
			writer.WritePropertyName("request_timeout");
			JsonSerializer.Serialize(writer, RequestTimeoutValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		if (TimeZoneValue is not null)
		{
			writer.WritePropertyName("time_zone");
			JsonSerializer.Serialize(writer, TimeZoneValue, options);
		}

		if (WaitForCompletionTimeoutValue is not null)
		{
			writer.WritePropertyName("wait_for_completion_timeout");
			JsonSerializer.Serialize(writer, WaitForCompletionTimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class QueryRequestDescriptor : RequestDescriptor<QueryRequestDescriptor, QueryRequestParameters>
{
	internal QueryRequestDescriptor(Action<QueryRequestDescriptor> configure) => configure.Invoke(this);
	public QueryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlQuery;
	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? FilterValue { get; set; }

	private QueryDsl.QueryDescriptor FilterDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }

	private string? CatalogValue { get; set; }

	private bool? ColumnarValue { get; set; }

	private string? CursorValue { get; set; }

	private int? FetchSizeValue { get; set; }

	private bool? FieldMultiValueLeniencyValue { get; set; }

	private bool? IndexUsingFrozenValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? KeepAliveValue { get; set; }

	private bool? KeepOnCompletionValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? PageTimeoutValue { get; set; }

	private Dictionary<string, object>? ParamsValue { get; set; }

	private string? QueryValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? RequestTimeoutValue { get; set; }

	private Dictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappingsValue { get; set; }

	private string? TimeZoneValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeoutValue { get; set; }

	public QueryRequestDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public QueryRequestDescriptor Filter(QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public QueryRequestDescriptor Filter(Action<QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public QueryRequestDescriptor Catalog(string? catalog)
	{
		CatalogValue = catalog;
		return Self;
	}

	public QueryRequestDescriptor Columnar(bool? columnar = true)
	{
		ColumnarValue = columnar;
		return Self;
	}

	public QueryRequestDescriptor Cursor(string? cursor)
	{
		CursorValue = cursor;
		return Self;
	}

	public QueryRequestDescriptor FetchSize(int? fetchSize)
	{
		FetchSizeValue = fetchSize;
		return Self;
	}

	public QueryRequestDescriptor FieldMultiValueLeniency(bool? fieldMultiValueLeniency = true)
	{
		FieldMultiValueLeniencyValue = fieldMultiValueLeniency;
		return Self;
	}

	public QueryRequestDescriptor IndexUsingFrozen(bool? indexUsingFrozen = true)
	{
		IndexUsingFrozenValue = indexUsingFrozen;
		return Self;
	}

	public QueryRequestDescriptor KeepAlive(Elastic.Clients.Elasticsearch.Duration? keepAlive)
	{
		KeepAliveValue = keepAlive;
		return Self;
	}

	public QueryRequestDescriptor KeepOnCompletion(bool? keepOnCompletion = true)
	{
		KeepOnCompletionValue = keepOnCompletion;
		return Self;
	}

	public QueryRequestDescriptor PageTimeout(Elastic.Clients.Elasticsearch.Duration? pageTimeout)
	{
		PageTimeoutValue = pageTimeout;
		return Self;
	}

	public QueryRequestDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public QueryRequestDescriptor Query(string? query)
	{
		QueryValue = query;
		return Self;
	}

	public QueryRequestDescriptor RequestTimeout(Elastic.Clients.Elasticsearch.Duration? requestTimeout)
	{
		RequestTimeoutValue = requestTimeout;
		return Self;
	}

	public QueryRequestDescriptor RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>());
		return Self;
	}

	public QueryRequestDescriptor TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	public QueryRequestDescriptor WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Duration? waitForCompletionTimeout)
	{
		WaitForCompletionTimeoutValue = waitForCompletionTimeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (!string.IsNullOrEmpty(CatalogValue))
		{
			writer.WritePropertyName("catalog");
			writer.WriteStringValue(CatalogValue);
		}

		if (ColumnarValue.HasValue)
		{
			writer.WritePropertyName("columnar");
			writer.WriteBooleanValue(ColumnarValue.Value);
		}

		if (!string.IsNullOrEmpty(CursorValue))
		{
			writer.WritePropertyName("cursor");
			writer.WriteStringValue(CursorValue);
		}

		if (FetchSizeValue.HasValue)
		{
			writer.WritePropertyName("fetch_size");
			writer.WriteNumberValue(FetchSizeValue.Value);
		}

		if (FieldMultiValueLeniencyValue.HasValue)
		{
			writer.WritePropertyName("field_multi_value_leniency");
			writer.WriteBooleanValue(FieldMultiValueLeniencyValue.Value);
		}

		if (IndexUsingFrozenValue.HasValue)
		{
			writer.WritePropertyName("index_using_frozen");
			writer.WriteBooleanValue(IndexUsingFrozenValue.Value);
		}

		if (KeepAliveValue is not null)
		{
			writer.WritePropertyName("keep_alive");
			JsonSerializer.Serialize(writer, KeepAliveValue, options);
		}

		if (KeepOnCompletionValue.HasValue)
		{
			writer.WritePropertyName("keep_on_completion");
			writer.WriteBooleanValue(KeepOnCompletionValue.Value);
		}

		if (PageTimeoutValue is not null)
		{
			writer.WritePropertyName("page_timeout");
			JsonSerializer.Serialize(writer, PageTimeoutValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (!string.IsNullOrEmpty(QueryValue))
		{
			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
		}

		if (RequestTimeoutValue is not null)
		{
			writer.WritePropertyName("request_timeout");
			JsonSerializer.Serialize(writer, RequestTimeoutValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		if (TimeZoneValue is not null)
		{
			writer.WritePropertyName("time_zone");
			JsonSerializer.Serialize(writer, TimeZoneValue, options);
		}

		if (WaitForCompletionTimeoutValue is not null)
		{
			writer.WritePropertyName("wait_for_completion_timeout");
			JsonSerializer.Serialize(writer, WaitForCompletionTimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}