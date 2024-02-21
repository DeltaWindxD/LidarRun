using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotShooter : MonoBehaviour
{
    public GameObject dotPrefab;
    public float sprayAngle = 30f;
    public int sprayAmount = 10;
    public float dotSpeed = 10f;

    void Update()
    {
        {
            if (Input.GetMouseButtonDown(0))  // Check for left mouse button click
            {
                ShootSpray();
            }
        }
    }

    void ShootSpray()
    {
        for (int i = 0; i < sprayAmount; i++)
        {
            Vector3 sprayDirection = Quaternion.Euler(Random.Range(-sprayAngle, sprayAngle), Random.Range(-sprayAngle, sprayAngle), 0) * transform.forward;

            // Offset the starting position in front of the player
            Vector3 spawnPosition = transform.position + sprayDirection.normalized * 2f; // Adjust 2f to your desired offset

            GameObject dot = Instantiate(dotPrefab, spawnPosition, Quaternion.identity);

            // Set the dot's layer to the "Dot" layer
            dot.layer = LayerMask.NameToLayer("Dot");

            Rigidbody dotRigidbody = dot.GetComponent<Rigidbody>();
            dotRigidbody.AddForce(sprayDirection * dotSpeed, ForceMode.VelocityChange);

            // Attach a custom script to handle collisions
            dot.AddComponent<DotCollisionHandler>();
        }
    }
}
