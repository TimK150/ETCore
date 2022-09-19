using ET;
namespace ET
{
	//测试向服务器发送消息
	[Message(HotfixOpcode.C2G_ISuperTestMessage)]
	public partial class C2G_ISuperTestMessage : IRequest
	{
	}

	//测试向服务器返回消息
	[Message(HotfixOpcode.G2C_ISuperTestMessage)]
	public partial class G2C_ISuperTestMessage : IResponse
	{
	}

}
namespace ET
{
	public static partial class HotfixOpcode
	{
		 public const ushort C2G_ISuperTestMessage = 1100;
		public const ushort G2C_ISuperTestMessage = 1101;
	}
}
