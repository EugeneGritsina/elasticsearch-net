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

namespace Elastic.Clients.Elasticsearch.Serverless.Ingest;

public sealed partial class KeyValueProcessor
{
	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>List of keys to exclude from document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("exclude_keys")]
	public ICollection<string>? ExcludeKeys { get; set; }

	/// <summary>
	/// <para>The field to be parsed.<br/>Supports template snippets.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }

	/// <summary>
	/// <para>Regex pattern to use for splitting key-value pairs.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field_split")]
	public string FieldSplit { get; set; }

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>If `true` and `field` does not exist or is `null`, the processor quietly exits without modifying the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_missing")]
	public bool? IgnoreMissing { get; set; }

	/// <summary>
	/// <para>List of keys to filter and insert into document.<br/>Defaults to including all keys.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("include_keys")]
	public ICollection<string>? IncludeKeys { get; set; }

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>Prefix to be added to extracted keys.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("prefix")]
	public string? Prefix { get; set; }

	/// <summary>
	/// <para>If `true`. strip brackets `()`, `<>`, `[]` as well as quotes `'` and `"` from extracted values.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("strip_brackets")]
	public bool? StripBrackets { get; set; }

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>The field to insert the extracted keys into.<br/>Defaults to the root of the document.<br/>Supports template snippets.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? TargetField { get; set; }

	/// <summary>
	/// <para>String of characters to trim from extracted keys.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("trim_key")]
	public string? TrimKey { get; set; }

	/// <summary>
	/// <para>String of characters to trim from extracted values.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("trim_value")]
	public string? TrimValue { get; set; }

	/// <summary>
	/// <para>Regex pattern to use for splitting the key from the value within a key-value pair.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("value_split")]
	public string ValueSplit { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor(KeyValueProcessor keyValueProcessor) => Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor.Kv(keyValueProcessor);
}

public sealed partial class KeyValueProcessorDescriptor<TDocument> : SerializableDescriptor<KeyValueProcessorDescriptor<TDocument>>
{
	internal KeyValueProcessorDescriptor(Action<KeyValueProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public KeyValueProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private ICollection<string>? ExcludeKeysValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string FieldSplitValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private ICollection<string>? IncludeKeysValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private string? PrefixValue { get; set; }
	private bool? StripBracketsValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }
	private string? TrimKeyValue { get; set; }
	private string? TrimValueValue { get; set; }
	private string ValueSplitValue { get; set; }

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>List of keys to exclude from document.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> ExcludeKeys(ICollection<string>? excludeKeys)
	{
		ExcludeKeysValue = excludeKeys;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Regex pattern to use for splitting key-value pairs.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> FieldSplit(string fieldSplit)
	{
		FieldSplitValue = fieldSplit;
		return Self;
	}

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>If `true` and `field` does not exist or is `null`, the processor quietly exits without modifying the document.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>List of keys to filter and insert into document.<br/>Defaults to including all keys.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> IncludeKeys(ICollection<string>? includeKeys)
	{
		IncludeKeysValue = includeKeys;
		return Self;
	}

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public KeyValueProcessorDescriptor<TDocument> OnFailure(Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public KeyValueProcessorDescriptor<TDocument> OnFailure(Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public KeyValueProcessorDescriptor<TDocument> OnFailure(params Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Prefix to be added to extracted keys.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> Prefix(string? prefix)
	{
		PrefixValue = prefix;
		return Self;
	}

	/// <summary>
	/// <para>If `true`. strip brackets `()`, `<>`, `[]` as well as quotes `'` and `"` from extracted values.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> StripBrackets(bool? stripBrackets = true)
	{
		StripBracketsValue = stripBrackets;
		return Self;
	}

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field to insert the extracted keys into.<br/>Defaults to the root of the document.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field to insert the extracted keys into.<br/>Defaults to the root of the document.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field to insert the extracted keys into.<br/>Defaults to the root of the document.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> TargetField(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>String of characters to trim from extracted keys.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> TrimKey(string? trimKey)
	{
		TrimKeyValue = trimKey;
		return Self;
	}

	/// <summary>
	/// <para>String of characters to trim from extracted values.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> TrimValue(string? trimValue)
	{
		TrimValueValue = trimValue;
		return Self;
	}

	/// <summary>
	/// <para>Regex pattern to use for splitting the key from the value within a key-value pair.</para>
	/// </summary>
	public KeyValueProcessorDescriptor<TDocument> ValueSplit(string valueSplit)
	{
		ValueSplitValue = valueSplit;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (ExcludeKeysValue is not null)
		{
			writer.WritePropertyName("exclude_keys");
			JsonSerializer.Serialize(writer, ExcludeKeysValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("field_split");
		writer.WriteStringValue(FieldSplitValue);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		if (IncludeKeysValue is not null)
		{
			writer.WritePropertyName("include_keys");
			JsonSerializer.Serialize(writer, IncludeKeysValue, options);
		}

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(PrefixValue))
		{
			writer.WritePropertyName("prefix");
			writer.WriteStringValue(PrefixValue);
		}

		if (StripBracketsValue.HasValue)
		{
			writer.WritePropertyName("strip_brackets");
			writer.WriteBooleanValue(StripBracketsValue.Value);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		if (!string.IsNullOrEmpty(TrimKeyValue))
		{
			writer.WritePropertyName("trim_key");
			writer.WriteStringValue(TrimKeyValue);
		}

		if (!string.IsNullOrEmpty(TrimValueValue))
		{
			writer.WritePropertyName("trim_value");
			writer.WriteStringValue(TrimValueValue);
		}

		writer.WritePropertyName("value_split");
		writer.WriteStringValue(ValueSplitValue);
		writer.WriteEndObject();
	}
}

public sealed partial class KeyValueProcessorDescriptor : SerializableDescriptor<KeyValueProcessorDescriptor>
{
	internal KeyValueProcessorDescriptor(Action<KeyValueProcessorDescriptor> configure) => configure.Invoke(this);

	public KeyValueProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private ICollection<string>? ExcludeKeysValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string FieldSplitValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private ICollection<string>? IncludeKeysValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private string? PrefixValue { get; set; }
	private bool? StripBracketsValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }
	private string? TrimKeyValue { get; set; }
	private string? TrimValueValue { get; set; }
	private string ValueSplitValue { get; set; }

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	public KeyValueProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>List of keys to exclude from document.</para>
	/// </summary>
	public KeyValueProcessorDescriptor ExcludeKeys(ICollection<string>? excludeKeys)
	{
		ExcludeKeysValue = excludeKeys;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Regex pattern to use for splitting key-value pairs.</para>
	/// </summary>
	public KeyValueProcessorDescriptor FieldSplit(string fieldSplit)
	{
		FieldSplitValue = fieldSplit;
		return Self;
	}

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	public KeyValueProcessorDescriptor If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	public KeyValueProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>If `true` and `field` does not exist or is `null`, the processor quietly exits without modifying the document.</para>
	/// </summary>
	public KeyValueProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>List of keys to filter and insert into document.<br/>Defaults to including all keys.</para>
	/// </summary>
	public KeyValueProcessorDescriptor IncludeKeys(ICollection<string>? includeKeys)
	{
		IncludeKeysValue = includeKeys;
		return Self;
	}

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	public KeyValueProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public KeyValueProcessorDescriptor OnFailure(Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public KeyValueProcessorDescriptor OnFailure(Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public KeyValueProcessorDescriptor OnFailure(params Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Prefix to be added to extracted keys.</para>
	/// </summary>
	public KeyValueProcessorDescriptor Prefix(string? prefix)
	{
		PrefixValue = prefix;
		return Self;
	}

	/// <summary>
	/// <para>If `true`. strip brackets `()`, `<>`, `[]` as well as quotes `'` and `"` from extracted values.</para>
	/// </summary>
	public KeyValueProcessorDescriptor StripBrackets(bool? stripBrackets = true)
	{
		StripBracketsValue = stripBrackets;
		return Self;
	}

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	public KeyValueProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field to insert the extracted keys into.<br/>Defaults to the root of the document.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field to insert the extracted keys into.<br/>Defaults to the root of the document.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field to insert the extracted keys into.<br/>Defaults to the root of the document.<br/>Supports template snippets.</para>
	/// </summary>
	public KeyValueProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>String of characters to trim from extracted keys.</para>
	/// </summary>
	public KeyValueProcessorDescriptor TrimKey(string? trimKey)
	{
		TrimKeyValue = trimKey;
		return Self;
	}

	/// <summary>
	/// <para>String of characters to trim from extracted values.</para>
	/// </summary>
	public KeyValueProcessorDescriptor TrimValue(string? trimValue)
	{
		TrimValueValue = trimValue;
		return Self;
	}

	/// <summary>
	/// <para>Regex pattern to use for splitting the key from the value within a key-value pair.</para>
	/// </summary>
	public KeyValueProcessorDescriptor ValueSplit(string valueSplit)
	{
		ValueSplitValue = valueSplit;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (ExcludeKeysValue is not null)
		{
			writer.WritePropertyName("exclude_keys");
			JsonSerializer.Serialize(writer, ExcludeKeysValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("field_split");
		writer.WriteStringValue(FieldSplitValue);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		if (IncludeKeysValue is not null)
		{
			writer.WritePropertyName("include_keys");
			JsonSerializer.Serialize(writer, IncludeKeysValue, options);
		}

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(PrefixValue))
		{
			writer.WritePropertyName("prefix");
			writer.WriteStringValue(PrefixValue);
		}

		if (StripBracketsValue.HasValue)
		{
			writer.WritePropertyName("strip_brackets");
			writer.WriteBooleanValue(StripBracketsValue.Value);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		if (!string.IsNullOrEmpty(TrimKeyValue))
		{
			writer.WritePropertyName("trim_key");
			writer.WriteStringValue(TrimKeyValue);
		}

		if (!string.IsNullOrEmpty(TrimValueValue))
		{
			writer.WritePropertyName("trim_value");
			writer.WriteStringValue(TrimValueValue);
		}

		writer.WritePropertyName("value_split");
		writer.WriteStringValue(ValueSplitValue);
		writer.WriteEndObject();
	}
}