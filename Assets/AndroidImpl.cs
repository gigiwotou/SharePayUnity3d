using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace cn.sharepay.unity3d
{
#if UNITY_ANDROID
    public class AndroidImpl : SharePayImpl
    {
        private AndroidJavaObject sharePay;

        private string _callbackObjectName = "Main Camera";
        private string _appID;

        public AndroidImpl(GameObject go)
        {
            try
            {
                AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                sharePay = jc.GetStatic<AndroidJavaObject>("currentActivity");
                _callbackObjectName = go.name;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        public override void InitApp(string appid)
        {
            sharePay.Call<string>("initappid", _callbackObjectName, appid, 1);
            _appID = appid;
        }
    }
#endif
}

