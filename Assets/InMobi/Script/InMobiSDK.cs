using UnityEngine;
using System.Collections;

public class InMobiSDK {

    private static string _appId = "c2879c6cb40d4bd2add0bfd627dd3d04";

    #if UNITY_ANDROID
    public static void Init() {
        InMobiAndroid.init(_appId, null);
    }

    public static void Load() {
        InMobiAndroid.loadInterstitial(_appId);
    }

    public static void Show() {
        InMobiAndroid.showInterstitial();
    }

    public static bool isAvailable {
        get {
            if (InMobiAndroid.getInterstitialState().IndexOf("READY") > -1)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }

    public static string GetStatus() {
        return InMobiAndroid.getInterstitialState();
    }
    #endif
}