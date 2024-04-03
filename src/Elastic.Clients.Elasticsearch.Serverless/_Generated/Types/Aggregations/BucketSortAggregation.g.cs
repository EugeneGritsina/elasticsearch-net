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

public sealed partial class BucketSortAggregation
{
	/// <summary>
	/// <para>Buckets in positions prior to `from` will be truncated.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("from")]
	public int? From { get; set; }

	/// <summary>
	/// <para>The policy to apply when gaps are found in the data.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("gap_policy")]
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? GapPolicy { get; set; }
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, object>? Meta { get; set; }
	[JsonInclude, JsonPropertyName("name")]
	public string? Name { get; set; }

	/// <summary>
	/// <para>The number of buckets to return.<br/>Defaults to all buckets of the parent aggregation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("size")]
	public int? Size { get; set; }

	/// <summary>
	/// <para>The list of fields to sort on.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sort")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.Serverless.SortOptions))]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? Sort { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation(BucketSortAggregation bucketSortAggregation) => Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation.BucketSort(bucketSortAggregation);
}

public sealed partial class BucketSortAggregationDescriptor<TDocument> : SerializableDescriptor<BucketSortAggregationDescriptor<TDocument>>
{
	internal BucketSortAggregationDescriptor(Action<BucketSortAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public BucketSortAggregationDescriptor() : base()
	{
	}

	private int? FromValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? GapPolicyValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private string? NameValue { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument> SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>>[] SortDescriptorActions { get; set; }

	/// <summary>
	/// <para>Buckets in positions prior to `from` will be truncated.</para>
	/// </summary>
	public BucketSortAggregationDescriptor<TDocument> From(int? from)
	{
		FromValue = from;
		return Self;
	}

	/// <summary>
	/// <para>The policy to apply when gaps are found in the data.</para>
	/// </summary>
	public BucketSortAggregationDescriptor<TDocument> GapPolicy(Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? gapPolicy)
	{
		GapPolicyValue = gapPolicy;
		return Self;
	}

	public BucketSortAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public BucketSortAggregationDescriptor<TDocument> Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>The number of buckets to return.<br/>Defaults to all buckets of the parent aggregation.</para>
	/// </summary>
	public BucketSortAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>The list of fields to sort on.</para>
	/// </summary>
	public BucketSortAggregationDescriptor<TDocument> Sort(ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public BucketSortAggregationDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public BucketSortAggregationDescriptor<TDocument> Sort(Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public BucketSortAggregationDescriptor<TDocument> Sort(params Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FromValue.HasValue)
		{
			writer.WritePropertyName("from");
			writer.WriteNumberValue(FromValue.Value);
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

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.SortOptions>(SortValue, writer, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class BucketSortAggregationDescriptor : SerializableDescriptor<BucketSortAggregationDescriptor>
{
	internal BucketSortAggregationDescriptor(Action<BucketSortAggregationDescriptor> configure) => configure.Invoke(this);

	public BucketSortAggregationDescriptor() : base()
	{
	}

	private int? FromValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? GapPolicyValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private string? NameValue { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor>[] SortDescriptorActions { get; set; }

	/// <summary>
	/// <para>Buckets in positions prior to `from` will be truncated.</para>
	/// </summary>
	public BucketSortAggregationDescriptor From(int? from)
	{
		FromValue = from;
		return Self;
	}

	/// <summary>
	/// <para>The policy to apply when gaps are found in the data.</para>
	/// </summary>
	public BucketSortAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Serverless.Aggregations.GapPolicy? gapPolicy)
	{
		GapPolicyValue = gapPolicy;
		return Self;
	}

	public BucketSortAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public BucketSortAggregationDescriptor Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>The number of buckets to return.<br/>Defaults to all buckets of the parent aggregation.</para>
	/// </summary>
	public BucketSortAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>The list of fields to sort on.</para>
	/// </summary>
	public BucketSortAggregationDescriptor Sort(ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public BucketSortAggregationDescriptor Sort(Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public BucketSortAggregationDescriptor Sort(Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public BucketSortAggregationDescriptor Sort(params Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FromValue.HasValue)
		{
			writer.WritePropertyName("from");
			writer.WriteNumberValue(FromValue.Value);
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

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.SortOptions>(SortValue, writer, options);
		}

		writer.WriteEndObject();
	}
}