using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
// using UnityEngine.InputSystem;

public class buildingManager : MonoBehaviour
{
    //public string buildingName;
    public RaycastPlane raycastPlane;
    
    
    //public addBuildingBtn addBuildingBtn;
    // add public button variable below here
    // public 
    Vector3 placementCoord;
    // bool uiIntersect;
    //bool addBuildingMode;
    //string prefabName;

    // bool buildingSelected;

    string buttonName;
    
    string indexOfBuilding;

    // array list to store range of buildings in 
    public List<GameObject> buildings = new List<GameObject>();
    public GameObject testBuilding;
    public GameObject currentBuilding;
    

    private MonoBehaviour referenceScript;
    private GameObject handlerObj;
    private InputHandler refHandler;
    private bool yesNoClick;
   
    //public GameObject targetObject;
    

    private void Awake()
    {
        
        raycastPlane = GetComponent<RaycastPlane>();
        currentBuilding = null;
        //buildingSelected = false;
        //string prefabName = GameObject.Find("testBuilding").name;

        //yesNoClick = refHandler.mClick;
    }

    // Start is called before the first frame update
    void Start()
    {
        // addBuildingMode = true;
        // targetObject = GameObject.Find("buildingModeMenu");

        // handlerObj = GameObject.Find("InputHandlerObject");
        

      
    }



    // Update is called once per frame
    void Update()
    {
        //uiIntersect = raycastPlane.uiIntersect;
        placementCoord = raycastPlane.gamePosition;
      
        //var cancelButton = targetObject.GetComponent("cancelBtn");

        //float x = (Input.mousePosition).x;//gets input from mouse position x coord
        //float z = (Input.mousePosition).y;// gets input from mouse position y coord



        // y remains constant as no zoom in or out funtio ality implemented yet
        //Vector3 movement = new Vector3(x, 0, z);

        // translate method called,
        // if movement is 0 ie no movement, values are multiplied by 0 so end result is zero movement per time unit 
        // transform.Translate(movement * 2 * Time.deltaTime);




        //Debug.Log("Mouse Coord: X:"+x+ " Z:"+ z);
        //Debug.Log(buildingSelected);

        //if (yesNoClick == true)
        //{
        //    Debug.Log("buildManager: Mouse Clicked");
        //    placeBuilding();
        //}
       
        
    }
    //public void buildingMode()
    //{
        
       
    //        if (addBuildingMode == true)
    //        {
    //        addBuildingMode = false;
    //            Debug.Log("Building Mode On");
    //        }
    //        else if (addBuildingMode==false)
    //        {
    //        addBuildingMode = true;
    //            Debug.Log("Building Mode Off");
    //        }
    //}

  



    

    public void addBuilding()
    {
       // Debug.Log("------------");
       // Debug.Log("Entering Building Mode");
        //Debug.Log("About to place: "+buildingName);
        //buildingMode();
       // Debug.Log("addBuilding method executed");




        //testBuilding = buildings[1];

        // name of button clicked is assigned to variable
        buttonName = EventSystem.current.currentSelectedGameObject.name;
        // buttonName variable used an argument in chooseBuilding method
        chooseBuilding(buttonName);

        //Debug.Log(buttonName);
       // Debug.Log(testBuilding);


        // assigned current instantiated object as a variable to be accessed by deleteBuilding script if needed
        currentBuilding=Instantiate(testBuilding, placementCoord, Quaternion.identity)as GameObject;
        //if (uiIntersect == false)
        //{
            
            
        //}
        //else
        //{
            
        //    Debug.Log("Building cannot be placed");
        //}
     
        

    }

    GameObject chooseBuilding(string iButtonName)
    {
        // Debug.Log("chooseBuilding method executed");
       // Debug.Log("iButtonName: "+iButtonName);
        //testBuilding = null;
       // method takes assigns value of iButtonName to bName
        string bName = iButtonName;
        // Debug.Log("bName: "+bName);
        // conditional statement to choose building based on button clicked
        // uses bName as variable for comparison.
        //buildingSelected = true;
        switch (bName)
        {
            case "landingPadBtn":
               // Debug.Log("Landing Pad Selected");
                testBuilding = buildings[0];
                break;
            case "storageBuildingBtn":
               // Debug.Log("Storage Building Selected");
                testBuilding = buildings[1];
                break;
            case "solarPanelBtn":
                // Debug.Log("Solar Panel Selected");
                testBuilding = buildings[2];
                break;
            case "oxygenGenBtn":
                // Debug.Log("Oxygen Generator Selected");
                testBuilding = buildings[3];
                break;
            case "hydroBtn":
                // Debug.Log("Hydroponics Building Selected");
                testBuilding = buildings[4];
                break;
            case "waterExtractorBtn":
                // Debug.Log("Water Extractor Building Selected");
                testBuilding = buildings[5];
                break;
            default:
                // Debug.Log("No Building Selected");
                testBuilding = null;
                break;
        }
        Debug.Log(testBuilding);
        return testBuilding;
    } 
    //public void spawnIfClicked()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Instantiate(testBuilding, placementCoord, Quaternion.identity);
    //        addBuildingMode = false;
    //    }
        
    //}
    public void deleteBuilding()
    {
        // moved this to an entriely new script
        //Destroy(testBuilding);
        //addBuildingMode = false;
    }
    //public void OnClick(InputAction.CallbackContext context)
    //{
    //    if (!context.started) return; 
    //    Debug.Log("buildingManager: OnClick Method Executed");
    //    placeBuilding();
    //}
    
    
    //public void placeBuilding()
    //{   
    //    //Debug.Log("placeBuilding Method Executed");
    //    referenceScript=currentBuilding.GetComponent<objectMovementBehavior>();
    //    referenceScript.enabled = false;
    //}


}
