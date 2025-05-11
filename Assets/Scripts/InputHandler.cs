using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera _mainCamera;
    public bool mClick;

    public GameObject buildPref;
    public objectMovementBehavior object_movement_behavior;

    private GameObject panel_ref;
    private panelObjectStorage panel_Object_Storage;
    public deleteBuilding delete_building;
    private GameObject build_Menu;
    private GameObject build_mode_Menu;
    public Ray bRay;


    public bool isIntersect;


  

    private void Awake()
    {
        _mainCamera = Camera.main;
        isIntersect = object_movement_behavior.uiInter;
        
      
    }

    private void Update()
    {
    
    }




    // method to check if mouse has been clicked.
    // this is only intended to be used from within building instances 
    // after they have been instaniated using the relevant button
    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

    
        //Debug.Log("mClick: "+mClick);
        Debug.Log("inputHandler isIntersect: "+ isIntersect);
        if (isIntersect==true)
        {
            Debug.Log("Button Clicked");
            
            exitMenu();
        } else if (isIntersect == false)
        {
            Debug.Log("Button not clicked");
            placeBuilding();
            exitMenu();
        }
            
        
    
            
        
            
        
        //Debug.Log(rayHit.collider.gameObject.name);
      
    }




    // this method works by making the objectMovementBahavior script inactive
    // objectMovementBehavior script tells the parent object to move with the mouse cursor.
    // when this is switched off, whatever posiiton the parent object was in, will stay there.
    public void placeBuilding()
    {
        
            Debug.Log("placeBuilding method executed");
            object_movement_behavior =GetComponent<objectMovementBehavior>();
            object_movement_behavior.enabled = false;
            Debug.Log("Object Placed");
        

    }
    public void exitMenu()
    {
        panel_ref = GameObject.Find("Panel References");

        panel_Object_Storage=panel_ref.GetComponent<panelObjectStorage>();


        build_mode_Menu = panel_Object_Storage.panelList[2];

        build_Menu = panel_Object_Storage.panelList[1];


        build_mode_Menu.SetActive(false);
        build_Menu.SetActive(true);

        delete_building.deleteObject();

    }




}
