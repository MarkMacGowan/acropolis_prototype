using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energyManager : MonoBehaviour
{
    public float energyLevel = 0;
    public float finalEnergyLevel;
    // maximum energy level of mainDome
    private float maxEnergyLevel = 100f;
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
    public float totSolarPanelEnergy;
    public float totSolarProduce;
    private float tot_energy_produce;
    public float tot_solar_produce;

    // variables that deal with overall energy consumption
    public float energyDeficit;
    private float energy_deficit;
    private float acropolisEnergyDeficit;
    private float oxygenEnergyDeficit;
    private float hydroponicsEnergyDeficit;
    private float waterExtractorEnergyDeficit;
    private float landingpadEnergyDeficit;



    // variables to represent number of each building object instaniated into game
    private int noOxyGen;
    private int noHydro;
    private int noWaterExractor;
    private int noLandPad;



    public float energyPlusMinus;
    public float solar_produce;


    public float energyInfo()
    {   
        solar_pan = GameObject.FindWithTag("solarPan");
        totSolarPanelEnergy = solar_pan.GetComponent<solarPanelBehavior>().solarEnergy;
        solar_produce = solar_pan.GetComponent<solarPanelBehavior>().energyProduce;
        noSolarPanels = GameObject.FindGameObjectsWithTag("solarPan").Length;


        tot_solar_produce = solar_produce * noSolarPanels;
        energyProduceRate = totSolarPanelEnergy;

        energy_deficit = calculateDeficit();
        energyPlusMinus = tot_solar_produce - energy_deficit;

        
   

        //oxy_processor = GameObject.FindWithTag("oxyGen");
        noOxyGen = GameObject.FindGameObjectsWithTag("oxyGen").Length;

        // hydro_build = GameObject.FindWithTag("hydroPonics");
        noHydro = GameObject.FindGameObjectsWithTag("hydroPonics").Length;

        //water_extract = GameObject.FindWithTag("waterExtract");
        noWaterExractor = GameObject.FindGameObjectsWithTag("waterExtract").Length;

        //land_pad = GameObject.FindWithTag("landingPad");
        noLandPad = GameObject.FindGameObjectsWithTag("landingPad").Length;
  
        if (finalEnergyLevel < minEnergyLevel)
            {
            finalEnergyLevel = minEnergyLevel;
            }
        else if (finalEnergyLevel > maxEnergyLevel)
            {
            finalEnergyLevel = maxEnergyLevel;
            }
      
        energyLevel = energyLevel + (energyPlusMinus);

        if (energyLevel > maxEnergyLevel)
            {
            energyLevel = maxEnergyLevel;
            }
        if (energyLevel<minEnergyLevel)
        {
            energyLevel = minEnergyLevel;
        }

        return energyLevel;

    }

    private float calculateDeficit()
    {
        acropolisEnergyDeficit = 0.06f;

        Debug.Log("No Oxygen Processor: "+ noOxyGen);
        oxygenEnergyDeficit = 1.5f * noOxyGen;

        Debug.Log("No Hydro ponic: " + noHydro);
        hydroponicsEnergyDeficit = 1.5f * noHydro;

        Debug.Log("No Water Extractor: " + noWaterExractor);
        waterExtractorEnergyDeficit = 1.5f * noWaterExractor;

        Debug.Log("No Landing Pads: " + noLandPad);
        landingpadEnergyDeficit = 1.5f * noLandPad;

        energyDeficit = acropolisEnergyDeficit + oxygenEnergyDeficit + hydroponicsEnergyDeficit + waterExtractorEnergyDeficit + landingpadEnergyDeficit;


        return energyDeficit;
    }

}
