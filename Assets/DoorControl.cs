using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    void Start()
    {
        if (GameDatabase.instance.minigame1isDone)
        {
            this.gameObject.SetActive(false);
        }
    }
}
