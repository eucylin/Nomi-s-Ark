using UnityEngine;
using System.Collections;

public class MainSceneBack : MonoBehaviour {


    public GameObject HandBookPanel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        HandBookPanel.SetActive(false);
    }
}
