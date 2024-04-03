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

public sealed partial class CleanupRepositoryRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Period to wait for a connection to the master node.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Triggers the review of a snapshot repository’s contents and deletes any stale data not referenced by existing snapshots.</para>
/// </summary>
public sealed partial class CleanupRepositoryRequest : PlainRequest<CleanupRepositoryRequestParameters>
{
	public CleanupRepositoryRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("repository", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotCleanupRepository;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "snapshot.cleanup_repository";

	/// <summary>
	/// <para>Period to wait for a connection to the master node.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Triggers the review of a snapshot repository’s contents and deletes any stale data not referenced by existing snapshots.</para>
/// </summary>
public sealed partial class CleanupRepositoryRequestDescriptor : RequestDescriptor<CleanupRepositoryRequestDescriptor, CleanupRepositoryRequestParameters>
{
	internal CleanupRepositoryRequestDescriptor(Action<CleanupRepositoryRequestDescriptor> configure) => configure.Invoke(this);

	public CleanupRepositoryRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("repository", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotCleanupRepository;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "snapshot.cleanup_repository";

	public CleanupRepositoryRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public CleanupRepositoryRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public CleanupRepositoryRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("repository", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}