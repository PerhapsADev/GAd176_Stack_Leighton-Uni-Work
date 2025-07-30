using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HologramEventManager : MonoBehaviour
{
    // public static UnityEvent OnSpacebarPressed;
    public delegate void MyDelegate();
    // Our Events, to be called when space is pressed
    public static MyDelegate onSpacebarPressed;
    public static MyDelegate onReturnPressed;
    // public static MyDelegate onUpPressed; 
}
