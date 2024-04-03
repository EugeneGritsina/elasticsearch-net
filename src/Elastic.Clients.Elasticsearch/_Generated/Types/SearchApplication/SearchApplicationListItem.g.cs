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

namespace Elastic.Clients.Elasticsearch.SearchApplication;

public sealed partial class SearchApplicationListItem
{
	/// <summary>
	/// <para>Analytics collection associated to the Search Application</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("analytics_collection_name")]
	public string? AnalyticsCollectionName { get; init; }

	/// <summary>
	/// <para>Indices that are part of the Search Application</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("indices")]
	public IReadOnlyCollection<string> Indices { get; init; }

	/// <summary>
	/// <para>Search Application name</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("name")]
	public string Name { get; init; }

	/// <summary>
	/// <para>Last time the Search Application was updated</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("updated_at_millis")]
	public long UpdatedAtMillis { get; init; }
}