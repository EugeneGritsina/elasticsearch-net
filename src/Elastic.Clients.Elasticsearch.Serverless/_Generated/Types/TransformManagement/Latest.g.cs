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

namespace Elastic.Clients.Elasticsearch.Serverless.TransformManagement;

public sealed partial class Latest
{
	/// <summary>
	/// <para>Specifies the date field that is used to identify the latest documents.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sort")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Sort { get; set; }

	/// <summary>
	/// <para>Specifies an array of one or more fields that are used to group the data.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("unique_key")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Field> UniqueKey { get; set; }
}

public sealed partial class LatestDescriptor<TDocument> : SerializableDescriptor<LatestDescriptor<TDocument>>
{
	internal LatestDescriptor(Action<LatestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public LatestDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field SortValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Field> UniqueKeyValue { get; set; }

	/// <summary>
	/// <para>Specifies the date field that is used to identify the latest documents.</para>
	/// </summary>
	public LatestDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.Serverless.Field sort)
	{
		SortValue = sort;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the date field that is used to identify the latest documents.</para>
	/// </summary>
	public LatestDescriptor<TDocument> Sort<TValue>(Expression<Func<TDocument, TValue>> sort)
	{
		SortValue = sort;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the date field that is used to identify the latest documents.</para>
	/// </summary>
	public LatestDescriptor<TDocument> Sort(Expression<Func<TDocument, object>> sort)
	{
		SortValue = sort;
		return Self;
	}

	/// <summary>
	/// <para>Specifies an array of one or more fields that are used to group the data.</para>
	/// </summary>
	public LatestDescriptor<TDocument> UniqueKey(ICollection<Elastic.Clients.Elasticsearch.Serverless.Field> uniqueKey)
	{
		UniqueKeyValue = uniqueKey;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("sort");
		JsonSerializer.Serialize(writer, SortValue, options);
		writer.WritePropertyName("unique_key");
		JsonSerializer.Serialize(writer, UniqueKeyValue, options);
		writer.WriteEndObject();
	}
}

public sealed partial class LatestDescriptor : SerializableDescriptor<LatestDescriptor>
{
	internal LatestDescriptor(Action<LatestDescriptor> configure) => configure.Invoke(this);

	public LatestDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field SortValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Field> UniqueKeyValue { get; set; }

	/// <summary>
	/// <para>Specifies the date field that is used to identify the latest documents.</para>
	/// </summary>
	public LatestDescriptor Sort(Elastic.Clients.Elasticsearch.Serverless.Field sort)
	{
		SortValue = sort;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the date field that is used to identify the latest documents.</para>
	/// </summary>
	public LatestDescriptor Sort<TDocument, TValue>(Expression<Func<TDocument, TValue>> sort)
	{
		SortValue = sort;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the date field that is used to identify the latest documents.</para>
	/// </summary>
	public LatestDescriptor Sort<TDocument>(Expression<Func<TDocument, object>> sort)
	{
		SortValue = sort;
		return Self;
	}

	/// <summary>
	/// <para>Specifies an array of one or more fields that are used to group the data.</para>
	/// </summary>
	public LatestDescriptor UniqueKey(ICollection<Elastic.Clients.Elasticsearch.Serverless.Field> uniqueKey)
	{
		UniqueKeyValue = uniqueKey;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("sort");
		JsonSerializer.Serialize(writer, SortValue, options);
		writer.WritePropertyName("unique_key");
		JsonSerializer.Serialize(writer, UniqueKeyValue, options);
		writer.WriteEndObject();
	}
}