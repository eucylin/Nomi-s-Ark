using UnityEngine;
using System.Collections;

public class BackOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        transform.Rotate(new Vector3(0,1,0),90);
    }
}
