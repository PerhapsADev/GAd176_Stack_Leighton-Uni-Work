using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BrewingMayhemGame
{

    public class Inventory : MonoBehaviour
    {
        //Keeps amount / referecne to amount of potions the player has

        [SerializeField] private Potion[] JumpBoostPotion;

        // Can tell the potions to be consumed from the potion Array

        public void ConsumePotion()
        {
            JumpBoostPotion[0].Consume();
        }
    }

}
