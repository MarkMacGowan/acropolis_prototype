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



    [SerializeField] private GameObject currentBuilding;
    [SerializeField] private GameObject parentBuildingObject;
    [SerializeField] private deleteBuilding delete_building;
    [SerializeField] private GameObject health_text;

    // environmental concerns
    public bool isSandStorm = false;
    [SerializeField] public GameObject sand_storm;

    // particle concerns
    [SerializeField] private GameObject explosion_fx;

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
            Debug.Log("Sandstorm!");
            waterExtractorHealth -= healthDecreaseRate;
            if (waterExtractorHealth <= 0)
            {
                Debug.Log("Health is 0");
                StartExplosion();
            }


        }
    }


    public void StartExplosion()
    {
        explosion_fx.SetActive(true);
        //   if (explosion_fx.GetComponent<explosiveShockwaveBehavior>().shockWaveDestroy.Equals(true))
        //   {
        // Debug.Log("OxyBehavior: Explosion Has Occured");
        BuildingRemove();
        health_text.SetActive(false);
        //  }

    }
    private void BuildingRemove()
    {
        Object.Destroy(currentBuilding);
        Object.Destroy(parentBuildingObject, 3);
    }
}
