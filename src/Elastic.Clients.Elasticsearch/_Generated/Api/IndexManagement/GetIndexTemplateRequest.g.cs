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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class GetIndexTemplateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If true, returns settings in flat format.</para>
	/// </summary>
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>If true, returns all relevant default configurations for the index template.</para>
	/// </summary>
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>If true, the request retrieves information from the local node only. Defaults to false, which means information is retrieved from the master node.</para>
	/// </summary>
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>Returns information about one or more index templates.</para>
/// </summary>
public sealed partial class GetIndexTemplateRequest : PlainRequest<GetIndexTemplateRequestParameters>
{
	public GetIndexTemplateRequest()
	{
	}

	public GetIndexTemplateRequest(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementGetIndexTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.get_index_template";

	/// <summary>
	/// <para>If true, returns settings in flat format.</para>
	/// </summary>
	[JsonIgnore]
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>If true, returns all relevant default configurations for the index template.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>If true, the request retrieves information from the local node only. Defaults to false, which means information is retrieved from the master node.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>Returns information about one or more index templates.</para>
/// </summary>
public sealed partial class GetIndexTemplateRequestDescriptor : RequestDescriptor<GetIndexTemplateRequestDescriptor, GetIndexTemplateRequestParameters>
{
	internal GetIndexTemplateRequestDescriptor(Action<GetIndexTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public GetIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
	{
	}

	public GetIndexTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementGetIndexTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.get_index_template";

	public GetIndexTemplateRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
	public GetIndexTemplateRequestDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public GetIndexTemplateRequestDescriptor Local(bool? local = true) => Qs("local", local);
	public GetIndexTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public GetIndexTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}