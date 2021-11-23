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
namespace Elastic.Clients.Elasticsearch.IndexManagement.Analyze
{
	public partial class ExplainAnalyzeToken
	{
		[JsonInclude]
		[JsonPropertyName("bytes")]
		public string Bytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("end_offset")]
		public long EndOffset { get; init; }

		[JsonInclude]
		[JsonPropertyName("keyword")]
		public bool? Keyword { get; init; }

		[JsonInclude]
		[JsonPropertyName("position")]
		public long Position { get; init; }

		[JsonInclude]
		[JsonPropertyName("positionLength")]
		public long Positionlength { get; init; }

		[JsonInclude]
		[JsonPropertyName("start_offset")]
		public long StartOffset { get; init; }

		[JsonInclude]
		[JsonPropertyName("termFrequency")]
		public long Termfrequency { get; init; }

		[JsonInclude]
		[JsonPropertyName("token")]
		public string Token { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type { get; init; }
	}
}