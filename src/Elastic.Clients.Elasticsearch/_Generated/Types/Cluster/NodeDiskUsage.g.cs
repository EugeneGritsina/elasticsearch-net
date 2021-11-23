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
namespace Elastic.Clients.Elasticsearch.Cluster.AllocationExplain
{
	public partial class NodeDiskUsage
	{
		[JsonInclude]
		[JsonPropertyName("node_name")]
		public Elastic.Clients.Elasticsearch.Name NodeName { get; init; }

		[JsonInclude]
		[JsonPropertyName("least_available")]
		public Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.DiskUsage LeastAvailable { get; init; }

		[JsonInclude]
		[JsonPropertyName("most_available")]
		public Elastic.Clients.Elasticsearch.Cluster.AllocationExplain.DiskUsage MostAvailable { get; init; }
	}
}