using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public float cameraSpeed;// public variable that determines movement sensativity 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float x = Input.GetAxis("Horizontal");//gets input from a and d or left and right buttons
        float z = Input.GetAxis("Vertical");// gets input from w and s or up and down buttons



        // y remains constant as no zoom in or out funtio ality implemented yet
        Vector3 movement = new Vector3(x, 0, z);  

        // translate method called,
        // if movement is 0 ie no movement, values are multiplied by 0 so end result is zero movement per time unit 
        transform.Translate(movement * cameraSpeed * Time.deltaTime);
    }
}
