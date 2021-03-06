﻿using System;
using ZKWeb.Logging;
using ZKWeb.Plugins.Common.Base.src.Components.ScheduledTasks.Interfaces;
using ZKWeb.Plugins.Shopping.Order.src.Domain.Services;
using ZKWebStandard.Ioc;

namespace ZKWeb.Plugins.Shopping.Order.src.Components.ScheduledTasks {
	/// <summary>
	/// 订单自动确认收货
	/// </summary>
	[ExportMany, SingletonReuse]
	public class OrderAutoConfirmer : IScheduledTaskExecutor {
		/// <summary>
		/// 任务键名
		/// </summary>
		public string Key { get { return "Shopping.Order.OrderAutoConfirmer"; } }

		/// <summary>
		/// 每小时执行一次
		/// </summary>
		public bool ShouldExecuteNow(DateTime lastExecuted) {
			return ((DateTime.UtcNow - lastExecuted).TotalHours > 1.0);
		}

		/// <summary>
		/// 订单自动确认收货
		/// </summary>
		public void Execute() {
			var orderManager = Application.Ioc.Resolve<SellerOrderManager>();
			var count = orderManager.AutoConfirmOrder();
			var logManager = Application.Ioc.Resolve<LogManager>();
			logManager.LogInfo(string.Format(
				"OrderAutoConfirmer executed, {0} order confirmed", count));
		}
	}
}
