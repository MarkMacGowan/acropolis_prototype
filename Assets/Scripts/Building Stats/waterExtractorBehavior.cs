using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterExtractorBehavior :BuildingBehavior 
{
    public float maxWaterExtractorHealth=100f;
    public float waterExtractorHealth=100f;

    public float maxWaterAmount = 100f;
    public float waterAmount;

    public float waterProduce = 0.2f;

    public float maxWaterProduce = 1f;

    public int noWaterExtractors;
    // Start is called before the first frame update
    void Start()
    {
        waterAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        waterAmount = waterAmount + waterProduce;
        if (waterProduce>maxWaterProduce)
        {
            waterProduce = maxWaterProduce;
        }

        if (waterAmount>maxWaterAmount)
        {
            waterAmount = maxWaterAmount;
        }
    }
}
