using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// <summary>
// Responds to events announced by the hologram Manager
public class Hologram : MonoBehaviour
{
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
