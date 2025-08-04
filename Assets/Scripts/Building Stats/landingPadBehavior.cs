using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landingPadBehavior : BuildingBehavior

{   
    [SerializeField] private GameObject timeObject;
    private dayNightCycle dnCycle;
    private float hourTime;
    private float minuteTime;

   // private float sunRotateZ;
    public float maxLandingPadHealth = 100f;
    public float landingPadHealth = 100f;
    public float healthDecreaseRate = 0.1f;
    public float healthRegenRate = 0.1f;

    public float maxSuppliesAmount = 100f;
    public float suppliesAmount;
    public float sAmount;

    public float suppliesProduce; 
   
    public float maxSuppliesProduce = 1f;

    public int noLandingPads;


    

    [SerializeField] private GameObject currentBuilding;
    [SerializeField] private GameObject parentBuildingObject;
    [SerializeField] private deleteBuilding delete_building;
    [SerializeField] private GameObject health_text;


    // environmental concerns
    [SerializeField] private GameObject weather_spawner;
    [SerializeField] private WorldReferences world_ref;
    [SerializeField] public GameObject sand_storm;



    public bool isSandStorm = false;

    // particle concerns
    [SerializeField] private GameObject explosion_fx;

    void Start()
    {
        timeObject= GameObject.FindGameObjectWithTag("dayNight");
        dnCycle = timeObject.GetComponent<dayNightCycle>();
        
        suppliesAmount = 0f;
        InvokeRepeating("FinaliseValue", 0f, .1f);
        //sAmount = 0f;
        //suppliesProduce = 1f/1000000f;
    }

   
    void Update()
    {
        weather_spawner = GameObject.FindWithTag("weatherSpawn");

        world_ref = weather_spawner.GetComponent<WorldReferences>();
        //sand_storm = GameObject.FindWithTag("sandstorm2");

        // isSandStorm = sand_storm.activeInHierarchy;
        //Debug.Log("Sandstorm Present: " + isSandStorm);
        // Debug.Log("Oxygen Processor Health: " + landingPadHealth);
        HealthCalculate();
        // suppliesAmount = suppliesAmount + suppliesProduce;

        //if (sAmount> maxSuppliesAmount)
        //{
        //    sAmount = maxSuppliesAmount;
        //}
    }

    public void FinaliseValue()
    {
        sAmount = SupplyDeliver();
       // Debug.Log("sAmount: " + sAmount);
    }

    public float SupplyDeliver()
    {
        hourTime = dnCycle.timeOfDayHourCon;
        minuteTime = dnCycle.displayMinute;
        //Debug.Log("MinuteTime: "+minuteTime);
       // Debug.Log(hourTime + "h " + minuteTime + "m");
        if (hourTime==6 && minuteTime==10)
        {
            //Debug.Log("Within Hour 9");
            suppliesAmount = 10;
             
           // Debug.Log("Within Minute 0");
                        //suppliesAmount = 30;
                    

        }

   
        //if (hourTime <= 10)
        //{
        //    suppliesAmount = 100;
        //}
        else
        {
            suppliesAmount = 0;
        }
       // Debug.Log("SuppliesAmount: "+suppliesAmount);
        return suppliesAmount;
    }

    public void HealthCalculate()
    {


        if (world_ref.sStorm.activeInHierarchy)
        {
           // Debug.Log("Sandstorm!");
            landingPadHealth -= healthDecreaseRate;
            if (landingPadHealth <= 0)
            {
               // Debug.Log("Health is 0");
                StartExplosion();
            }


        }
        else

        {
            //  Debug.Log("Clear Skies");
            if (landingPadHealth < maxLandingPadHealth)
            {
                landingPadHealth += healthRegenRate;
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
