using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BrewingMayhemGame
{

    public class Player : MonoBehaviour
    {
        [SerializeField] private int jumpHeight;

        [SerializeField] private Inventory inventory;

        // When the player spaces spacebar
        // activate the frist item in the inventory

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Activate first item in inventory
                inventory.ConsumePotion();
            }
        }

        public void IncreaseJumpHeight()

        {
            jumpHeight = 0;

        }
        private void OnTriggerEnter(Collider other)
        {
            // Checck if colldied with potion
            Debug.Log("You collided with Something?");
            //if (other.CompareTag("Potion") == true)
            //{
            //    //We Have collided a potion
            //    // Refer to potion
            //    // do "Collect()"

            //    Debug.Log("Trigger Collect Activated");
            //    other.GetComponent<Potion>().Collect();

            //}

                if (other.GetComponent<ICollectable>() != null)
                {
                    //We Have collided a coin
                    // Refer to ICollectable
                    // do "Collect()"

                    Debug.Log("Trigger Collect Activated");
                    other.GetComponent<ICollectable>().Collect();

                }
        }
    }

}
