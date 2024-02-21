using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotCollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Do nothing or handle it as needed
            return;
        }

        // Stop the dot's movement on collision
        Rigidbody dotRigidbody = GetComponent<Rigidbody>();
        dotRigidbody.velocity = Vector3.zero;
        dotRigidbody.isKinematic = true; // Make the dot kinematic to prevent further physics interactions
    }
}