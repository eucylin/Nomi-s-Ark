using UnityEngine;
using System.Collections;

public class CorgiScript : MonoBehaviour {
    public enum Direction
    {
        Left,
        Right
    }
    Animator m_anim;

	void Start () {
        m_anim = GetComponent<Animator>();
	}

	void Update () {
	    
	}

    public void PlayCorgiRunAnimation(Direction d)
    {
        if (d == Direction.Left)
            m_anim.Play("CorgiAnimation");
        else if (d == Direction.Right)
            ;
    }
}
