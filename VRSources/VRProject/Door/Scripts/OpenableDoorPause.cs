using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableDoorPause : MonoBehaviour
{
    public GameObject Door;
    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = Door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseEvent()
    {
        Debug.Log("Pause");
        Anim.enabled = false;
    }
}
