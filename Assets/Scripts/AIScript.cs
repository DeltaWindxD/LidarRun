using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIScript : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(target.transform.position);
    }
}
