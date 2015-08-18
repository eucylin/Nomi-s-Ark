using UnityEngine;
using System.Collections;

public class OpenHandBook : MonoBehaviour {

    public GameObject HandBookPanel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        HandBookPanel.SetActive(true);
    }
}
