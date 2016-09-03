﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ZKWeb.Plugins.Shopping.Product.src.Components.ProductMatchedDataMatchers.Interfaces;
using ZKWeb.Plugins.Shopping.Product.src.Domain.Entities;
using ZKWeb.Plugins.Shopping.Product.src.Domain.Extensions;
using ZKWeb.Plugins.Shopping.Product.src.Domain.Structs;
using ZKWeb.Server;
using ZKWebStandard.Extensions;
using ZKWebStandard.Ioc;

namespace ZKWeb.Plugins.Shopping.Product.src.Components.ProductMatchedDataMatchers {
	/// <summary>
	/// 匹配规格(销售属性)
	/// </summary>
	[ExportMany]
	public class PropertyMatcher : IProductMatchedDataMatcher {
		/// <summary>
		/// 判断是否匹配
		/// </summary>
		public bool IsMatched(ProductMatchParameters parameters, ProductMatchedData data) {
			// 获取规格的条件
			// 格式 [ { PropertyId: ..., PropertyValueId: ... }, ... ]
			var exceptedProperties = data.Conditions.GetProperties();
			if (exceptedProperties == null || !exceptedProperties.Any()) {
				return true; // 没有指定条件
			}
			// 判断参数中的规格值列表是否包含条件中的所有规格值
			// 例如 参数 { 颜色: 黑色, 尺码: XXS, 款式: 2013 }, 条件 { 颜色: 黑色, 尺码: XXS }时匹配成功
			// 参数的格式同上
			var incomeProperties = parameters.GetProperties();
			if (incomeProperties == null || !incomeProperties.Any()) {
				return false; // 有指定条件，但参数中没有包含任何规格值
			}
			var incomePropertiesMapping = new Dictionary<Guid, Guid?>();
			foreach (var obj in incomeProperties) {
				incomePropertiesMapping[obj.PropertyId] = obj.PropertyValueId;
			}
			return exceptedProperties.All(obj => {
				return incomePropertiesMapping.GetOrDefault(obj.PropertyId) == obj.PropertyValueId;
			});
		}

		/// <summary>
		/// 获取使用Javascript判断是否匹配的函数
		/// </summary>
		/// <returns></returns>
		public string GetJavascriptMatchFunction() {
			var pathManager = Application.Ioc.Resolve<PathManager>();
			return File.ReadAllText(pathManager.GetResourceFullPath(
				"static", "shopping.product.js", "matched_data_matchers", "property.matcher.js"));
		}
	}
}
