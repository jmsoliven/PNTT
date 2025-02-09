using UnityEngine;
using UnityEngine.InputSystem.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Security.Cryptography.X509Certificates;
using System.Linq;


public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    private PlayerInput inputManager;
  

   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<PlayerInput>();
      
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        //create a ray at the center of the camera, shooting outwards.
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo; // variable to store our collision information.
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>() !=null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);
              

                 if (inputManager.OnFoot.Interact.triggered)
               {

                       interactable.BaseInteract();
               }
                    
               

            }

         
        }
      
    }
}
