using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharePay : MonoBehaviour {

    AndroidJavaObject sharePay;
    public string appid;

    // Use this for initialization
    void Start () {
        sharePay = new AndroidJavaObject("com.wotou.SharePay.WeChatShare");
        sharePay.Call("initappid", transform.name, appid, 1);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShareWX()
    {
        sharePay.Call("shareToWeChat", "微信分享", "www.163.com", "蛇王争霸");
    }
}
