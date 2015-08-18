using UnityEngine;
using System.Collections;

public class MidHot : MonoBehaviour {

    public GameObject ShowUp;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        ShowUp.SetActive(true);
    }
}
