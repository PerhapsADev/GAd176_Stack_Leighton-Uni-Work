using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Guy : MonoBehaviour
{
    public List<GameObject> jumpPotion = new List<GameObject>();
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject retrievePotion = PotionPoolManager.Instance.GetPooledJumpPotion();


            Debug.Log("Potion! " + retrievePotion.name);
            retrievePotion.transform.position = new Vector3(Random.Range(-10,10), Random.Range(-10,10), Random.Range(-10,10));
            retrievePotion.gameObject.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            // retrievePotion.gameObject.SetActive(false);
            // potionsCurrentlyBeingHeld[0].Consume
        }
    }
}
