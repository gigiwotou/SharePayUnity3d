using System.Collections;
using System.Collections.Generic;
using cn.sharepay.unity3d;
using UnityEngine;

public class SharePay : MonoBehaviour {

    public SharePayImpl shareSDKUtils;
    public string appid;

    private void Awake()
    {
#if UNITY_ANDROID
        shareSDKUtils = new AndroidImpl(gameObject);
        shareSDKUtils.InitApp(appid);
#elif UNITY_IPHONE
		shareSDKUtils = new IOSImpl(gameObject);
        shareSDKUtils.InitApp(appid);
#endif
    }
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void ShareWX()
    {
        shareSDKUtils.SendURLToWXSceneSession("sohu.com", "ym分享测试", "这是来着地狱的呼唤。");
    }

    public void OnError(string state)
    {
        int sharestate = int.Parse(state);
        if(sharestate == 0)//分享成功
        {
            Debug.Log("分享成功");
        }
        Debug.Log("OnError=" + state);
    }
}
