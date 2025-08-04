using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodManager : MonoBehaviour
{
    // FOOD
    // food level of mainDome
    public float foodLevel;
    // maximum food level of mainDome
    private float maxFoodLevel=100f;
    // minimum food level of mainDome
    //private float minFoodLevel=0f;
    // rate at which food level is regenerated
    private float foodProduceRate;
    // rate at which food is consumed
    private float foodUsageRate;
    // counts number of hydrophonics placed in level
    // hydroponic building grows food

    public int noHydroPonics;
    // variable that stores each hydro ponic building instance
    private GameObject hydro_ponic;
    // total food grown from each hydro ponic building instance
    private float totFoodAmount;
    private float totFoodProduce;
    private float tot_food_produce;
    private float foodConsumptionRate=0.9f;
    private float acropolisFoodConsumption;
    private float foodConsumption;
    private float foodPlusMinus;
    private float foodDeficit;
    void Start()
    {
        foodLevel = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float foodInfo()
    {
        GameObject[] hydroPonicsList = GameObject.FindGameObjectsWithTag("hydroPonics");

        tot_food_produce = 0f;

        foreach (GameObject hydro in hydroPonicsList)
        {
            if (hydro != null)
            {
                hydroPonicsBehavior behavior = hydro.GetComponent<hydroPonicsBehavior>();
                if (behavior != null)
                {
                    tot_food_produce += behavior.foodProduce;
                }
            }
        }

        noHydroPonics = hydroPonicsList.Length;

        // Base consumption
        foodDeficit = CalculateFoodConsumption();
        foodPlusMinus = tot_food_produce - foodDeficit;

        foodLevel += foodPlusMinus;
        foodLevel = Mathf.Clamp(foodLevel, 0, maxFoodLevel);
        //CalculateFoodConsumption();
        //if (foodLevel > maxFoodLevel)
        //{
        //    foodLevel = maxFoodLevel;
        //}
        //if (foodLevel<0)
        //{
        //    foodLevel = 0;
        //}
        //foodLevel-=f
        //Debug.Log("FoodLevel: " + foodLevel);
        return foodLevel;
    }

    //public void FoodConsumption()
    //{
    //    Debug.Log("Food consumed");
    //    foodLevel -= foodConsumptionRate;
    //}

    private float CalculateFoodConsumption()
    {
        acropolisFoodConsumption = 0.1f;

        foodConsumption = acropolisFoodConsumption;
        return foodConsumption;
    }
}
