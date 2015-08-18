using UnityEngine;
using System.Collections;

public class BearOnClick : MonoBehaviour {


    public GameObject OpenWikiPanel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        OpenWikiPanel.SetActive(true);
    }
}
