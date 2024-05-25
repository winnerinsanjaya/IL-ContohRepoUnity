using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    public void MoveSceneTo(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void SetMinigameStatus(bool cond)
    {
        if (cond)
        {
            GameDatabase.instance.minigame1isDone = true;
        }
        if (!cond)
        {
            GameDatabase.instance.minigame1isDone = false;
        }
    }
}
