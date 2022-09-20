using System.Collections.Generic;


namespace ET
{
    public static class RealmLobbyAddressHelper
    {
		public static StartSceneConfig GetLobby(int zone)
		{
			List<StartSceneConfig> zoneLobby = StartSceneConfigCategory.Instance.Lobby[zone];

			int n = RandomHelper.RandomNumber(0, zoneLobby.Count);

			return zoneLobby[n];
		}
	}
}
