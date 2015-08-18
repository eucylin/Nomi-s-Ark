using UnityEngine;
using System.Collections;

public class SendAnswer : MonoBehaviour {

    public int id = 0;

    void OnClick()
    {
        GameController.Instance.CheckAnswer(1,0,id);
    }
}
