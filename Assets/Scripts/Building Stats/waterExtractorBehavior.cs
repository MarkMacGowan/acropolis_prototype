using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterExtractorBehavior :BuildingBehavior 
{
    public float maxWaterExtractorHealth=100f;
    public float waterExtractorHealth=100f;
    public float healthDecreaseRate = 0.01f;


    public float maxWaterAmount = 100f;
    public float waterAmount;

    public float waterProduce = 0.2f;

    public float maxWaterProduce = 1f;

    public int noWaterExtractors;


    // environmental concerns
    public bool isSandStorm = false;
    [SerializeField] public GameObject sand_storm;




    void Start()
    {
        waterAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        waterAmount = waterAmount + waterProduce;

        sand_storm = GameObject.FindWithTag("sandstorm2");

        isSandStorm = sand_storm.activeInHierarchy;
       // Debug.Log("Sandstorm Present: " + isSandStorm);
       // Debug.Log("Oxygen Processor Health: " + waterExtractorHealth);
        HealthDecrease(isSandStorm);



        if (waterProduce>maxWaterProduce)
        {
            waterProduce = maxWaterProduce;
        }

        if (waterAmount>maxWaterAmount)
        {
            waterAmount = maxWaterAmount;
        }
    }

    public void HealthDecrease(bool sStorm)
    {


        if (sStorm == true)
        {

            waterExtractorHealth -= healthDecreaseRate;
        }
    }
}
