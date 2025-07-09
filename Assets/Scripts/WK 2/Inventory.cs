using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

namespace BrewingMayhemGame
{

    public class Inventory : MonoBehaviour
    {
        //Keeps amount / referecne to amount of potions the player has

        [SerializeField] private Potion[] JumpBoostPotion;

        // Can tell the potions to be consumed from the potion Array
        [SerializeField] private Item[] items;
        [SerializeField] private Item[] item = new Item[8];

        public void ConsumePotion()
        {
            JumpBoostPotion[0].Consume();
        }
    

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (item[0] != null)
                {
                    Debug.Log("items in the the slot is " + item[0].itemName);
                }
            }
        }

    }
}


