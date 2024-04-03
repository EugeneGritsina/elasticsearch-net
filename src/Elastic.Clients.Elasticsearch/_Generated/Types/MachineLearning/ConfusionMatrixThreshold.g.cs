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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class ConfusionMatrixThreshold
{
	/// <summary>
	/// <para>False Negative</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fn")]
	public int FalseNegative { get; init; }

	/// <summary>
	/// <para>False Positive</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fp")]
	public int FalsePositive { get; init; }

	/// <summary>
	/// <para>True Negative</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tn")]
	public int TrueNegative { get; init; }

	/// <summary>
	/// <para>True Positive</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tp")]
	public int TruePositive { get; init; }
}