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

namespace Elastic.Clients.Elasticsearch.Nodes;

internal sealed partial class NodeJvmInfoConverter : JsonConverter<NodeJvmInfo>
{
	public override NodeJvmInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		IReadOnlyCollection<string> gcCollectors = default;
		IReadOnlyCollection<string> inputArguments = default;
		Elastic.Clients.Elasticsearch.Nodes.NodeInfoJvmMemory mem = default;
		IReadOnlyCollection<string> memoryPools = default;
		int pid = default;
		long startTimeInMillis = default;
		bool usingBundledJdk = default;
		object? usingCompressedOrdinaryObjectPointers = default;
		string version = default;
		string vmName = default;
		string vmVendor = default;
		string vmVersion = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "gc_collectors")
				{
					gcCollectors = JsonSerializer.Deserialize<IReadOnlyCollection<string>>(ref reader, options);
					continue;
				}

				if (property == "input_arguments")
				{
					inputArguments = JsonSerializer.Deserialize<IReadOnlyCollection<string>>(ref reader, options);
					continue;
				}

				if (property == "mem")
				{
					mem = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Nodes.NodeInfoJvmMemory>(ref reader, options);
					continue;
				}

				if (property == "memory_pools")
				{
					memoryPools = JsonSerializer.Deserialize<IReadOnlyCollection<string>>(ref reader, options);
					continue;
				}

				if (property == "pid")
				{
					pid = JsonSerializer.Deserialize<int>(ref reader, options);
					continue;
				}

				if (property == "start_time_in_millis")
				{
					startTimeInMillis = JsonSerializer.Deserialize<long>(ref reader, options);
					continue;
				}

				if (property == "using_bundled_jdk" || property == "bundled_jdk")
				{
					usingBundledJdk = JsonSerializer.Deserialize<bool>(ref reader, options);
					continue;
				}

				if (property == "using_compressed_ordinary_object_pointers")
				{
					usingCompressedOrdinaryObjectPointers = JsonSerializer.Deserialize<object?>(ref reader, options);
					continue;
				}

				if (property == "version")
				{
					version = JsonSerializer.Deserialize<string>(ref reader, options);
					continue;
				}

				if (property == "vm_name")
				{
					vmName = JsonSerializer.Deserialize<string>(ref reader, options);
					continue;
				}

				if (property == "vm_vendor")
				{
					vmVendor = JsonSerializer.Deserialize<string>(ref reader, options);
					continue;
				}

				if (property == "vm_version")
				{
					vmVersion = JsonSerializer.Deserialize<string>(ref reader, options);
					continue;
				}
			}
		}

		return new NodeJvmInfo { GcCollectors = gcCollectors, InputArguments = inputArguments, Mem = mem, MemoryPools = memoryPools, Pid = pid, StartTimeInMillis = startTimeInMillis, UsingBundledJdk = usingBundledJdk, UsingCompressedOrdinaryObjectPointers = usingCompressedOrdinaryObjectPointers, Version = version, VmName = vmName, VmVendor = vmVendor, VmVersion = vmVersion };
	}

	public override void Write(Utf8JsonWriter writer, NodeJvmInfo value, JsonSerializerOptions options)
	{
		throw new NotImplementedException("'NodeJvmInfo' is a readonly type, used only on responses and does not support being written to JSON.");
	}
}

[JsonConverter(typeof(NodeJvmInfoConverter))]
public sealed partial class NodeJvmInfo
{
	public IReadOnlyCollection<string> GcCollectors { get; init; }
	public IReadOnlyCollection<string> InputArguments { get; init; }
	public Elastic.Clients.Elasticsearch.Nodes.NodeInfoJvmMemory Mem { get; init; }
	public IReadOnlyCollection<string> MemoryPools { get; init; }
	public int Pid { get; init; }
	public long StartTimeInMillis { get; init; }
	public bool UsingBundledJdk { get; init; }
	public object? UsingCompressedOrdinaryObjectPointers { get; init; }
	public string Version { get; init; }
	public string VmName { get; init; }
	public string VmVendor { get; init; }
	public string VmVersion { get; init; }
}