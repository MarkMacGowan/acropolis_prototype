using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landingPadBehavior : BuildingBehavior

{
    public float maxLandingPadHealth = 100f;
    public float landingPadHealth = 100f;

    public float maxSuppliesAmount = 100f;
    public float suppliesAmount;

    public float suppliesProduce = 0.2f;
    public float maxSuppliesProduce = 1f;

    public int noLandingPads;

    // Start is called before the first frame update
    void Start()
    {
        suppliesAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {   
        suppliesAmount = suppliesAmount + Time.deltaTime * 10;

        
        
        
        
        if (suppliesAmount> maxSuppliesAmount)
        {
            suppliesAmount = maxSuppliesAmount;
        }
    }
}
