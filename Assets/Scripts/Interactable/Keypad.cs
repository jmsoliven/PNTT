using UnityEngine;
using UnityEngine.InputSystem;

public class Keypad : Interactable
{
    [SerializeField]
    private GameObject DOOR;
    private bool doorOpen;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        DOOR.GetComponent<Animator>().SetBool("Open", doorOpen);
    }
}
