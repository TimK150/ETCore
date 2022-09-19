using System;
using ET;

namespace ET
{
	// 用来测试消息
	[MessageHandler]
	public class C2G_ISuperTestMessageHandler : AMRpcHandler<C2G_ISuperTestMessage, G2C_ISuperTestMessage>
	{
		protected override async ETTask Run(Session session, C2G_ISuperTestMessage request, G2C_ISuperTestMessage response, Action reply)
		{
            response.Message = $"request: {request.Info} ,收到時間: {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}";
            reply();
		}
	}
}
