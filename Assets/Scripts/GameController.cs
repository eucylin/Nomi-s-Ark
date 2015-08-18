using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController Instance;

    public int puzzleCount = 0;

    public GameObject pre_Correct;
    public GameObject pre_Wrong;
    int[,] Ans = new int[10,10];

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
        Ans[1,0] = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    GameObject tmp;
    public void CheckAnswer(int gameType, int Qid,int ans)
    {
        if (ans == Ans[gameType,Qid])
        {
            Instantiate(pre_Correct);
        }
        else
        {
            tmp = Instantiate(pre_Wrong);
            StartCoroutine(WaitAndDestroy());
        }
    }

    IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(tmp);
    }

}
