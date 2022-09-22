using System;
using ET;
using System.Threading.Tasks;

namespace ETHotfix.Handler
{
	[MessageHandler]
	public class C2R_Login2Handler : AMRpcHandler<C2R_Login2, R2C_Login2>
	{
		protected override async ETTask Run(Session session, C2R_Login2 request, R2C_Login2 response, Action reply)
		{
			// 取Lobby
			StartSceneConfig LobbyConfig = RealmLobbyAddressHelper.GetLobby(session.DomainZone());
			// 随机分配一个Gate
			//StartSceneConfig config = RealmGateAddressHelper.GetGate(session.DomainZone());
			//Log.Debug($"gate address: {MongoHelper.ToJson(config)}");

			// 向gate请求一个key,客户端可以拿着这个key连接gate
			/*
			G2R_GetLoginKey g2RGetLoginKey = (G2R_GetLoginKey)await ActorMessageSenderComponent.Instance.Call(
				config.SceneId, new R2G_GetLoginKey() { Account = request.Account });
			*/

			G2R_GetLoginKey2 g2RGetLoginKey2 = (G2R_GetLoginKey2)await ActorMessageSenderComponent.Instance.Call(
				LobbyConfig.SceneId, new R2G_GetLoginKey2() { Account = request.Account });

			response.Address = LobbyConfig.OuterAddress.Replace("http:", "ws:");
			response.Key = g2RGetLoginKey2.Key;
			response.GateId = g2RGetLoginKey2.GateId;

			reply();
		}
	}
}
