using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterManager : MonoBehaviour
{
    public float waterLevel;
    private float maxWaterLevel = 100f;
    //private float minWaterLevel = 0f;
    private float waterProductRate;
    private float waterUsageRate;

    public int noWaterExtractors;
    private GameObject water_extractor;

    private float totWaterAmount;


    private float acropolisWaterConsumption;
    private float waterConsumption;
    private float tot_water_produce;
    private float waterDeficit;
    private float waterPlusMinus;
    // Start is called before the first frame update
    void Start()
    {
        waterLevel = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float waterInfo()
    {
        GameObject[] waterExtractorList = GameObject.FindGameObjectsWithTag("waterExtract");
        //water_extractor = GameObject.FindWithTag("waterExtract");

        tot_water_produce = 0f;
        foreach (GameObject waterEx in waterExtractorList)
        {
            if (waterEx!=null)
            {
                waterExtractorBehavior wBehavior = waterEx.GetComponent<waterExtractorBehavior>();
                if (wBehavior != null)
                {
                    tot_water_produce += wBehavior.waterProduce;
                }
            }
        }
        noWaterExtractors = waterExtractorList.Length;

        waterDeficit = CalculateWaterConsumption();
        waterPlusMinus = tot_water_produce - waterDeficit;

        waterLevel += waterPlusMinus;
        waterLevel = Mathf.Clamp(waterLevel, 0, maxWaterLevel);



        //Debug.Log("WaterLevel: "+waterLevel);
        return waterLevel;
    }
    private float CalculateWaterConsumption()
    {
        acropolisWaterConsumption = 0.1f;

        waterConsumption = acropolisWaterConsumption;
        return waterConsumption;
    }
}
