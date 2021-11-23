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

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster.RemoteInfo
{
	public partial class ClusterRemoteSniffInfo : IClusterRemoteInfosVariant
	{
		[JsonInclude]
		[JsonPropertyName("mode")]
		public string Mode => "sniff";
		[JsonInclude]
		[JsonPropertyName("connected")]
		public bool Connected { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_connections_per_cluster")]
		public int MaxConnectionsPerCluster { get; init; }

		[JsonInclude]
		[JsonPropertyName("num_nodes_connected")]
		public long NumNodesConnected { get; init; }

		[JsonInclude]
		[JsonPropertyName("initial_connect_timeout")]
		public Elastic.Clients.Elasticsearch.Time InitialConnectTimeout { get; init; }

		[JsonInclude]
		[JsonPropertyName("skip_unavailable")]
		public bool SkipUnavailable { get; init; }

		[JsonInclude]
		[JsonPropertyName("seeds")]
		public IReadOnlyCollection<string> Seeds { get; init; }
	}
}