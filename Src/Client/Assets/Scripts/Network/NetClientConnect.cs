using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetClientConnect : MonoBehaviour
{
    private void Awake()
    {
        ConnectNetClient();
    }

    private void ConnectNetClient()
    {
        Network.NetClient.Instance.Init("127.0.0.1", 8000);
        Network.NetClient.Instance.Connect(1);
        Common.Log.Init("network connected");

        //测试第一次发送信息。
        SkillBridge.Message.NetMessage msg = new SkillBridge.Message.NetMessage();
        msg.Request = new SkillBridge.Message.NetMessageRequest();
        msg.Request.firstRequest = new SkillBridge.Message.FirstTestRequest();
        msg.Request.firstRequest.Helloworld = "Hello World";
        Network.NetClient.Instance.SendMessage(msg);
        //
    }
}
