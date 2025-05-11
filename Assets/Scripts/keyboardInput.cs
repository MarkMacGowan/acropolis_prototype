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

    //public solarPanelBehavior solar_panel_behavior;

    private Camera _mainCamera;

    //public bool isIntersect;
    public bool isPlaced;


    // private buildingManager bManager;


    private void Awake()
    {
        _mainCamera = Camera.main;
        isPlaced = false;
        space_occupation = gameObject.GetComponent<SpaceOccupation>();
        cost_managment_object = GameObject.FindGameObjectWithTag("costMan");
        mSettle = GameObject.FindGameObjectWithTag("mainSettle");
        supplies_manager = mSettle.GetComponent<suppliesManager>();
        //Debug.Log("Cost Object: " + cost_managment_object.name);
        //bCost = cost_managment.buildingCost;
        //cost_managment_object=gameObject
        
        //isIntersect = object_movement_behavior.uiInter;

       
       
        // bRay = object_movement_behavior.ray;

        //mClick = false;
        //bManager = buildPref.GetComponent<buildingManager>();
        //object_movement=GetComponent<objectMovementBehavior>();
    }
    // method to see if OnClick method can be used at all
    // if the raycast intersects with a gui object such as a button
    // then OnClick method should not be used
    //public void checkInterSect()
    //{

    //}    


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
            
            //Debug.Log("inputHandler isIntersect: " + isIntersect);
            if (checkGUI())
            {
                    Debug.Log("Button Clicked");
                    return;
                    //exitMenu();
            }
            else 
            {
                    Debug.Log("Button GUI not clicked but mouse clicked");
                //object_transparency.transparencyStrength = 1f;
                Debug.Log("InterSection: "+bInterSect);
                    if (!bInterSect)
                        {   
                            placeBuilding();
                            exitMenu();
                            bCost = cost_managment_object.GetComponent<costManagment>().buildingCost;
                            Debug.Log("bCost: " + bCost);
                            supplies_manager.incomingSupplySubtract = bCost;
                            //cost_managment=cost_managment_object.GetComponent<costManagment>();
                            //Debug.Log("Cost Managment Object: "+cost_managment.name);
                            
                           // Debug.Log("bCost: " + bCost);
                        }
                    
            }
        }

    }







    //public void outOfMenu(InputAction.CallbackContext context)
    //{
    //    if (!context.started) return;

    //        Debug.Log("Escape Button");
    //        exitMenu();

    //}

        //Debug.Log(rayHit.collider.gameObject.name);
    
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

        //solar_panel_behavior.enabled = true;


    }
    public void exitMenu()
    {
        panel_ref = GameObject.Find("Panel References");

        panel_Object_Storage = panel_ref.GetComponent<panelObjectStorage>();


        build_mode_Menu = panel_Object_Storage.panelList[2];

        build_Menu = panel_Object_Storage.panelList[1];


        build_mode_Menu.SetActive(false);
        build_Menu.SetActive(true);
        //clearBuildingValues();

        //build_spawner = GameObject.Find("buildingSpawner");
        //delete_building = build_spawner.GetComponent <deleteBuilding>();
        //delete_building.deleteObject();


    }
    public void clearBuildingValues()
    {
      // used to clear variable when the cancel button is pressed or when building is placed onto level
      building_manager=  build_spawner.GetComponent<buildingManager>();
      building_manager.currentBuilding =null;
    }
}
