using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class costManagment : MonoBehaviour
{
  
    private  GameObject bClicked;
    private string buttonTag;
    public int buildingCost;


    void Update()
    {
        costDeduct(bClicked);
    }
    public void costDeduct(GameObject button_clicked)
    {
        bClicked = button_clicked;
        buttonTag=bClicked.tag;
        switch (buttonTag)
        {
            case "oxButton":
                buildingCost = 100;
               // Debug.Log("Building Cost: " + buildingCost);
                break;
            case "solButton":
                buildingCost = 500;
              //  Debug.Log("Building Cost: " + buildingCost);
                break;
            case "hyButton":
                buildingCost = 200;
               // Debug.Log("Building Cost: " + buildingCost);
                break;
            case "wButton":
                buildingCost = 200;
                //Debug.Log("Building Cost: " + buildingCost);
                break;
            case "lPadButton":
                buildingCost = 100;
               // Debug.Log("Building Cost: " + buildingCost);
                break;
            default:
                buildingCost = 0;
                //Debug.Log("Building Cost: " + buildingCost);
                break;

        }
       
    }
}
