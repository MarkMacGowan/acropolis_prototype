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
    public float healthDecreaseRate = 0.01f;


    public float maxSuppliesAmount = 100f;
    public float suppliesAmount;
    public float sAmount;

    public float suppliesProduce; 
   
    public float maxSuppliesProduce = 1f;

    public int noLandingPads;

    // environmental concerns
    public bool isSandStorm = false;
    [SerializeField] public GameObject sand_storm;


    void Start()
    {
        timeObject= GameObject.FindGameObjectWithTag("dayNight");
        dnCycle = timeObject.GetComponent<dayNightCycle>();
        
        suppliesAmount = 0f;
        InvokeRepeating("FinaliseValue", 2f, .5f);
        //sAmount = 0f;
        //suppliesProduce = 1f/1000000f;
    }

   
    void Update()
    {

        sand_storm = GameObject.FindWithTag("sandstorm2");

        isSandStorm = sand_storm.activeInHierarchy;
        //Debug.Log("Sandstorm Present: " + isSandStorm);
       // Debug.Log("Oxygen Processor Health: " + landingPadHealth);
        HealthDecrease(isSandStorm);
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
        if (hourTime==9 && minuteTime==0)
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

    public void HealthDecrease(bool sStorm)
    {


        if (sStorm == true)
        {

            landingPadHealth -= healthDecreaseRate;
        }
    }

}
