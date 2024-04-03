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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class NodeShard
{
	[JsonInclude, JsonPropertyName("allocation_id")]
	public IReadOnlyDictionary<string, string>? AllocationId { get; init; }
	[JsonInclude, JsonPropertyName("index")]
	public string Index { get; init; }
	[JsonInclude, JsonPropertyName("node")]
	public string? Node { get; init; }
	[JsonInclude, JsonPropertyName("primary")]
	public bool Primary { get; init; }
	[JsonInclude, JsonPropertyName("recovery_source")]
	public IReadOnlyDictionary<string, string>? RecoverySource { get; init; }
	[JsonInclude, JsonPropertyName("relocating_node")]
	public string? RelocatingNode { get; init; }
	[JsonInclude, JsonPropertyName("relocation_failure_info")]
	public Elastic.Clients.Elasticsearch.RelocationFailureInfo? RelocationFailureInfo { get; init; }
	[JsonInclude, JsonPropertyName("shard")]
	public int Shard { get; init; }
	[JsonInclude, JsonPropertyName("state")]
	public Elastic.Clients.Elasticsearch.IndexManagement.ShardRoutingState State { get; init; }
	[JsonInclude, JsonPropertyName("unassigned_info")]
	public Elastic.Clients.Elasticsearch.Cluster.UnassignedInformation? UnassignedInfo { get; init; }
}