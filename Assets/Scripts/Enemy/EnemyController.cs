using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent enemy;

    public GameObject player;

    void Start()
    {
        target = player.transform;
        enemy = GetComponent<NavMeshAgent>();
    }

    //Checks if player is inside of range and if so chase the player
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        
        if (distance <= lookRadius)
        {
            enemy.SetDestination(target.position);

            if (distance <= enemy.stoppingDistance)
            {
                FaceTarget();
            }
        }
    }

    //Makes the enemy always face player
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation  = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime *5);
    }

}
