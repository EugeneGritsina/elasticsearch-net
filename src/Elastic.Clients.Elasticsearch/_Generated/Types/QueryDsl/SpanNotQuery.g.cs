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

namespace Elastic.Clients.Elasticsearch.QueryDsl;

public sealed partial class SpanNotQuery
{
	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>The number of tokens from within the include span that can’t have overlap with the exclude span.<br/>Equivalent to setting both `pre` and `post`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("dist")]
	public int? Dist { get; set; }

	/// <summary>
	/// <para>Span query whose matches must not overlap those returned.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("exclude")]
	public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Exclude { get; set; }

	/// <summary>
	/// <para>Span query whose matches are filtered.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("include")]
	public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Include { get; set; }

	/// <summary>
	/// <para>The number of tokens after the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("post")]
	public int? Post { get; set; }

	/// <summary>
	/// <para>The number of tokens before the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("pre")]
	public int? Pre { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.Query(SpanNotQuery spanNotQuery) => Elastic.Clients.Elasticsearch.QueryDsl.Query.SpanNot(spanNotQuery);
	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery(SpanNotQuery spanNotQuery) => Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery.SpanNot(spanNotQuery);
}

public sealed partial class SpanNotQueryDescriptor<TDocument> : SerializableDescriptor<SpanNotQueryDescriptor<TDocument>>
{
	internal SpanNotQueryDescriptor(Action<SpanNotQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SpanNotQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private int? DistValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery ExcludeValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument> ExcludeDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>> ExcludeDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery IncludeValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument> IncludeDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>> IncludeDescriptorAction { get; set; }
	private int? PostValue { get; set; }
	private int? PreValue { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens from within the include span that can’t have overlap with the exclude span.<br/>Equivalent to setting both `pre` and `post`.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Dist(int? dist)
	{
		DistValue = dist;
		return Self;
	}

	/// <summary>
	/// <para>Span query whose matches must not overlap those returned.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Exclude(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery exclude)
	{
		ExcludeDescriptor = null;
		ExcludeDescriptorAction = null;
		ExcludeValue = exclude;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> Exclude(Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument> descriptor)
	{
		ExcludeValue = null;
		ExcludeDescriptorAction = null;
		ExcludeDescriptor = descriptor;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> Exclude(Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>> configure)
	{
		ExcludeValue = null;
		ExcludeDescriptor = null;
		ExcludeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Span query whose matches are filtered.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Include(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery include)
	{
		IncludeDescriptor = null;
		IncludeDescriptorAction = null;
		IncludeValue = include;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> Include(Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument> descriptor)
	{
		IncludeValue = null;
		IncludeDescriptorAction = null;
		IncludeDescriptor = descriptor;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> Include(Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>> configure)
	{
		IncludeValue = null;
		IncludeDescriptor = null;
		IncludeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens after the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Post(int? post)
	{
		PostValue = post;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens before the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Pre(int? pre)
	{
		PreValue = pre;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (DistValue.HasValue)
		{
			writer.WritePropertyName("dist");
			writer.WriteNumberValue(DistValue.Value);
		}

		if (ExcludeDescriptor is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeDescriptor, options);
		}
		else if (ExcludeDescriptorAction is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>(ExcludeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeValue, options);
		}

		if (IncludeDescriptor is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeDescriptor, options);
		}
		else if (IncludeDescriptorAction is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor<TDocument>(IncludeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeValue, options);
		}

		if (PostValue.HasValue)
		{
			writer.WritePropertyName("post");
			writer.WriteNumberValue(PostValue.Value);
		}

		if (PreValue.HasValue)
		{
			writer.WritePropertyName("pre");
			writer.WriteNumberValue(PreValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SpanNotQueryDescriptor : SerializableDescriptor<SpanNotQueryDescriptor>
{
	internal SpanNotQueryDescriptor(Action<SpanNotQueryDescriptor> configure) => configure.Invoke(this);

	public SpanNotQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private int? DistValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery ExcludeValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor ExcludeDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor> ExcludeDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery IncludeValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor IncludeDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor> IncludeDescriptorAction { get; set; }
	private int? PostValue { get; set; }
	private int? PreValue { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public SpanNotQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens from within the include span that can’t have overlap with the exclude span.<br/>Equivalent to setting both `pre` and `post`.</para>
	/// </summary>
	public SpanNotQueryDescriptor Dist(int? dist)
	{
		DistValue = dist;
		return Self;
	}

	/// <summary>
	/// <para>Span query whose matches must not overlap those returned.</para>
	/// </summary>
	public SpanNotQueryDescriptor Exclude(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery exclude)
	{
		ExcludeDescriptor = null;
		ExcludeDescriptorAction = null;
		ExcludeValue = exclude;
		return Self;
	}

	public SpanNotQueryDescriptor Exclude(Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor descriptor)
	{
		ExcludeValue = null;
		ExcludeDescriptorAction = null;
		ExcludeDescriptor = descriptor;
		return Self;
	}

	public SpanNotQueryDescriptor Exclude(Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor> configure)
	{
		ExcludeValue = null;
		ExcludeDescriptor = null;
		ExcludeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Span query whose matches are filtered.</para>
	/// </summary>
	public SpanNotQueryDescriptor Include(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery include)
	{
		IncludeDescriptor = null;
		IncludeDescriptorAction = null;
		IncludeValue = include;
		return Self;
	}

	public SpanNotQueryDescriptor Include(Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor descriptor)
	{
		IncludeValue = null;
		IncludeDescriptorAction = null;
		IncludeDescriptor = descriptor;
		return Self;
	}

	public SpanNotQueryDescriptor Include(Action<Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor> configure)
	{
		IncludeValue = null;
		IncludeDescriptor = null;
		IncludeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens after the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	public SpanNotQueryDescriptor Post(int? post)
	{
		PostValue = post;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens before the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	public SpanNotQueryDescriptor Pre(int? pre)
	{
		PreValue = pre;
		return Self;
	}

	public SpanNotQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (DistValue.HasValue)
		{
			writer.WritePropertyName("dist");
			writer.WriteNumberValue(DistValue.Value);
		}

		if (ExcludeDescriptor is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeDescriptor, options);
		}
		else if (ExcludeDescriptorAction is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor(ExcludeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeValue, options);
		}

		if (IncludeDescriptor is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeDescriptor, options);
		}
		else if (IncludeDescriptorAction is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.SpanQueryDescriptor(IncludeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeValue, options);
		}

		if (PostValue.HasValue)
		{
			writer.WritePropertyName("post");
			writer.WriteNumberValue(PostValue.Value);
		}

		if (PreValue.HasValue)
		{
			writer.WritePropertyName("pre");
			writer.WriteNumberValue(PreValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
	}
}