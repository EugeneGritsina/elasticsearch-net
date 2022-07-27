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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public interface ISmoothingModelVariant
	{
	}

	[JsonConverter(typeof(SmoothingModelContainerConverter))]
	public sealed partial class SmoothingModelContainer
	{
		public SmoothingModelContainer(string variantName, ISmoothingModelVariant variant)
		{
			if (variantName is null)
				throw new ArgumentNullException(nameof(variantName));
			if (variant is null)
				throw new ArgumentNullException(nameof(variant));
			if (string.IsNullOrWhiteSpace(variantName))
				throw new ArgumentException("Variant name must not be empty or whitespace.");
			VariantName = variantName;
			Variant = variant;
		}

		internal ISmoothingModelVariant Variant { get; }

		internal string VariantName { get; }

		public static SmoothingModelContainer Laplace(Elastic.Clients.Elasticsearch.LaplaceSmoothingModel laplaceSmoothingModel) => new SmoothingModelContainer("laplace", laplaceSmoothingModel);
		public static SmoothingModelContainer LinearInterpolation(Elastic.Clients.Elasticsearch.LinearInterpolationSmoothingModel linearInterpolationSmoothingModel) => new SmoothingModelContainer("linear_interpolation", linearInterpolationSmoothingModel);
		public static SmoothingModelContainer StupidBackoff(Elastic.Clients.Elasticsearch.StupidBackoffSmoothingModel stupidBackoffSmoothingModel) => new SmoothingModelContainer("stupid_backoff", stupidBackoffSmoothingModel);
	}

	internal sealed class SmoothingModelContainerConverter : JsonConverter<SmoothingModelContainer>
	{
		public override SmoothingModelContainer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new JsonException("Expected start token.");
			}

			reader.Read();
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected property name token.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "laplace")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.LaplaceSmoothingModel?>(ref reader, options);
				reader.Read();
				return new SmoothingModelContainer(propertyName, variant);
			}

			if (propertyName == "linear_interpolation")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.LinearInterpolationSmoothingModel?>(ref reader, options);
				reader.Read();
				return new SmoothingModelContainer(propertyName, variant);
			}

			if (propertyName == "stupid_backoff")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.StupidBackoffSmoothingModel?>(ref reader, options);
				reader.Read();
				return new SmoothingModelContainer(propertyName, variant);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, SmoothingModelContainer value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "laplace":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.LaplaceSmoothingModel>(writer, (Elastic.Clients.Elasticsearch.LaplaceSmoothingModel)value.Variant, options);
					break;
				case "linear_interpolation":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.LinearInterpolationSmoothingModel>(writer, (Elastic.Clients.Elasticsearch.LinearInterpolationSmoothingModel)value.Variant, options);
					break;
				case "stupid_backoff":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.StupidBackoffSmoothingModel>(writer, (Elastic.Clients.Elasticsearch.StupidBackoffSmoothingModel)value.Variant, options);
					break;
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class SmoothingModelContainerDescriptor<TDocument> : SerializableDescriptorBase<SmoothingModelContainerDescriptor<TDocument>>
	{
		internal SmoothingModelContainerDescriptor(Action<SmoothingModelContainerDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SmoothingModelContainerDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal SmoothingModelContainer Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(ISmoothingModelVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new SmoothingModelContainer(variantName, variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void Laplace(LaplaceSmoothingModel variant) => Set(variant, "laplace");
		public void Laplace(Action<LaplaceSmoothingModelDescriptor> configure) => Set(configure, "laplace");
		public void LinearInterpolation(LinearInterpolationSmoothingModel variant) => Set(variant, "linear_interpolation");
		public void LinearInterpolation(Action<LinearInterpolationSmoothingModelDescriptor> configure) => Set(configure, "linear_interpolation");
		public void StupidBackoff(StupidBackoffSmoothingModel variant) => Set(variant, "stupid_backoff");
		public void StupidBackoff(Action<StupidBackoffSmoothingModelDescriptor> configure) => Set(configure, "stupid_backoff");
	}

	public sealed partial class SmoothingModelContainerDescriptor : SerializableDescriptorBase<SmoothingModelContainerDescriptor>
	{
		internal SmoothingModelContainerDescriptor(Action<SmoothingModelContainerDescriptor> configure) => configure.Invoke(this);
		public SmoothingModelContainerDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal SmoothingModelContainer Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(ISmoothingModelVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new SmoothingModelContainer(variantName, variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void Laplace(LaplaceSmoothingModel variant) => Set(variant, "laplace");
		public void Laplace(Action<LaplaceSmoothingModelDescriptor> configure) => Set(configure, "laplace");
		public void LinearInterpolation(LinearInterpolationSmoothingModel variant) => Set(variant, "linear_interpolation");
		public void LinearInterpolation(Action<LinearInterpolationSmoothingModelDescriptor> configure) => Set(configure, "linear_interpolation");
		public void StupidBackoff(StupidBackoffSmoothingModel variant) => Set(variant, "stupid_backoff");
		public void StupidBackoff(Action<StupidBackoffSmoothingModelDescriptor> configure) => Set(configure, "stupid_backoff");
	}
}