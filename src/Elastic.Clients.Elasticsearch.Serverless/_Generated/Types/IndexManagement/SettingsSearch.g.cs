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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class SettingsSearch
{
	[JsonInclude, JsonPropertyName("idle")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SearchIdle? Idle { get; set; }
	[JsonInclude, JsonPropertyName("slowlog")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogSettings? Slowlog { get; set; }
}

public sealed partial class SettingsSearchDescriptor : SerializableDescriptor<SettingsSearchDescriptor>
{
	internal SettingsSearchDescriptor(Action<SettingsSearchDescriptor> configure) => configure.Invoke(this);

	public SettingsSearchDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SearchIdle? IdleValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SearchIdleDescriptor IdleDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SearchIdleDescriptor> IdleDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogSettings? SlowlogValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogSettingsDescriptor SlowlogDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogSettingsDescriptor> SlowlogDescriptorAction { get; set; }

	public SettingsSearchDescriptor Idle(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SearchIdle? idle)
	{
		IdleDescriptor = null;
		IdleDescriptorAction = null;
		IdleValue = idle;
		return Self;
	}

	public SettingsSearchDescriptor Idle(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SearchIdleDescriptor descriptor)
	{
		IdleValue = null;
		IdleDescriptorAction = null;
		IdleDescriptor = descriptor;
		return Self;
	}

	public SettingsSearchDescriptor Idle(Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SearchIdleDescriptor> configure)
	{
		IdleValue = null;
		IdleDescriptor = null;
		IdleDescriptorAction = configure;
		return Self;
	}

	public SettingsSearchDescriptor Slowlog(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogSettings? slowlog)
	{
		SlowlogDescriptor = null;
		SlowlogDescriptorAction = null;
		SlowlogValue = slowlog;
		return Self;
	}

	public SettingsSearchDescriptor Slowlog(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogSettingsDescriptor descriptor)
	{
		SlowlogValue = null;
		SlowlogDescriptorAction = null;
		SlowlogDescriptor = descriptor;
		return Self;
	}

	public SettingsSearchDescriptor Slowlog(Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogSettingsDescriptor> configure)
	{
		SlowlogValue = null;
		SlowlogDescriptor = null;
		SlowlogDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IdleDescriptor is not null)
		{
			writer.WritePropertyName("idle");
			JsonSerializer.Serialize(writer, IdleDescriptor, options);
		}
		else if (IdleDescriptorAction is not null)
		{
			writer.WritePropertyName("idle");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SearchIdleDescriptor(IdleDescriptorAction), options);
		}
		else if (IdleValue is not null)
		{
			writer.WritePropertyName("idle");
			JsonSerializer.Serialize(writer, IdleValue, options);
		}

		if (SlowlogDescriptor is not null)
		{
			writer.WritePropertyName("slowlog");
			JsonSerializer.Serialize(writer, SlowlogDescriptor, options);
		}
		else if (SlowlogDescriptorAction is not null)
		{
			writer.WritePropertyName("slowlog");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.IndexManagement.SlowlogSettingsDescriptor(SlowlogDescriptorAction), options);
		}
		else if (SlowlogValue is not null)
		{
			writer.WritePropertyName("slowlog");
			JsonSerializer.Serialize(writer, SlowlogValue, options);
		}

		writer.WriteEndObject();
	}
}