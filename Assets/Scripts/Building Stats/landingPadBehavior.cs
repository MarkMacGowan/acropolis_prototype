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
    //0.00000000000000000000000000001f;
    public float maxSuppliesProduce = 1f;

    public int noLandingPads;

    // Start is called before the first frame update
    void Start()
    {
        timeObject= GameObject.FindGameObjectWithTag("dayNight");
        dnCycle = timeObject.GetComponent<dayNightCycle>();
        
        suppliesAmount = 0f;
        suppliesProduce = 1f/100f;
    }

    // Update is called once per frame
    void Update()
    {   
        //sunRotateZ=dnCycle.rotationalNumZ;
        //suppliesAmount = suppliesAmount + Time.deltaTime * 10;

       

            
        suppliesAmount = suppliesAmount + suppliesProduce;
                     

            
        
       




        if (suppliesAmount> maxSuppliesAmount)
        {
            suppliesAmount = maxSuppliesAmount;
        }
    }
}
