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

namespace Elastic.Clients.Elasticsearch.Analysis;

public sealed partial class DutchAnalyzer : IAnalyzer
{
	[JsonInclude, JsonPropertyName("stopwords")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? Stopwords { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "dutch";
}

public sealed partial class DutchAnalyzerDescriptor : SerializableDescriptor<DutchAnalyzerDescriptor>, IBuildableDescriptor<DutchAnalyzer>
{
	internal DutchAnalyzerDescriptor(Action<DutchAnalyzerDescriptor> configure) => configure.Invoke(this);

	public DutchAnalyzerDescriptor() : base()
	{
	}

	private ICollection<string>? StopwordsValue { get; set; }

	public DutchAnalyzerDescriptor Stopwords(ICollection<string>? stopwords)
	{
		StopwordsValue = stopwords;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (StopwordsValue is not null)
		{
			writer.WritePropertyName("stopwords");
			SingleOrManySerializationHelper.Serialize<string>(StopwordsValue, writer, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("dutch");
		writer.WriteEndObject();
	}

	DutchAnalyzer IBuildableDescriptor<DutchAnalyzer>.Build() => new()
	{
		Stopwords = StopwordsValue
	};
}