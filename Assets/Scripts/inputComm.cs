using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputComm : MonoBehaviour
{
    // class to communicate input actions from InputHandler script
    // and buildingManager script (this script is in different object)


    private MonoBehaviour inPutScript;
    public bool playerClick;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toInput()
    {

    }
    public void fromInput()
    {
        inPutScript = GetComponent<InputHandler>();
        
    }
}
