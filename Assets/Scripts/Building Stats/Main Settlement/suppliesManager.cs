using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suppliesManager : MonoBehaviour
{   


    public float supplyLevel = 0;

    private float maxSupplyLevel = 100f;

    private float minSupplyLevel = 0f;

    private float supplyDeliveryRate;

    private float supplyUsageRate;



    public int noLandingPads;

    private GameObject land_pad;

    private float totSuppliesAmount;
    private float totSuppliesDelivery;
    
    
    
     // Start is called before the first frame update
    void Start()
    {
        
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
        if (supplyLevel>maxSupplyLevel)
        {
            supplyLevel = maxSupplyLevel;
        }
        return supplyLevel;
    }
}
