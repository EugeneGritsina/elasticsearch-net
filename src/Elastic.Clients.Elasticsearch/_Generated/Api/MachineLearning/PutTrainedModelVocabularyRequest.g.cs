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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class PutTrainedModelVocabularyRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Creates a trained model vocabulary.<br/>This API is supported only for natural language processing (NLP) models.<br/>The vocabulary is stored in the index as described in `inference_config.*.vocabulary` of the trained model definition.</para>
/// </summary>
public sealed partial class PutTrainedModelVocabularyRequest : PlainRequest<PutTrainedModelVocabularyRequestParameters>
{
	public PutTrainedModelVocabularyRequest(Elastic.Clients.Elasticsearch.Id modelId) : base(r => r.Required("model_id", modelId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningPutTrainedModelVocabulary;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.put_trained_model_vocabulary";

	/// <summary>
	/// <para>The optional model merges if required by the tokenizer.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("merges")]
	public ICollection<string>? Merges { get; set; }

	/// <summary>
	/// <para>The optional vocabulary value scores if required by the tokenizer.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("scores")]
	public ICollection<double>? Scores { get; set; }

	/// <summary>
	/// <para>The model vocabulary, which must not be empty.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("vocabulary")]
	public ICollection<string> Vocabulary { get; set; }
}

/// <summary>
/// <para>Creates a trained model vocabulary.<br/>This API is supported only for natural language processing (NLP) models.<br/>The vocabulary is stored in the index as described in `inference_config.*.vocabulary` of the trained model definition.</para>
/// </summary>
public sealed partial class PutTrainedModelVocabularyRequestDescriptor : RequestDescriptor<PutTrainedModelVocabularyRequestDescriptor, PutTrainedModelVocabularyRequestParameters>
{
	internal PutTrainedModelVocabularyRequestDescriptor(Action<PutTrainedModelVocabularyRequestDescriptor> configure) => configure.Invoke(this);

	public PutTrainedModelVocabularyRequestDescriptor(Elastic.Clients.Elasticsearch.Id modelId) : base(r => r.Required("model_id", modelId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningPutTrainedModelVocabulary;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.put_trained_model_vocabulary";

	public PutTrainedModelVocabularyRequestDescriptor ModelId(Elastic.Clients.Elasticsearch.Id modelId)
	{
		RouteValues.Required("model_id", modelId);
		return Self;
	}

	private ICollection<string>? MergesValue { get; set; }
	private ICollection<double>? ScoresValue { get; set; }
	private ICollection<string> VocabularyValue { get; set; }

	/// <summary>
	/// <para>The optional model merges if required by the tokenizer.</para>
	/// </summary>
	public PutTrainedModelVocabularyRequestDescriptor Merges(ICollection<string>? merges)
	{
		MergesValue = merges;
		return Self;
	}

	/// <summary>
	/// <para>The optional vocabulary value scores if required by the tokenizer.</para>
	/// </summary>
	public PutTrainedModelVocabularyRequestDescriptor Scores(ICollection<double>? scores)
	{
		ScoresValue = scores;
		return Self;
	}

	/// <summary>
	/// <para>The model vocabulary, which must not be empty.</para>
	/// </summary>
	public PutTrainedModelVocabularyRequestDescriptor Vocabulary(ICollection<string> vocabulary)
	{
		VocabularyValue = vocabulary;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MergesValue is not null)
		{
			writer.WritePropertyName("merges");
			JsonSerializer.Serialize(writer, MergesValue, options);
		}

		if (ScoresValue is not null)
		{
			writer.WritePropertyName("scores");
			JsonSerializer.Serialize(writer, ScoresValue, options);
		}

		writer.WritePropertyName("vocabulary");
		JsonSerializer.Serialize(writer, VocabularyValue, options);
		writer.WriteEndObject();
	}
}