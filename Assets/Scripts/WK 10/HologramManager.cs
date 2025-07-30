using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HologramManager : MonoBehaviour
{
    // access Modifer
    // type
    // name
    // value
    // access Modifer        type        name                    value
    // [SerializeField] private UnityEvent OnSpacebarPressed;      // often

    //reference to my holo cubes
    // [SerializeField] private List<GameObject> holograms = new List<GameObject>(); - dont use anymore

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HologramEventManager.onSpacebarPressed?.Invoke();
            // HologramEventManager.OnSpacebarPressed?.Invoke();
            // ?. = Check null

        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            HologramEventManager.onReturnPressed?.Invoke();
        }
    }
}
