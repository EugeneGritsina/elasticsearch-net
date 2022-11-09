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
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed class DeleteDataStreamRequestParameters : RequestParameters
{
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }
}

public sealed partial class DeleteDataStreamRequest : PlainRequest<DeleteDataStreamRequestParameters>
{
	public DeleteDataStreamRequest(Elastic.Clients.Elasticsearch.DataStreamNames name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteDataStream;
	internal override HttpMethod HttpMethod => HttpMethod.DELETE;
	internal override bool SupportsBody => false;
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }
}

public sealed partial class DeleteDataStreamRequestDescriptor : RequestDescriptor<DeleteDataStreamRequestDescriptor, DeleteDataStreamRequestParameters>
{
	internal DeleteDataStreamRequestDescriptor(Action<DeleteDataStreamRequestDescriptor> configure) => configure.Invoke(this);
	public DeleteDataStreamRequestDescriptor(Elastic.Clients.Elasticsearch.DataStreamNames name) : base(r => r.Required("name", name))
	{
	}

	internal DeleteDataStreamRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteDataStream;
	internal override HttpMethod HttpMethod => HttpMethod.DELETE;
	internal override bool SupportsBody => false;
	public DeleteDataStreamRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public DeleteDataStreamRequestDescriptor Name(Elastic.Clients.Elasticsearch.DataStreamNames name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}