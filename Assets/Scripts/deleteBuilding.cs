using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteBuilding : MonoBehaviour
{
    // variable to store script on same object. Script is named buildingManager
    public buildingManager buildMan;
    // gameobject variable to store building object
    GameObject buildingToDelete;


    private void Awake()
    {   
        // buildMan assigned value of the buildingManager script which is a componant in this parent object
        buildMan = GetComponent<buildingManager>();
       // Debug.Log(buildMan);
    }
    void Start()
    {
        
    }
    void Update()
    {   
        // buildingToDelete is assinged value of variable in the buildingManager script,
        // currently represented in the variable buildMan
        buildingToDelete = buildMan.currentBuilding;
      //  Debug.Log("building to delete: "+buildingToDelete);
    }
    public void deleteObject()
    {   
        //deleteObject function will remove the current instance of the chosen building object from the scene
        Destroy(buildingToDelete);

    }
}
