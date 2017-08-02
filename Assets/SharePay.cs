using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharePay : MonoBehaviour {

    AndroidJavaObject sharePay;
    public string appid;

    // Use this for initialization
    void Start () {
        //sharePay = new AndroidJavaClass("com.wotou.SharePay.WeChatShare");
        
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        sharePay = jc.GetStatic<AndroidJavaObject>("currentActivity");
        sharePay.Call<string>("initappid", transform.name, appid, 1);

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void ShareWX()
    {
        sharePay.Call("shareToWeChat", "微信分享", "www.163.com", "蛇王争霸");
    }

    public void SayHello()
    {
        sharePay.Call("SayHello", "Android hello");
    }

    public void SendAppToWX()
    {
        sharePay.Call("SendAppToWX", "东北麻将", "自摸，杠花，四核");
    }

    public void SendTextToWX()
    {
        sharePay.Call("SendTextToWX", "东北麻将");
    }
}
