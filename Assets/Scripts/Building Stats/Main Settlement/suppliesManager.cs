using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suppliesManager : MonoBehaviour
{
    [SerializeField] private GameObject dnObject;
    private dayNightCycle dnCycle;
    private float sunAngle;
    private float supplyDeliveryTime;
    bool dayCheck;




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
    private float finalSupplyLevel;
    private float sMinus=0;
    float fSupply;
   


    

    //public static suppliesManager Instance;
    //public int currentSupply = 1000;
  

    private void Update()
    {


    }
    public float SuppliesInfo()
    {
        //if (SupplyDeficit().GetType()==)
        //{

        //}
        //fSupply = SupplyFinal();
        fSupply = SupplyPlus();
        return fSupply;
    }
    private float SupplyPlus()
    {
        Debug.Log("Supplies Start: " + supplyLevel);
        land_pad = GameObject.FindWithTag("landingPad");

        totSuppliesDelivery = land_pad.GetComponent<landingPadBehavior>().suppliesProduce;
        noLandingPads = GameObject.FindGameObjectsWithTag("landingPad").Length;


        totSuppliesAmount = land_pad.GetComponent<landingPadBehavior>().SupplyDeliver();


        // Debug.Log("TotSupplies Delivery: "+totSuppliesDelivery);
        // Debug.Log("TotSuppliesAmount: " + totSuppliesAmount);

        //supplyLevel += supplyLevel + 1;


        //Debug.Log("SupplyLevel: " + supplyLevel);
        //Debug.Log("SupplyPLus: " + supplyPlusMinus);


        //Debug.Log("Total: " + supplyLevel);
        supplyLevel = supplyLevel + totSuppliesAmount;




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
    //public float SupplyDeficit(float supplyMinus)
    //{
    //    sMinus = supplyMinus;
    //    return sMinus;
    //}
    
    //private float SupplyDeficit()
    //{
    //    sMinus = 0;
    //    return sMinus;
    //}
    //private float SupplyFinal()
    //{
    //    finalSupplyLevel = SupplyPlus() + sMinus;
    //    return finalSupplyLevel;
    //}
    //private float CheckTimeDay()
    //{
    //    dnObject = GameObject.FindGameObjectWithTag("dayNight");
    //    dnCycle = dnObject.GetComponent<dayNightCycle>();
    //    sunAngle = dnObject.transform.rotation.eulerAngles.z;
    //   //supplyDeliveryTime
    //    return supplyDeliveryTime;
    //}
}
