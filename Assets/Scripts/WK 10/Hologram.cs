using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

// <summary>
// Responds to events announced by the hologram Manager
public class Hologram : MonoBehaviour

{
    [SerializeField] private int health = 2;
    [SerializeField] private static float speed = 10.1f;

    private void Start()
    {
        // normal variable
        print("Health of " + gameObject.name + "] is [" + health + "]. Nice!");
        // static variable
        // set speed to random value,
        speed = Random.Range(1f, 10f);
        print("Spped static variable set tp [" + speed + "].");
        // then set random value
        // then output line below
        print("Health of " + gameObject.name + "] is [" + speed + "]. Nice!");

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("Speed of [" + gameObject.name + "is [" + speed + "] !");
        }
    }
    private void OnEnable()
    {
        // HologramEventManager.OnSpacebarPressed.AddListener(HideHolograms);
        HologramEventManager.onSpacebarPressed += HideHolograms;
        HologramEventManager.onReturnPressed += ShowHolograms;
    }

    private void OnDisable()
    {
        // HologramEventManager.OnSpacebarPressed.RemoveListener(HideHolograms);
        HologramEventManager.onSpacebarPressed -= HideHolograms;
        HologramEventManager.onReturnPressed -= ShowHolograms;
    }

    private void HideHolograms()
    {
        //gameObject.SetActive(false);
         Debug.Log("Deactived Holograms");
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    private void ShowHolograms()
    {
        //gameObject.SetActive(true);
        Debug.Log("Reactived Holograms");
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
