using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDatabase : MonoBehaviour
{
    public static GameDatabase instance;

    public bool minigame1isDone;
    public bool minigame2isDone;

    private void Awake()
    {

        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void GameOver()
    {
        Debug.Log("is game over");
    }
}