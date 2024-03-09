using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IInteractable {
    public void Interact();
}
public class Interactor : MonoBehaviour
{

    public GameObject ShowText;

    public Transform InteractorSource;
    public float InteracRange;

    //Checks if a certain object is in range of the player and infront of it, if so it shows message and can interact with it
    void Update()
    {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteracRange)) {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) {
                    ShowText.gameObject.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E)) {
                        interactObj.Interact();
                    }
                }
                else {
                    ShowText.gameObject.SetActive(false);
                }
        }
    }
}
