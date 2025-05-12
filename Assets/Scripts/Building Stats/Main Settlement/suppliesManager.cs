using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suppliesManager : MonoBehaviour
{

    





   
    private keyboardInput key_board;
    public float incomingSupplySubtract;
    public float finalSTotal;
    
    public float incoming_supply;
    public float supplyLevel;

    private float maxSupplyLevel = 1000;

  

    private float supplyDeliveryRate;

  



    public int noLandingPads;

    private GameObject land_pad;

    private float totSuppliesAmount;
    private float totSuppliesDelivery;

    public float supplyPlusMinus;

   
    public static suppliesManager Instance;
    public int currentSupply = 1000;

    private void Update()
    {

        
    }
    public float suppliesInfo()
    {
        Debug.Log("Supplies Start: "+supplyLevel);
        land_pad = GameObject.FindWithTag("landingPad");
        
        totSuppliesDelivery = land_pad.GetComponent<landingPadBehavior>().suppliesProduce;
        noLandingPads = GameObject.FindGameObjectsWithTag("landingPad").Length;
       

        totSuppliesAmount = land_pad.GetComponent<landingPadBehavior>().suppliesAmount;


        Debug.Log("TotSupplies Delivery: "+totSuppliesDelivery);
        Debug.Log("TotSuppliesAmount: " + totSuppliesAmount);

        supplyLevel += supplyLevel + totSuppliesDelivery;
       

        Debug.Log("SupplyLevel: " + supplyLevel);
        //Debug.Log("SupplyPLus: " + supplyPlusMinus);

      
        Debug.Log("Total: " + supplyLevel);





        if (supplyLevel > maxSupplyLevel)
        {
            supplyLevel = maxSupplyLevel;
        }
        if (supplyLevel < 0)
        {
            supplyLevel = 0;
        }
 

        return supplyLevel;
    }

}
