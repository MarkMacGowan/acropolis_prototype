using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterManager : MonoBehaviour
{
    public float waterLevel = 0;
    private float maxWaterLevel = 100f;
    private float minWaterLevel = 0f;
    private float waterProductRate;
    private float waterUsageRate;

    public int noWaterExtractors;
    private GameObject water_extractor;

    private float totWaterAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float waterInfo()
    {
        water_extractor = GameObject.FindWithTag("waterExtract");
        totWaterAmount = water_extractor.GetComponent<waterExtractorBehavior>().waterAmount;
        noWaterExtractors = GameObject.FindGameObjectsWithTag("waterExtract").Length;
        waterProductRate = totWaterAmount;
        waterLevel = waterLevel + waterProductRate;
        if (waterLevel>maxWaterLevel)
        {
            waterLevel = maxWaterLevel;
        }
        return waterLevel;
    }
}
