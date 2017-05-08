using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveManager : MonoBehaviour
{

    public GameObject head;

    public static ViveManager Instance;

    void Awake() //This function is for preventing memory leak everytime a player connects and disconnects.
    {
        if (Instance == null)
            Instance = this;
    }

    void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }
}
