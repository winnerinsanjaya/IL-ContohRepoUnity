using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableButtonIfDone : MonoBehaviour
{
    void Start()
    {
        if (GameDatabase.instance.minigame1isDone)
        {
            this.gameObject.SetActive(false);
        }
    }
}
