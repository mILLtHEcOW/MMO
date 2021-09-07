using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Network.NetClient.Instance.Init("127.0.0.1", 8000);
        Network.NetClient.Instance.Connect(1);



        SkillBridge.Message.NetMessage msg = new SkillBridge.Message.NetMessage();
        msg.Request = new SkillBridge.Message.NetMessageRequest();
        msg.Request.FirsttestRequest = new SkillBridge.Message.FirstTestRequest();
        msg.Request.FirsttestRequest.helloWrold = "helloWorld";
        Network.NetClient.Instance.SendMessage(msg);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
