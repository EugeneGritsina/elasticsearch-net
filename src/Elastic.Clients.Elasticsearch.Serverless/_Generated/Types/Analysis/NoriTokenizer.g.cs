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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Analysis;

public sealed partial class NoriTokenizer : ITokenizer
{
	[JsonInclude, JsonPropertyName("decompound_mode")]
	public Elastic.Clients.Elasticsearch.Serverless.Analysis.NoriDecompoundMode? DecompoundMode { get; set; }
	[JsonInclude, JsonPropertyName("discard_punctuation")]
	public bool? DiscardPunctuation { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "nori_tokenizer";

	[JsonInclude, JsonPropertyName("user_dictionary")]
	public string? UserDictionary { get; set; }
	[JsonInclude, JsonPropertyName("user_dictionary_rules")]
	public ICollection<string>? UserDictionaryRules { get; set; }
	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class NoriTokenizerDescriptor : SerializableDescriptor<NoriTokenizerDescriptor>, IBuildableDescriptor<NoriTokenizer>
{
	internal NoriTokenizerDescriptor(Action<NoriTokenizerDescriptor> configure) => configure.Invoke(this);

	public NoriTokenizerDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Analysis.NoriDecompoundMode? DecompoundModeValue { get; set; }
	private bool? DiscardPunctuationValue { get; set; }
	private string? UserDictionaryValue { get; set; }
	private ICollection<string>? UserDictionaryRulesValue { get; set; }
	private string? VersionValue { get; set; }

	public NoriTokenizerDescriptor DecompoundMode(Elastic.Clients.Elasticsearch.Serverless.Analysis.NoriDecompoundMode? decompoundMode)
	{
		DecompoundModeValue = decompoundMode;
		return Self;
	}

	public NoriTokenizerDescriptor DiscardPunctuation(bool? discardPunctuation = true)
	{
		DiscardPunctuationValue = discardPunctuation;
		return Self;
	}

	public NoriTokenizerDescriptor UserDictionary(string? userDictionary)
	{
		UserDictionaryValue = userDictionary;
		return Self;
	}

	public NoriTokenizerDescriptor UserDictionaryRules(ICollection<string>? userDictionaryRules)
	{
		UserDictionaryRulesValue = userDictionaryRules;
		return Self;
	}

	public NoriTokenizerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DecompoundModeValue is not null)
		{
			writer.WritePropertyName("decompound_mode");
			JsonSerializer.Serialize(writer, DecompoundModeValue, options);
		}

		if (DiscardPunctuationValue.HasValue)
		{
			writer.WritePropertyName("discard_punctuation");
			writer.WriteBooleanValue(DiscardPunctuationValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("nori_tokenizer");
		if (!string.IsNullOrEmpty(UserDictionaryValue))
		{
			writer.WritePropertyName("user_dictionary");
			writer.WriteStringValue(UserDictionaryValue);
		}

		if (UserDictionaryRulesValue is not null)
		{
			writer.WritePropertyName("user_dictionary_rules");
			JsonSerializer.Serialize(writer, UserDictionaryRulesValue, options);
		}

		if (!string.IsNullOrEmpty(VersionValue))
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(VersionValue);
		}

		writer.WriteEndObject();
	}

	NoriTokenizer IBuildableDescriptor<NoriTokenizer>.Build() => new()
	{
		DecompoundMode = DecompoundModeValue,
		DiscardPunctuation = DiscardPunctuationValue,
		UserDictionary = UserDictionaryValue,
		UserDictionaryRules = UserDictionaryRulesValue,
		Version = VersionValue
	};
}