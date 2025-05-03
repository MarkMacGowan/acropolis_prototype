using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        followCursor();
    }

    public void followCursor()
    {

        float x = (Input.mousePosition).x;//gets input from mouse position x coord
        float z = (Input.mousePosition).y;// gets input from mouse position y coord



        // y remains constant as no zoom in or out funtio ality implemented yet
        Vector3 movement = new Vector3(x, 0, z);

        // translate method called,
        // if movement is 0 ie no movement, values are multiplied by 0 so end result is zero movement per time unit 
        gameObject.transform.Translate(movement * 1 * Time.deltaTime);




        //Debug.Log("Mouse Coord: X:"+x+ " Z:"+ z);
    }
}
