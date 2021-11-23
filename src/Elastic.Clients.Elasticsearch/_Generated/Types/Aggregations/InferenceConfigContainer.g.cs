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
	public partial class InferenceConfigContainer
	{
		[JsonInclude]
		[JsonPropertyName("regression")]
		public Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptions? Regression { get; set; }

		[JsonInclude]
		[JsonPropertyName("classification")]
		public Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptions? Classification { get; set; }
	}

	public sealed partial class InferenceConfigContainerDescriptor<T> : DescriptorBase<InferenceConfigContainerDescriptor<T>>
	{
		public InferenceConfigContainerDescriptor()
		{
		}

		internal InferenceConfigContainerDescriptor(Action<InferenceConfigContainerDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptions? RegressionValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptions? ClassificationValue { get; private set; }

		internal RegressionInferenceOptionsDescriptor<T> RegressionDescriptor { get; private set; }

		internal ClassificationInferenceOptionsDescriptor ClassificationDescriptor { get; private set; }

		internal Action<RegressionInferenceOptionsDescriptor<T>> RegressionDescriptorAction { get; private set; }

		internal Action<ClassificationInferenceOptionsDescriptor> ClassificationDescriptorAction { get; private set; }

		public InferenceConfigContainerDescriptor<T> Regression(Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptions? regression)
		{
			RegressionDescriptor = null;
			RegressionDescriptorAction = null;
			return Assign(regression, (a, v) => a.RegressionValue = v);
		}

		public InferenceConfigContainerDescriptor<T> Regression(Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptionsDescriptor<T> descriptor)
		{
			RegressionValue = null;
			RegressionDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.RegressionDescriptor = v);
		}

		public InferenceConfigContainerDescriptor<T> Regression(Action<Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptionsDescriptor<T>> configure)
		{
			RegressionValue = null;
			RegressionDescriptorAction = null;
			return Assign(configure, (a, v) => a.RegressionDescriptorAction = v);
		}

		public InferenceConfigContainerDescriptor<T> Classification(Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptions? classification)
		{
			ClassificationDescriptor = null;
			ClassificationDescriptorAction = null;
			return Assign(classification, (a, v) => a.ClassificationValue = v);
		}

		public InferenceConfigContainerDescriptor<T> Classification(Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptionsDescriptor descriptor)
		{
			ClassificationValue = null;
			ClassificationDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ClassificationDescriptor = v);
		}

		public InferenceConfigContainerDescriptor<T> Classification(Action<Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptionsDescriptor> configure)
		{
			ClassificationValue = null;
			ClassificationDescriptorAction = null;
			return Assign(configure, (a, v) => a.ClassificationDescriptorAction = v);
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (RegressionDescriptor is not null)
			{
				writer.WritePropertyName("regression");
				JsonSerializer.Serialize(writer, RegressionDescriptor, options);
			}
			else if (RegressionDescriptorAction is not null)
			{
				writer.WritePropertyName("regression");
				JsonSerializer.Serialize(writer, new RegressionInferenceOptionsDescriptor<T>(RegressionDescriptorAction), options);
			}
			else if (RegressionValue is not null)
			{
				writer.WritePropertyName("regression");
				JsonSerializer.Serialize(writer, RegressionValue, options);
			}

			if (ClassificationDescriptor is not null)
			{
				writer.WritePropertyName("classification");
				JsonSerializer.Serialize(writer, ClassificationDescriptor, options);
			}
			else if (ClassificationDescriptorAction is not null)
			{
				writer.WritePropertyName("classification");
				JsonSerializer.Serialize(writer, new ClassificationInferenceOptionsDescriptor(ClassificationDescriptorAction), options);
			}
			else if (ClassificationValue is not null)
			{
				writer.WritePropertyName("classification");
				JsonSerializer.Serialize(writer, ClassificationValue, options);
			}

			writer.WriteEndObject();
		}
	}
}