using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodManager : MonoBehaviour
{
    // FOOD
    // food level of mainDome
    public float foodLevel=0;
    // maximum food level of mainDome
    private float maxFoodLevel=100f;
    // minimum food level of mainDome
    private float minFoodLevel=0f;
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
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float foodInfo()
    {
        hydro_ponic = GameObject.FindWithTag("hydroPonics");
        totFoodAmount = hydro_ponic.GetComponent<hydroPonicsBehavior>().foodAmount;
        totFoodProduce = hydro_ponic.GetComponent<hydroPonicsBehavior>().foodProduce;
        noHydroPonics = GameObject.FindGameObjectsWithTag("hydroPonics").Length;
        foodProduceRate = totFoodAmount;
        foodLevel = foodLevel + foodProduceRate;
        if (foodLevel > maxFoodLevel)
        {
            foodLevel = maxFoodLevel;
        }
        return foodLevel;
    }
}
