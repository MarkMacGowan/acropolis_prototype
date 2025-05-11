using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landingPadBehavior : BuildingBehavior

{   
    [SerializeField] private GameObject timeObject;
    private dayNightCycle dnCycle;
    private float sunRotateZ;
    public float maxLandingPadHealth = 100f;
    public float landingPadHealth = 100f;

    public float maxSuppliesAmount = 100f;
    public float suppliesAmount;

    public float suppliesProduce; 
   
    public float maxSuppliesProduce = 1f;

    public int noLandingPads;

   
    void Start()
    {
        timeObject= GameObject.FindGameObjectWithTag("dayNight");
        dnCycle = timeObject.GetComponent<dayNightCycle>();
        
        suppliesAmount = 0f;
        suppliesProduce = 1f/1000000f;
    }

   
    void Update()
    {   
       

       

            
        suppliesAmount = suppliesAmount + suppliesProduce;
                     

            
        
       




        if (suppliesAmount> maxSuppliesAmount)
        {
            suppliesAmount = maxSuppliesAmount;
        }
    }
}
