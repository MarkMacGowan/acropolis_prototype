using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsMonitor : MonoBehaviour
{
    [SerializeField] private GameObject game_over_object;

    [SerializeField] private foodManager food_manager;
    [SerializeField] private waterManager water_manager;
    [SerializeField] private oxygenManager oxygen_manager;
    [SerializeField] private energyManager energy_manager;


    public float foodLevel;
    public float waterLevel;
    public float oxygenLevel;
    public float energyLevel;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        foodLevel = food_manager.foodInfo();
        waterLevel = water_manager.waterInfo();
        oxygenLevel = oxygen_manager.oxygenInfo();
        energyLevel = energy_manager.energyInfo();
    }
}
