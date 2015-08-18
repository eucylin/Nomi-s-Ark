using UnityEngine;
using System.Collections;

public class BackGroundMoving : MonoBehaviour {

    //float timer = 0;

	void Update () {
        transform.Rotate(new Vector3(0,0,1), -90 * Time.deltaTime * 0.02f);
        //timer += Time.deltaTime;
        //if (timer >= 3)
        //{
        //    //transform.position = Vector3.zero;
        //    timer = 0;
        //}
	}
}
