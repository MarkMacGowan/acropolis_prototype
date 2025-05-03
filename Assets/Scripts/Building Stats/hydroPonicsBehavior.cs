using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hydroPonicsBehavior : MonoBehaviour
{
    public float maxHydroponicHealth = 100f;
    public float hydroponicHealth = 100f;

    public float maxFoodAmount = 100f;
    public float foodAmount;

    // the amount of oxygen produced in a given time
    public float foodProduce = 0.2f;
    // the maximum amount of oxygen that can produced
    // by a generator in a given time 
    public float maxFoodProduce = 1f;



    public int noHydroPonics;
    // Start is called before the first frame update
    void Start()
    {
        foodAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        foodAmount = foodAmount + foodProduce;

        if (foodProduce > maxFoodProduce)
        {
            foodProduce = maxFoodProduce;
        }


        if (foodAmount > maxFoodAmount)
        {
            foodAmount = maxFoodAmount;
        }
    }
}
