using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InMobiTest : MonoBehaviour {

    private Text _loadState;

    // Use this for initialization
    void Awake () {

        InMobiSimple.init("c2879c6cb40d4bd2add0bfd627dd3d04", null);
    }

    void Start() {

        InMobiSimple.loadInterstitial("c2879c6cb40d4bd2add0bfd627dd3d04");


        _loadState = GameObject.Find("LoadState").GetComponent<Text>();
    }

    public void LoadAds() {

        InMobiSimple.loadInterstitial("c2879c6cb40d4bd2add0bfd627dd3d04");

    }

    public void ShowAds() {
        InMobiSimple.showInterstitial();
    }

    void Update() {
        _loadState.text = "interstitial state: " + InMobiSimple.getInterstitialState();
    }
}
