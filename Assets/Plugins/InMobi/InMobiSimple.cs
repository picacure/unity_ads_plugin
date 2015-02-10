﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Prime31;

public class InMobiSimple {

    #if UNITY_ANDROID
    private string _appId = "c2879c6cb40d4bd2add0bfd627dd3d04";
    private static AndroidJavaObject _plugin;

    static InMobiSimple()
    {
        if( Application.platform != RuntimePlatform.Android )
            return;

        using( var pluginClass = new AndroidJavaClass( "com.prime31.InMobiPlugin" ) )
        _plugin = pluginClass.CallStatic<AndroidJavaObject>( "instance" );
    }

    public static void init(string appId, Dictionary<string, string> optionalInMobiParams = null)
    {
        if (Application.platform != RuntimePlatform.Android)
            return;

        _plugin.Call("initialize", appId, optionalInMobiParams != null ? optionalInMobiParams.toJson() : string.Empty);
    }

    public static void loadInterstitial(string appId)
    {
        if (Application.platform != RuntimePlatform.Android)
            return;

        _plugin.Call("loadInterstitial", appId);
    }

    public static void showInterstitial()
    {
        if (Application.platform != RuntimePlatform.Android)
            return;

        _plugin.Call("showInterstitial");
    }

    public static string getInterstitialState()
    {
        if (Application.platform != RuntimePlatform.Android)
            return "None";
        return _plugin.Call<string>("getInterstitialState");
    }

    #endif
}
