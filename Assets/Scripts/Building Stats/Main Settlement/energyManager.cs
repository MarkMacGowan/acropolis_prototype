using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energyManager : MonoBehaviour
{
    public float energyLevel = 0;
    // maximum energy level of mainDome
    private float maxEnergyLevel = 1000f;
    // minimum energy level of mainDome
    private float minEnergyLevel = 0f;
    // rate at which energyLevel regenerates
    private float energyProduceRate;
    // rate at which energy is used up
    private float energyUsageRate;
    // counts number of solar panels placed in level
    // solar panels provide energy from sun during daytime;
    public int noSolarPanels;
    // variable that stores each solar panel instance
    private GameObject solar_pan;

    // total energy gathered from each solar panel instance
    private float totSolarPanelEnergy;
    private float totSolarProduce;
    private float tot_energy_produce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float energyInfo()
    {
        solar_pan = GameObject.FindWithTag("solarPan");
        totSolarPanelEnergy = solar_pan.GetComponent<solarPanelBehavior>().solarEnergy;
        totSolarProduce = solar_pan.GetComponent<solarPanelBehavior>().energyProduce;
        noSolarPanels = GameObject.FindGameObjectsWithTag("solarPan").Length;
        energyProduceRate = totSolarPanelEnergy;
        //energyUsageRate = (solar_pan.GetComponent<solarPanelBehavior>()).energyUsage;
        energyLevel = energyLevel + energyProduceRate;
        if (energyLevel > maxEnergyLevel)
        {
            energyLevel = maxEnergyLevel;
        }
        return energyLevel;
    }
}
