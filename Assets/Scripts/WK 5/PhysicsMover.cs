using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// Rolls the ball around using phyiscs based on player inputs OR a target direction.
/// </summary>
public class PhysicsMover : MonoBehaviour
{
    [Header("Core Properties")]
    [SerializeField] private Rigidbody sphere;

    [Header("AI Functionality")]
    [SerializeField] private bool isCurrentlyChasing;
    [SerializeField] private float movementSpeedInUnitsPerSecond = 19f;
    [SerializeField] private GameObject chaseTarget;
    // [SerializeField] private GameObject player;

    private void FixedUpdate()
    {
        if (isCurrentlyChasing == false)
        {
            if (sphere.velocity.magnitude <= 20)
            {
                //Input.GetAxis("Vertical") ...W/S
                //Input.GetAxis("Horizontal") ...A/D

                // Input.GetAxis gives a movement float of 1.
                // movementSpeedInUnitsPerSecond (19), Input.GetAxis (1).
                // Keep in mind to * (times) these, using + or - limits the collab'd speed via which way its going on the axis (forward +, backwards -)

                sphere.AddForce(movementSpeedInUnitsPerSecond * Input.GetAxis("Horizontal"), 0, movementSpeedInUnitsPerSecond * Input.GetAxis("Vertical"));
            }
        }
        else
        {
            // AI chasing code
            // We need traget
            // move towards target

            // Vector math to chase player
            // tartget.position - me.position

            if (sphere.velocity.magnitude <= 20)
            {
                sphere.AddForce(chaseTarget.transform.position - gameObject.transform.position);
            }
        }


    }
}
