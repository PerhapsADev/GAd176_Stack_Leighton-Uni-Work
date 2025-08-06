using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    // public float currentTime = 

    private void Awake()
    {
        // Make sure that we only have ONE copy of the GameManager
        //
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public static GameManager Instance
    {
        get { return instance; }
    }
}

