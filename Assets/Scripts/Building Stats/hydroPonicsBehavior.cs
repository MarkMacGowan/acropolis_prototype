using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hydroPonicsBehavior : BuildingBehavior
{


    public float maxHydroponicHealth = 100f;
    public float hydroponicHealth = 100f;
    public float healthDecreaseRate = 0.01f;
    public float healthRegenRate = 0.1f;

    public float maxFoodAmount = 100f;
    public float foodAmount;

    // the amount of oxygen produced in a given time
    public float foodProduce = 0.2f;
    // the maximum amount of oxygen that can produced
    // by a generator in a given time 
    public float maxFoodProduce = 1f;



    public int noHydroPonics;

    [SerializeField] private GameObject currentBuilding;
    [SerializeField] private GameObject parentBuildingObject;
    [SerializeField] private deleteBuilding delete_building;
    [SerializeField] private GameObject health_text;

    // environmental concerns
    //public bool isSandStorm = false;

    [SerializeField] private GameObject weather_spawner;
    [SerializeField] private WorldReferences world_ref;
    [SerializeField] public GameObject sand_storm;

    // particle concerns
    [SerializeField] private GameObject explosion_fx;

    // Start is called before the first frame update
    void Start()
    {
        foodAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        foodAmount = foodAmount + foodProduce;

        weather_spawner = GameObject.FindWithTag("weatherSpawn");

        world_ref = weather_spawner.GetComponent<WorldReferences>();
        //sand_storm = GameObject.FindWithTag("sandstorm2");

        //isSandStorm = sand_storm.activeInHierarchy;
        // Debug.Log("Sandstorm Present: " + isSandStorm);
        //   Debug.Log("Oxygen Processor Health: " + hydroponicHealth);
        HealthCalculate();

        if (foodProduce > maxFoodProduce)
        {
            foodProduce = maxFoodProduce;
        }


        if (foodAmount > maxFoodAmount)
        {
            foodAmount = maxFoodAmount;
        }
    }

    public void HealthCalculate()
    {


        if (world_ref.sStorm.activeInHierarchy)
        {
            Debug.Log("Sandstorm!");
            hydroponicHealth -= healthDecreaseRate;
            if (hydroponicHealth <= 0)
            {
                Debug.Log("Health is 0");
                StartExplosion();
            }


        }
        else

        {
            //  Debug.Log("Clear Skies");
            if (hydroponicHealth < maxHydroponicHealth)
            {
                hydroponicHealth += healthRegenRate;
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
