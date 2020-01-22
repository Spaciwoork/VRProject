using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableDoor : MonoBehaviour
{
    public GameObject Door;
    Animator Anim;

    void Start()
    {
        Anim = Door.GetComponent<Animator>();
    }

    // Main function
    void Update()
    {

    }

    // Display a simple info message when player is inside the trigger area
    void OnGUI()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        //Debug.Log("Trigger Enter");
        Anim.SetTrigger("OpenDoor");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
        Anim.enabled = true;
    }
}