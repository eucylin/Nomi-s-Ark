using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController Instance;

    public int puzzleCount = 0;

    void Awake()
    {
        //We could share ONE GameController between all scenes
        //It might cause multiple instance if we dont use it carefully
        //We will deal with this in Start function. 
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        Instance = this;
        //If there are more than one GameController
        GameObject[] arrG = GameObject.FindGameObjectsWithTag("GameController");
        if (arrG.Length > 1)
            for (int i = 1; i < arrG.Length; i++) //Destroy all other GameObjects, except the first one
                Destroy(arrG[i]);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

}
