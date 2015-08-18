using UnityEngine;
using System.Collections;

public class AutoDestroyer : MonoBehaviour {

    void Start()
    {
        StartCoroutine(Counter());
    }

    IEnumerator Counter()
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(gameObject);
    }
}
