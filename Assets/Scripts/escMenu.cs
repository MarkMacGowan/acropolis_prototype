using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escMenu : MonoBehaviour
{
    public InputHandler input_handler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void outOfMenu()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("Escape Button");
            input_handler.exitMenu();
        }
    }
}
