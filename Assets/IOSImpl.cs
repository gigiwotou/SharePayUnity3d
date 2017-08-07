using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace cn.sharepay.unity3d
{
    #if UNITY_IOS
    public class IOSImpl : SharePayImpl
    {
        private string _callbackObjectName = "Main Camera";
        private string _appID;

        [DllImport("__Internal")]
        private static extern void registerApp(string appid);
        [DllImport("__Internal")]
        private static extern void sendURLToSS(string url, string title, string describe);

        public IOSImpl(GameObject go)
        {
            try
            {
                _callbackObjectName = go.name;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        public override void InitApp(string appid)
        {
            _appID = appid;            
        }

        public override void SendAppToWXSceneSession(string title, string describe)
        {
            
        }

        public override void SendURLToWXSceneSession(string url, string title, string describe)
        {
            sendURLToSS(url, title, describe);
        }
    }
#endif
}