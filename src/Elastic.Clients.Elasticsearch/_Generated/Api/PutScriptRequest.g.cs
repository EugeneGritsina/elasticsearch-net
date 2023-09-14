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

namespace Elastic.Clients.Elasticsearch;

public sealed class PutScriptRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Specify timeout for connection to master</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Explicit operation timeout</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Creates or updates a script.</para>
/// </summary>
public sealed partial class PutScriptRequest : PlainRequest<PutScriptRequestParameters>
{
	public PutScriptRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	public PutScriptRequest(Elastic.Clients.Elasticsearch.Id id, Elastic.Clients.Elasticsearch.Name? context) : base(r => r.Required("id", id).Optional("context", context))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespacePutScript;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "put_script";

	/// <summary>
	/// <para>Specify timeout for connection to master</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Explicit operation timeout</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.StoredScript Script { get; set; }
}

/// <summary>
/// <para>Creates or updates a script.</para>
/// </summary>
public sealed partial class PutScriptRequestDescriptor<TDocument> : RequestDescriptor<PutScriptRequestDescriptor<TDocument>, PutScriptRequestParameters>
{
	internal PutScriptRequestDescriptor(Action<PutScriptRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PutScriptRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	public PutScriptRequestDescriptor(Elastic.Clients.Elasticsearch.Id id, Elastic.Clients.Elasticsearch.Name? context) : base(r => r.Required("id", id).Optional("context", context))
	{
	}

	internal PutScriptRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespacePutScript;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "put_script";

	public PutScriptRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutScriptRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public PutScriptRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public PutScriptRequestDescriptor<TDocument> Context(Elastic.Clients.Elasticsearch.Name? context)
	{
		RouteValues.Optional("context", context);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.StoredScript ScriptValue { get; set; }
	private StoredScriptDescriptor ScriptDescriptor { get; set; }
	private Action<StoredScriptDescriptor> ScriptDescriptorAction { get; set; }

	public PutScriptRequestDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.StoredScript script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public PutScriptRequestDescriptor<TDocument> Script(StoredScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public PutScriptRequestDescriptor<TDocument> Script(Action<StoredScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new StoredScriptDescriptor(ScriptDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Creates or updates a script.</para>
/// </summary>
public sealed partial class PutScriptRequestDescriptor : RequestDescriptor<PutScriptRequestDescriptor, PutScriptRequestParameters>
{
	internal PutScriptRequestDescriptor(Action<PutScriptRequestDescriptor> configure) => configure.Invoke(this);

	public PutScriptRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	public PutScriptRequestDescriptor(Elastic.Clients.Elasticsearch.Id id, Elastic.Clients.Elasticsearch.Name? context) : base(r => r.Required("id", id).Optional("context", context))
	{
	}

	internal PutScriptRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespacePutScript;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "put_script";

	public PutScriptRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutScriptRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public PutScriptRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public PutScriptRequestDescriptor Context(Elastic.Clients.Elasticsearch.Name? context)
	{
		RouteValues.Optional("context", context);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.StoredScript ScriptValue { get; set; }
	private StoredScriptDescriptor ScriptDescriptor { get; set; }
	private Action<StoredScriptDescriptor> ScriptDescriptorAction { get; set; }

	public PutScriptRequestDescriptor Script(Elastic.Clients.Elasticsearch.StoredScript script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public PutScriptRequestDescriptor Script(StoredScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public PutScriptRequestDescriptor Script(Action<StoredScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new StoredScriptDescriptor(ScriptDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}