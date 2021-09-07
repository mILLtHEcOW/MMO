using Common;
using Network;
using SkillBridge.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Services
{
    class HelloWorldServices : Singleton<HelloWorldServices>
    {
        public void init()
        {
           
        }

        public void Start()
        {
            MessageDistributer<NetConnection<NetSession>>.Instance.Subscribe<FirstTestRequest>(this.onFirstTestRequest);
        }

        void onFirstTestRequest(NetConnection<NetSession> sender, FirstTestRequest request)
        {
            Log.InfoFormat("FirstTestRequest: HelloWorld:{0}", request.helloWrold);
        }

        public void Stop()
        {
            MessageDistributer<NetConnection<NetSession>>.Instance.Unsubscribe<FirstTestRequest>(this.onFirstTestRequest);

        }
    }
}
