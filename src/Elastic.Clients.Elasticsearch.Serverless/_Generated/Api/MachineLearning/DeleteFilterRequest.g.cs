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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class DeleteFilterRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Deletes a filter.<br/>If an anomaly detection job references the filter, you cannot delete the<br/>filter. You must update or delete the job before you can delete the filter.</para>
/// </summary>
public sealed partial class DeleteFilterRequest : PlainRequest<DeleteFilterRequestParameters>
{
	public DeleteFilterRequest(Elastic.Clients.Elasticsearch.Serverless.Id filterId) : base(r => r.Required("filter_id", filterId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteFilter;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_filter";
}

/// <summary>
/// <para>Deletes a filter.<br/>If an anomaly detection job references the filter, you cannot delete the<br/>filter. You must update or delete the job before you can delete the filter.</para>
/// </summary>
public sealed partial class DeleteFilterRequestDescriptor : RequestDescriptor<DeleteFilterRequestDescriptor, DeleteFilterRequestParameters>
{
	internal DeleteFilterRequestDescriptor(Action<DeleteFilterRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteFilterRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id filterId) : base(r => r.Required("filter_id", filterId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteFilter;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_filter";

	public DeleteFilterRequestDescriptor FilterId(Elastic.Clients.Elasticsearch.Serverless.Id filterId)
	{
		RouteValues.Required("filter_id", filterId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}