using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cn.sharepay.unity3d
{
    public class SendContent
    {
        Hashtable SendParams = new Hashtable();

        /*iOS/Android*/
        public void SetTitle(String title)
        {
            SendParams["title"] = title;
        }

        /*iOS/Android*/
        public void SetText(String text)
        {
            SendParams["text"] = text;
        }

        /*iOS/Android*/
        public void SetUrl(String url)
        {
            SendParams["url"] = url;
        }

        public String GetShareParamsStr()
        {
            String jsonStr = MiniJSON.jsonEncode(SendParams);
            Debug.Log("ParseShareParams  ===>>> " + jsonStr);
            return jsonStr;
        }
    }
}

