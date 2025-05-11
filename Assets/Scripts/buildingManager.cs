using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class buildingManager : MonoBehaviour
{
    
    public RaycastPlane raycastPlane;
    
    
    
   
   
    Vector3 placementCoord;
   

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
    public int buildingsListSize;
   
    

    private void Awake()
    {
        
        raycastPlane = GetComponent<RaycastPlane>();
        currentBuilding = null;
       
    }

   
    void Start()
    {
       
        

      
    }



   
    void Update()
    {
        buildingsListSize = buildings.Count;
       
        placementCoord = raycastPlane.gamePosition;
      
       


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


  



    

    public void addBuilding()
    {
  

        // name of button clicked is assigned to variable
        buttonName = EventSystem.current.currentSelectedGameObject.name;
        // buttonName variable used an argument in chooseBuilding method
        chooseBuilding(buttonName);

       

        // assigned current instantiated object as a variable to be accessed by deleteBuilding script if needed
        currentBuilding=Instantiate(testBuilding, placementCoord, Quaternion.identity)as GameObject;
       
     
        

    }

    GameObject chooseBuilding(string iButtonName)
    {
        
       // method takes assigns value of iButtonName to bName
        string bName = iButtonName;
       
        // conditional statement to choose building based on button clicked
        // uses bName as variable for comparison.
       
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
  
 
    


}
