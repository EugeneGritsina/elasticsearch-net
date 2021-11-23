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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement.ShardStores
{
	[JsonConverter(typeof(ShardStoreAllocationConverter))]
	public enum ShardStoreAllocation
	{
		Unused,
		Replica,
		Primary
	}

	public class ShardStoreAllocationConverter : JsonConverter<ShardStoreAllocation>
	{
		public override ShardStoreAllocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "unused":
					return ShardStoreAllocation.Unused;
				case "replica":
					return ShardStoreAllocation.Replica;
				case "primary":
					return ShardStoreAllocation.Primary;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ShardStoreAllocation value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ShardStoreAllocation.Unused:
					writer.WriteStringValue("unused");
					return;
				case ShardStoreAllocation.Replica:
					writer.WriteStringValue("replica");
					return;
				case ShardStoreAllocation.Primary:
					writer.WriteStringValue("primary");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ShardStoreStatusConverter))]
	public enum ShardStoreStatus
	{
		Yellow,
		Red,
		Green,
		All
	}

	public class ShardStoreStatusConverter : JsonConverter<ShardStoreStatus>
	{
		public override ShardStoreStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "yellow":
					return ShardStoreStatus.Yellow;
				case "red":
					return ShardStoreStatus.Red;
				case "green":
					return ShardStoreStatus.Green;
				case "all":
					return ShardStoreStatus.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ShardStoreStatus value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ShardStoreStatus.Yellow:
					writer.WriteStringValue("yellow");
					return;
				case ShardStoreStatus.Red:
					writer.WriteStringValue("red");
					return;
				case ShardStoreStatus.Green:
					writer.WriteStringValue("green");
					return;
				case ShardStoreStatus.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}
}