using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetClientConnect : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void ConnectNetClient()
    {
        Network.NetClient.Instance.Init("127.0.0.1", 8000);
        Network.NetClient.Instance.Connect(1);
        SkillBridge.Message.NetMessage msg = new SkillBridge.Message.NetMessage();
        msg.Request = new SkillBridge.Message.NetMessageRequest();
        msg.Request.FirsttestRequest = new SkillBridge.Message.FirstTestRequest();
        msg.Request.FirsttestRequest.helloWrold = "helloWorld";
        Network.NetClient.Instance.SendMessage(msg);
    }
}
