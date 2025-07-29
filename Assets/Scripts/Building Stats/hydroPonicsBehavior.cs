using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hydroPonicsBehavior : BuildingBehavior
{


    public float maxHydroponicHealth = 100f;
    public float hydroponicHealth = 100f;
    public float healthDecreaseRate = 0.01f;


    public float maxFoodAmount = 100f;
    public float foodAmount;

    // the amount of oxygen produced in a given time
    public float foodProduce = 0.2f;
    // the maximum amount of oxygen that can produced
    // by a generator in a given time 
    public float maxFoodProduce = 1f;



    public int noHydroPonics;



    // environmental concerns
    public bool isSandStorm = false;
    [SerializeField] public GameObject sand_storm;


    // Start is called before the first frame update
    void Start()
    {
        foodAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        foodAmount = foodAmount + foodProduce;

        sand_storm = GameObject.FindWithTag("sandstorm2");

        isSandStorm = sand_storm.activeInHierarchy;
       // Debug.Log("Sandstorm Present: " + isSandStorm);
     //   Debug.Log("Oxygen Processor Health: " + hydroponicHealth);
        HealthDecrease(isSandStorm);

        if (foodProduce > maxFoodProduce)
        {
            foodProduce = maxFoodProduce;
        }


        if (foodAmount > maxFoodAmount)
        {
            foodAmount = maxFoodAmount;
        }
    }

    public void HealthDecrease(bool sStorm)
    {


        if (sStorm == true)
        {

            hydroponicHealth -= healthDecreaseRate;
        }
    }
}
