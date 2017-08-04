using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cn.sharepay.unity3d
{
    public abstract class SharePayImpl
    {
        public abstract void InitApp(string appid);

        public abstract void SendURLToWXSceneSession(string url, string title, string describe);
        public abstract void SendAppToWXSceneSession(string title, string describe);
    }
}

