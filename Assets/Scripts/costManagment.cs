using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class costManagment : MonoBehaviour
{
    //[SerializeField] private List<GameObject> buttonList;
    private  GameObject bClicked;
    private string buttonTag;
    private int buildingCost;
    void Start()
    {

    }

    // Update is called once per frame
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
                Debug.Log("Building Cost: " + buildingCost);
                break;
            case "solButton":
                buildingCost = 500;
                Debug.Log("Building Cost: " + buildingCost);
                break;
            case "hyButton":
                buildingCost = 200;
                Debug.Log("Building Cost: " + buildingCost);
                break;
            case "wButton":
                buildingCost = 200;
                Debug.Log("Building Cost: " + buildingCost);
                break;
            case "lPadButton":
                buildingCost = 100;
                Debug.Log("Building Cost: " + buildingCost);
                break;
            default:
                buildingCost = 0;
                Debug.Log("Building Cost: " + buildingCost);
                break;

        }
        //button_clicked.
        //return buildingCost;
    }
}
