using UnityEngine;
using System.Collections;

public class MusicControl : MonoBehaviour {

    void OnClick()
    {
        Camera.main.GetComponent<AudioSource>().volume = GetComponent<UISlider>().value;
    }
}
