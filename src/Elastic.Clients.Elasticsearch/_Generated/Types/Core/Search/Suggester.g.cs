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

namespace Elastic.Clients.Elasticsearch.Core.Search;

internal sealed partial class SuggesterConverter : JsonConverter<Suggester>
{
	public override Suggester Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		var variant = new Suggester();
		Dictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggester> additionalProperties = null;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "text")
				{
					variant.Text = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				additionalProperties ??= new Dictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggester>();
				var additionalValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Core.Search.FieldSuggester>(ref reader, options);
				additionalProperties.Add(property, additionalValue);
			}
		}

		variant.Suggesters = additionalProperties;
		return variant;
	}

	public override void Write(Utf8JsonWriter writer, Suggester value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.Suggesters is not null)
		{
			foreach (var additionalProperty in value.Suggesters)
			{
				writer.WritePropertyName(additionalProperty.Key);
				JsonSerializer.Serialize(writer, additionalProperty.Value, options);
			}
		}

		if (!string.IsNullOrEmpty(value.Text))
		{
			writer.WritePropertyName("text");
			writer.WriteStringValue(value.Text);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(SuggesterConverter))]
public sealed partial class Suggester
{
	/// <summary>
	/// <para>The named suggesters</para>
	/// </summary>
	public IDictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggester> Suggesters { get; set; }

	/// <summary>
	/// <para>Global suggest text, to avoid repetition when the same text is used in several suggesters</para>
	/// </summary>
	public string? Text { get; set; }
}

public sealed partial class SuggesterDescriptor<TDocument> : SerializableDescriptor<SuggesterDescriptor<TDocument>>
{
	internal SuggesterDescriptor(Action<SuggesterDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SuggesterDescriptor() : base()
	{
	}

	private IDictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggesterDescriptor<TDocument>> SuggestersValue { get; set; }
	private string? TextValue { get; set; }

	/// <summary>
	/// <para>The named suggesters</para>
	/// </summary>
	public SuggesterDescriptor<TDocument> Suggesters(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggesterDescriptor<TDocument>>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggesterDescriptor<TDocument>>> selector)
	{
		SuggestersValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggesterDescriptor<TDocument>>());
		return Self;
	}

	/// <summary>
	/// <para>Global suggest text, to avoid repetition when the same text is used in several suggesters</para>
	/// </summary>
	public SuggesterDescriptor<TDocument> Text(string? text)
	{
		TextValue = text;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(TextValue))
		{
			writer.WritePropertyName("text");
			writer.WriteStringValue(TextValue);
		}

		if (SuggestersValue is not null)
		{
			foreach (var additionalProperty in SuggestersValue)
			{
				writer.WritePropertyName(additionalProperty.Key);
				JsonSerializer.Serialize(writer, additionalProperty.Value, options);
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SuggesterDescriptor : SerializableDescriptor<SuggesterDescriptor>
{
	internal SuggesterDescriptor(Action<SuggesterDescriptor> configure) => configure.Invoke(this);

	public SuggesterDescriptor() : base()
	{
	}

	private IDictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggesterDescriptor> SuggestersValue { get; set; }
	private string? TextValue { get; set; }

	/// <summary>
	/// <para>The named suggesters</para>
	/// </summary>
	public SuggesterDescriptor Suggesters(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggesterDescriptor>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggesterDescriptor>> selector)
	{
		SuggestersValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Core.Search.FieldSuggesterDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>Global suggest text, to avoid repetition when the same text is used in several suggesters</para>
	/// </summary>
	public SuggesterDescriptor Text(string? text)
	{
		TextValue = text;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(TextValue))
		{
			writer.WritePropertyName("text");
			writer.WriteStringValue(TextValue);
		}

		if (SuggestersValue is not null)
		{
			foreach (var additionalProperty in SuggestersValue)
			{
				writer.WritePropertyName(additionalProperty.Key);
				JsonSerializer.Serialize(writer, additionalProperty.Value, options);
			}
		}

		writer.WriteEndObject();
	}
}