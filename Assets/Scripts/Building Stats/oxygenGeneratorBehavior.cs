using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygenGeneratorBehavior : BuildingBehavior
{   
    [SerializeField] public GameObject main_dome;
    private float mainDomeEnergy;

    [SerializeField] public GameObject sand_storm;

    [SerializeField] private GameObject currentBuilding;
    [SerializeField] private GameObject parentBuildingObject;
    [SerializeField] private deleteBuilding delete_building;
    [SerializeField] private GameObject health_text;
    // health stat of oxygenGenerator 
    public float maxOxygenGenHealth=100f;
    public float oxygenGenHealth = 100f;
    public float healthDecreaseRate = 0.01f;


    // oxygen produced
    public float maxOxygenAmount=100f;
    public float oxygenAmount;

    // the amount of oxygen produced in a given time
    public float oxygenProduce = 0.2f;
    // the maximum amount of oxygen that can produced
    // by a generator in a given time 
    public float maxOxygenProduce = 1f;


    //variable that takes in energy of main 
    public bool isMainDomeEnergy = true;

    // environmental concerns
    public bool isSandStorm = false;

    // particle concerns
    [SerializeField] private GameObject explosion_fx;

    void Start()
    {
        main_dome = GameObject.FindGameObjectWithTag("mainSettle");
        
        oxygenAmount=0f;
        
       // StartExplosion();
    }

   
    void Update()
    {
        mainDomeEnergy = main_dome.gameObject.GetComponent<energyManager>().energyLevel;
        oxygenAmount = oxygenAmount + oxygenProduce;

        sand_storm = GameObject.FindWithTag("sandstorm2");

        isSandStorm = sand_storm.activeInHierarchy;
     //   Debug.Log("Sandstorm Present: " + isSandStorm);
     //   Debug.Log("Oxygen Processor Health: " + oxygenGenHealth);
        HealthDecrease(isSandStorm);
        if (oxygenProduce > maxOxygenProduce)
        {
            oxygenProduce = maxOxygenProduce;
        }


        if (oxygenAmount> maxOxygenAmount)
        {
            oxygenAmount = maxOxygenAmount;
        }
        
    }

    public void HealthDecrease(bool sStorm)
    {
        
        
        if (sStorm==true)
        {
            Debug.Log("Sandstorm!");
            oxygenGenHealth -= healthDecreaseRate;
            if (oxygenGenHealth <= 0)
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
        Object.Destroy(parentBuildingObject,3);
    }
}
