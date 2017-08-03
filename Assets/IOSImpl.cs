using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cn.sharepay.unity3d
{
//#if UNITY_IOS
    public class IOSImpl : SharePayImpl
    {
        private string _callbackObjectName = "Main Camera";
		private string _appID;

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
    }
//#endif
}