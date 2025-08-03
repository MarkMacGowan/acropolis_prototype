using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class solarPanelBehavior : BuildingBehavior
{

    public float maxSolarHealth = 100f;
    public float solarHealth = 100f;
    public float healthDecreaseRate = 0.01f;
    public float healthRegenRate = 0.1f;


    public float maxSolarEnergy = 2f;
    public float minSolarEnergy = 0f;
    public float solarEnergy = 0f;
    // how much this object consumes energy

    public float energyProduce;
    public float maxEnergyProduce;



    private GameObject dayNight_CycleObject;

    private float sunAngleX;
    private float sunAngleY;
    private float sunAngleZ;
    private bool isDaytime;


    [SerializeField] public GameObject sand_storm;
    

    [SerializeField] private GameObject currentBuilding;
    [SerializeField] private GameObject parentBuildingObject;
    [SerializeField] private deleteBuilding delete_building;
    [SerializeField] private GameObject health_text;


    // environmental concerns
    [SerializeField] private GameObject weather_spawner;
    [SerializeField] private WorldReferences world_ref;
    public bool isSandStorm = false;

    // particle concerns
    [SerializeField] private GameObject explosion_fx;


    void Start()
    {
        solarEnergy = 0f;
        dayNight_CycleObject = GameObject.FindGameObjectWithTag("dayNight");
    }


    void Update()
    {


        energyProduce = calculateEnergyProduction();

        solarEnergy = solarEnergy + energyProduce;

        //sand_storm = GameObject.FindWithTag("sandstorm2");

        //isSandStorm = sand_storm.activeInHierarchy;
        //Debug.Log("Sandstorm Present: " + isSandStorm);
        //Debug.Log("Solar Panel Health: " + solarHealth);
        weather_spawner = GameObject.FindWithTag("weatherSpawn");

        world_ref = weather_spawner.GetComponent<WorldReferences>();
        HealthCalculate();


        if (energyProduce > maxEnergyProduce)
        {
            energyProduce = maxEnergyProduce;
        }


        if (solarEnergy > maxSolarEnergy)
        {
            solarEnergy = maxSolarEnergy;
        }




    }


    private float calculateEnergyProduction()
    {
        sunAngleX = dayNight_CycleObject.transform.rotation.eulerAngles.x;
        sunAngleY = dayNight_CycleObject.transform.rotation.eulerAngles.y;
        sunAngleZ = dayNight_CycleObject.transform.rotation.eulerAngles.z;


        checkTimeOfDay();
        if (isDaytime == true)
        {
            energyProduce = 2f;
            //Debug.Log("Producing Energy!");
        }
        else if (isDaytime == false)
        {
            energyProduce = 0;
            //Debug.Log("No Energy To Be Found");
        }
        return energyProduce;
    }
    private bool checkTimeOfDay()
    {


        if (sunAngleZ <= 90)
        {
            isDaytime = true;
        }
        else if (sunAngleZ >= 270)
        {
            isDaytime = true;
        }
        else
        {
            isDaytime = false;
        }
        return isDaytime;
    }
    private void checkCloudCover()
    {

    }
    public void HealthCalculate()
    {


        if (world_ref.sStorm.activeInHierarchy)
        {
           // Debug.Log("Sandstorm!");
            solarHealth -= healthDecreaseRate;
            if (solarHealth <= 0)
            {
               // Debug.Log("Health is 0");
                StartExplosion();
            }


        }
        else

        {
            //Debug.Log("Clear Skies");
            if (solarHealth < maxSolarHealth)
            {
                solarHealth += healthRegenRate;
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
        Object.Destroy(parentBuildingObject,3);
    }



}