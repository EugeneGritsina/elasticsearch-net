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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class Translog
{
	/// <summary>
	/// <para>Whether or not to `fsync` and commit the translog after every index, delete, update, or bulk request.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("durability")]
	public Elastic.Clients.Elasticsearch.IndexManagement.TranslogDurability? Durability { get; set; }

	/// <summary>
	/// <para>The translog stores all operations that are not yet safely persisted in Lucene (i.e., are not<br/>part of a Lucene commit point). Although these operations are available for reads, they will need<br/>to be replayed if the shard was stopped and had to be recovered. This setting controls the<br/>maximum total size of these operations, to prevent recoveries from taking too long. Once the<br/>maximum size has been reached a flush will happen, generating a new Lucene commit point.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("flush_threshold_size")]
	public Elastic.Clients.Elasticsearch.ByteSize? FlushThresholdSize { get; set; }
	[JsonInclude, JsonPropertyName("retention")]
	public Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetention? Retention { get; set; }

	/// <summary>
	/// <para>How often the translog is fsynced to disk and committed, regardless of write operations.<br/>Values less than 100ms are not allowed.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sync_interval")]
	public Elastic.Clients.Elasticsearch.Duration? SyncInterval { get; set; }
}

public sealed partial class TranslogDescriptor : SerializableDescriptor<TranslogDescriptor>
{
	internal TranslogDescriptor(Action<TranslogDescriptor> configure) => configure.Invoke(this);

	public TranslogDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.IndexManagement.TranslogDurability? DurabilityValue { get; set; }
	private Elastic.Clients.Elasticsearch.ByteSize? FlushThresholdSizeValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetention? RetentionValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetentionDescriptor RetentionDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetentionDescriptor> RetentionDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? SyncIntervalValue { get; set; }

	/// <summary>
	/// <para>Whether or not to `fsync` and commit the translog after every index, delete, update, or bulk request.</para>
	/// </summary>
	public TranslogDescriptor Durability(Elastic.Clients.Elasticsearch.IndexManagement.TranslogDurability? durability)
	{
		DurabilityValue = durability;
		return Self;
	}

	/// <summary>
	/// <para>The translog stores all operations that are not yet safely persisted in Lucene (i.e., are not<br/>part of a Lucene commit point). Although these operations are available for reads, they will need<br/>to be replayed if the shard was stopped and had to be recovered. This setting controls the<br/>maximum total size of these operations, to prevent recoveries from taking too long. Once the<br/>maximum size has been reached a flush will happen, generating a new Lucene commit point.</para>
	/// </summary>
	public TranslogDescriptor FlushThresholdSize(Elastic.Clients.Elasticsearch.ByteSize? flushThresholdSize)
	{
		FlushThresholdSizeValue = flushThresholdSize;
		return Self;
	}

	public TranslogDescriptor Retention(Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetention? retention)
	{
		RetentionDescriptor = null;
		RetentionDescriptorAction = null;
		RetentionValue = retention;
		return Self;
	}

	public TranslogDescriptor Retention(Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetentionDescriptor descriptor)
	{
		RetentionValue = null;
		RetentionDescriptorAction = null;
		RetentionDescriptor = descriptor;
		return Self;
	}

	public TranslogDescriptor Retention(Action<Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetentionDescriptor> configure)
	{
		RetentionValue = null;
		RetentionDescriptor = null;
		RetentionDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>How often the translog is fsynced to disk and committed, regardless of write operations.<br/>Values less than 100ms are not allowed.</para>
	/// </summary>
	public TranslogDescriptor SyncInterval(Elastic.Clients.Elasticsearch.Duration? syncInterval)
	{
		SyncIntervalValue = syncInterval;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DurabilityValue is not null)
		{
			writer.WritePropertyName("durability");
			JsonSerializer.Serialize(writer, DurabilityValue, options);
		}

		if (FlushThresholdSizeValue is not null)
		{
			writer.WritePropertyName("flush_threshold_size");
			JsonSerializer.Serialize(writer, FlushThresholdSizeValue, options);
		}

		if (RetentionDescriptor is not null)
		{
			writer.WritePropertyName("retention");
			JsonSerializer.Serialize(writer, RetentionDescriptor, options);
		}
		else if (RetentionDescriptorAction is not null)
		{
			writer.WritePropertyName("retention");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.TranslogRetentionDescriptor(RetentionDescriptorAction), options);
		}
		else if (RetentionValue is not null)
		{
			writer.WritePropertyName("retention");
			JsonSerializer.Serialize(writer, RetentionValue, options);
		}

		if (SyncIntervalValue is not null)
		{
			writer.WritePropertyName("sync_interval");
			JsonSerializer.Serialize(writer, SyncIntervalValue, options);
		}

		writer.WriteEndObject();
	}
}