using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piggy : MonoBehaviour
{
    private float _damageForce = 20;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Compute the relative velocity of the colliding object
        float collisionForce = collision.relativeVelocity.sqrMagnitude;
       
        if(collisionForce > _damageForce)
        {
            //Destroy the piggy
            Destroy(gameObject);
        }
    }
}
