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

namespace Elastic.Clients.Elasticsearch.Snapshot;

public sealed partial class CreateRepositoryRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Explicit operation timeout for connection to master node</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Explicit operation timeout</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Whether to verify the repository after creation</para>
	/// </summary>
	public bool? Verify { get => Q<bool?>("verify"); set => Q("verify", value); }
}

/// <summary>
/// <para>Creates a repository.</para>
/// </summary>
public sealed partial class CreateRepositoryRequest : PlainRequest<CreateRepositoryRequestParameters>
{
	public CreateRepositoryRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("repository", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotCreateRepository;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "snapshot.create_repository";

	/// <summary>
	/// <para>Explicit operation timeout for connection to master node</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Explicit operation timeout</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Whether to verify the repository after creation</para>
	/// </summary>
	[JsonIgnore]
	public bool? Verify { get => Q<bool?>("verify"); set => Q("verify", value); }
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Snapshot.IRepository Repository { get; set; }
}

/// <summary>
/// <para>Creates a repository.</para>
/// </summary>
public sealed partial class CreateRepositoryRequestDescriptor : RequestDescriptor<CreateRepositoryRequestDescriptor, CreateRepositoryRequestParameters>
{
	internal CreateRepositoryRequestDescriptor(Action<CreateRepositoryRequestDescriptor> configure) => configure.Invoke(this);
	public CreateRepositoryRequestDescriptor(Elastic.Clients.Elasticsearch.Snapshot.IRepository repository, Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("repository", name)) => RepositoryValue = repository;

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotCreateRepository;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "snapshot.create_repository";

	public CreateRepositoryRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public CreateRepositoryRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public CreateRepositoryRequestDescriptor Verify(bool? verify = true) => Qs("verify", verify);

	public CreateRepositoryRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("repository", name);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Snapshot.IRepository RepositoryValue { get; set; }

	public CreateRepositoryRequestDescriptor Repository(Elastic.Clients.Elasticsearch.Snapshot.IRepository repository)
	{
		RepositoryValue = repository;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}