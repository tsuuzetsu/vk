﻿using System;
using System.Runtime.Serialization;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	/// Магазин.
	/// </summary>
	[DataContract]
	public class Store
	{
		/// <summary>
		/// Идентификатор магазина;.
		/// </summary>
		public long? Id { get; set; }

		/// <summary>
		/// Название магазина;.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns></returns>
		public static Store FromJson(VkResponse response)
		{
			var store = new Store
			{
				Id = response["id"],
				Name = response["name"]
			};

			return store;
		}
	}
}