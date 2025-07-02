
using UnityEngine;

namespace BrewingMayhemGame
{

    public class Potion : MonoBehaviour, ICollectable, IConsummable // Yes, It's spelt wrong >:\
    {
        public void Collect()
        {
            // When potion is collected we want it to
            // Output to console
            // Destory Object - NOT ADDED

            Debug.Log("Potion has been collected!");

        }

        // We need PROPERTY
        //Applies Effect, EFFECT: Increases jump height for limited time (1 minute)

        // private int potency = 0;


        //Has SellValue, which determines how much it sells for, VALUE: $ --?

        //private int sellValue = 0;

        // We need FUNCTIONALITY

        // Cane be used, which applies an effect to the player and removes
        // item from inventory

        public void Consume()
        {

            Debug.Log("Potion consumed! " + gameObject.name);
        }
    }

}
