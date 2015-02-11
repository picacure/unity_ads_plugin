using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InMobiTest : MonoBehaviour {

    private Text _loadState;

    // Use this for initialization
    void Awake () {

        InMobiSDK.Init();
    }

    void Start() {
        _loadState = GameObject.Find("LoadState").GetComponent<Text>();
    }

    public void LoadAds() {

        InMobiSDK.Load();

    }

    public void ShowAds() {
        InMobiSDK.Show();
    }

    void Update() {
        _loadState.text = "interstitial state: " + InMobiSDK.GetStatus() + " \n Is Ready? " + InMobiSDK.isAvailable;
    }
}
