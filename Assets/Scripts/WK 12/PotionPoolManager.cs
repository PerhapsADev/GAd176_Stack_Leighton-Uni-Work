using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PotionPoolManager : MonoBehaviour
{
    // We only want ONE potionPoolManager. Make singleton.
    public static PotionPoolManager Instance;

    // Define objects being pooled
    // and how many there could be

    public GameObject jumpPotionPrefab;
    public int poolSize = 10;

    // The pool of potions
    private List<GameObject> jumpPotionPool;

    private void Awake()
    {
        Instance = this;
        InitialiseJumpPotionPool();
    }

    private void InitialiseJumpPotionPool()
    {
        jumpPotionPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject jumpPotion = Instantiate(jumpPotionPrefab);
            jumpPotion.SetActive(false);
            jumpPotionPool.Add(jumpPotion);
        }

    }

    public GameObject GetPooledJumpPotion()
    {
        // Retrieve the first avaliable jump potion.
        foreach (var jumpPotion in jumpPotionPool)
        {
            if (!jumpPotion.activeInHierarchy)
            {
                return jumpPotion;
            }
        }

        // All potions currently in use
        // We have to handle this somehow?
        GameObject newJumpPotion = Instantiate(jumpPotionPrefab);
        newJumpPotion.SetActive(false);
        jumpPotionPool.Add(newJumpPotion);

        return newJumpPotion;
    }  

}

    // void InitialiseGetPooledJumpPotion();
