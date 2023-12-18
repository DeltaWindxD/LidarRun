using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Scanner : MonoBehaviour
{
    public float angle;
    public ParticleSystem pSystem;
    public Transform shootPoint;
    public LayerMask HitMask;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire(InputAction.CallbackContext ctx)
    {

        Debug.Log("Shoot");
        Vector3 dir = new Vector3(Random.Range(-angle, angle), Random.Range(-angle, angle), 1).normalized;
        if (Physics.Raycast(shootPoint.position, dir, out RaycastHit hit, HitMask))
        {
            ParticleSystem.EmitParams emit = new ParticleSystem.EmitParams();
            emit.position = hit.point;
            pSystem.Emit(emit, 1);
            Debug.Log(hit.point);
        }
    }
}
