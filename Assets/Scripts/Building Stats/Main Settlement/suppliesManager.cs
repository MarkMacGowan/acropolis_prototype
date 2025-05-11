using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suppliesManager : MonoBehaviour
{   

    [SerializeField] private int suppliesSpent;


    private float suppliesDeficit;


    private float supplies_deficit;


    private float incomingSupplySubtract;


    public float supplyLevel = 0;

    private float maxSupplyLevel=1000;

   // private float minSupplyLevel = 0f;

    private float supplyDeliveryRate;

  //  private float supplyUsageRate;



    public int noLandingPads;

    private GameObject land_pad;

    private float totSuppliesAmount;
    private float totSuppliesDelivery;

    public float supplyPlusMinus;
    
    
    
     // Start is called before the first frame update
    void Start()
    {
        incomingSupplySubtract = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float suppliesInfo()
    {
        land_pad = GameObject.FindWithTag("landingPad");
        totSuppliesAmount = land_pad.GetComponent<landingPadBehavior>().suppliesAmount;
        totSuppliesDelivery = land_pad.GetComponent<landingPadBehavior>().suppliesProduce;
        noLandingPads = GameObject.FindGameObjectsWithTag("landingPad").Length;
        supplyDeliveryRate = totSuppliesAmount;
        supplyLevel = supplyLevel + supplyDeliveryRate;


        supplies_deficit = CalculateSuppliesDeficit();
        supplyPlusMinus = totSuppliesDelivery - supplies_deficit;
        supplyLevel = supplyLevel + (supplyPlusMinus);
        if (supplyLevel > maxSupplyLevel)
        {
            supplyLevel = maxSupplyLevel;
        }
        return supplyLevel;
    }
    private float CalculateSuppliesDeficit()
    {
        suppliesDeficit =incomingSupplySubtract;
       // suppliesDeficit=
        return suppliesDeficit;
    }
}
