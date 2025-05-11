using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class keyboardInput : MonoBehaviour
{
    [SerializeField] private BuildingBehavior behaviorScript;
    [SerializeField] private SpaceOccupation space_occupation;
    [SerializeField] private GameObject mSettle;

    private GameObject cost_managment_object;
    private suppliesManager supplies_manager;
    private costManagment cost_managment;
    public int bCost;
    public bool bInterSect;

    public bool mClick;
    
    public GameObject buildPref;
    public objectMovementBehavior object_movement_behavior;
    public objectTransparency object_transparency;

    private GameObject build_spawner;
    private buildingManager building_manager;
    public GameObject panel_ref;
    private panelObjectStorage panel_Object_Storage;
    private deleteBuilding delete_building;
    private GameObject build_Menu;
    private GameObject build_mode_Menu;
    public Ray bRay;

    [SerializeField] private GameObject panelToClose;

 

    private Camera _mainCamera;


    public bool isPlaced;




    private void Awake()
    {
        _mainCamera = Camera.main;
        isPlaced = false;
        space_occupation = gameObject.GetComponent<SpaceOccupation>();
        cost_managment_object = GameObject.FindGameObjectWithTag("costMan");
        mSettle = GameObject.FindGameObjectWithTag("mainSettle");
        supplies_manager = mSettle.GetComponent<suppliesManager>();
     
      

       
 
    }
   


    // method to check if mouse has been clicked.
    // this is only intended to be used from within building instances 
    // after they have been instaniated using the relevant button
    private void Update()
    {
         bInterSect = space_occupation.objectInterSect;
        
        // left click
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Mouse Click");
            checkGUI();        
            
            
            if (checkGUI())
            {
                    Debug.Log("Button Clicked");
                    return;
                   
            }
            else 
            {
                    Debug.Log("Button GUI not clicked but mouse clicked");
               
                Debug.Log("InterSection: "+bInterSect);
                    if (!bInterSect)
                        {   
                            placeBuilding();
                            exitMenu();
                            bCost = cost_managment_object.GetComponent<costManagment>().buildingCost;
                            Debug.Log("bCost: " + bCost);
                            supplies_manager.incomingSupplySubtract = bCost;
                           
                            //Debug.Log("Cost Managment Object: "+cost_managment.name);
                            
                           // Debug.Log("bCost: " + bCost);
                        }
                    
            }
        }

    }








    
    private bool checkGUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }


    // this method works by making the objectMovementBahavior script inactive
    // objectMovementBehavior script tells the parent object to move with the mouse cursor.
    // when this is switched off, whatever posiiton the parent object was in, will stay there.
    public void placeBuilding()
    {

        Debug.Log("placeBuilding method executed");
        object_movement_behavior = GetComponent<objectMovementBehavior>();
        object_movement_behavior.enabled = false;
        Debug.Log("Object Placed");
        isPlaced = true;
        behaviorScript.enabled = true;

    


    }
    public void exitMenu()
    {
        panel_ref = GameObject.Find("Panel References");

        panel_Object_Storage = panel_ref.GetComponent<panelObjectStorage>();


        build_mode_Menu = panel_Object_Storage.panelList[2];

        build_Menu = panel_Object_Storage.panelList[1];


        build_mode_Menu.SetActive(false);
        build_Menu.SetActive(true);
   ;


    }

}
