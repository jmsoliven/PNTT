using UnityEngine;
using UnityEngine.InputSystem;
public abstract class Interactable : MonoBehaviour


{
    //message displayed to player when looking at interatable.
    public string promptMessage;
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //nothing here
    }

}
