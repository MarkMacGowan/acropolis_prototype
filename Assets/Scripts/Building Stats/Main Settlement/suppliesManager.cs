using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suppliesManager : MonoBehaviour
{   

    [SerializeField] public int suppliesSpent;


    private float suppliesDeficit;


    private float supplies_deficit;


    public float incomingSupplySubtract;


    public float supplyLevel = 1000f;

    private float maxSupplyLevel=1000;

   // private float minSupplyLevel = 0f;

    private float supplyDeliveryRate;

  //  private float supplyUsageRate;



    public int noLandingPads;

    private GameObject land_pad;

    private float totSuppliesAmount;
    private float totSuppliesDelivery;

    public float supplyPlusMinus;

    private float finalSupplyTotal;
    
     // Start is called before the first frame update
    void Start()
    {
        //incomingSupplySubtract = 0f;
        //supplyLevel = 500f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Subtract Amount: " + incomingSupplySubtract);
    }

    public float suppliesInfo()
    {
        //incomingSupplySubtract=0f;
        
        land_pad = GameObject.FindWithTag("landingPad");
        totSuppliesAmount = land_pad.GetComponent<landingPadBehavior>().suppliesAmount;
        totSuppliesDelivery = land_pad.GetComponent<landingPadBehavior>().suppliesProduce;
        noLandingPads = GameObject.FindGameObjectsWithTag("landingPad").Length;
        supplyDeliveryRate = totSuppliesAmount;
        supplyLevel = supplyLevel + supplyDeliveryRate;


        //supplies_deficit = CalculateSuppliesDeficit();
        //supplyPlusMinus = totSuppliesDelivery - supplies_deficit;
        supplyLevel = supplyLevel + totSuppliesAmount;
        if (supplyLevel > maxSupplyLevel)
        {
            supplyLevel = maxSupplyLevel;
        }
        // supplyLevel-
        finalSupplyTotal = supplyLevel - incomingSupplySubtract;
        if (finalSupplyTotal>maxSupplyLevel)
        {
            finalSupplyTotal = maxSupplyLevel;
        }
        if (finalSupplyTotal < 0)
        {
            finalSupplyTotal = 0;
        }
        return finalSupplyTotal;
    }
    //private float CalculateSuppliesDeficit()
    //{
    //    //Debug.Log("Supplies Spent: " + suppliesSpent);
    //    //incomingSupplySubtract = suppliesSpent;
    //    //Debug.Log("Supplies Subtract: "+incomingSupplySubtract);
    //    //suppliesDeficit =suppliesSpent;
    //    // suppliesDeficit=
    //    //suppliesDeficit = incomingSupplySubtract;
    //    //return suppliesDeficit;
    //}
}
