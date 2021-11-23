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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class MatrixStatsFields
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public string Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public long Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("mean")]
		public double Mean { get; init; }

		[JsonInclude]
		[JsonPropertyName("variance")]
		public double Variance { get; init; }

		[JsonInclude]
		[JsonPropertyName("skewness")]
		public double Skewness { get; init; }

		[JsonInclude]
		[JsonPropertyName("kurtosis")]
		public double Kurtosis { get; init; }

		[JsonInclude]
		[JsonPropertyName("covariance")]
		public Dictionary<string, double> Covariance { get; init; }

		[JsonInclude]
		[JsonPropertyName("correlation")]
		public Dictionary<string, double> Correlation { get; init; }
	}
}