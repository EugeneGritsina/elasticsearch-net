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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class FieldAndFormat
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public string Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("include_unmapped")]
		public bool? IncludeUnmapped { get; set; }
	}

	public sealed partial class FieldAndFormatDescriptor<T> : DescriptorBase<FieldAndFormatDescriptor<T>>
	{
		public FieldAndFormatDescriptor()
		{
		}

		internal FieldAndFormatDescriptor(Action<FieldAndFormatDescriptor<T>> configure) => configure.Invoke(this);
		internal string FieldValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal bool? IncludeUnmappedValue { get; private set; }

		public FieldAndFormatDescriptor<T> Field(string field) => Assign(field, (a, v) => a.FieldValue = v);
		public FieldAndFormatDescriptor<T> Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public FieldAndFormatDescriptor<T> IncludeUnmapped(bool? includeUnmapped = true) => Assign(includeUnmapped, (a, v) => a.IncludeUnmappedValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (IncludeUnmappedValue.HasValue)
			{
				writer.WritePropertyName("include_unmapped");
				writer.WriteBooleanValue(IncludeUnmappedValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}