using System;


namespace ET
{
	[ActorMessageHandler]
	public class R2G_GetLoginKey2Handler : AMActorRpcHandler<Scene, R2G_GetLoginKey2, G2R_GetLoginKey2>
	{
		protected override async ETTask Run(Scene scene, R2G_GetLoginKey2 request, G2R_GetLoginKey2 response, Action reply)
		{
			long key = RandomHelper.RandInt64();
			//response.Message = "hello Lobby";
			scene.GetComponent<LobbySessionKeyComponent>().Add(key, request.Account);
			//scene.GetComponent<GateSessionKeyComponent>().Add(key, request.Account);
			response.Key = key;
			response.GateId = scene.Id;
			Console.Write("\n hello Lobby \n");
			reply();
			await ETTask.CompletedTask;
		}
	}
}
