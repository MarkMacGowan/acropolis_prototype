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
    private float totSolarPanelEnergy;
    private float totSolarProduce;
    private float tot_energy_produce;

    // variables that deal with overall energy consumption
    public float energyDeficit;
    private float oxygenEnergyDeficit;
    private float hydroponicsEnergyDeficit;
    private float waterExtractorEnergyDeficit;
    private float landingpadEnergyDeficit;

    // variables to represent each building object that requires energy;
    private GameObject oxy_processor;
    private GameObject hydro_build;
    private GameObject water_extract;
    private GameObject land_pad;

    // variables to represent number of each building object instaniated into game
    private int noOxyGen;
    private int noHydro;
    private int noWaterExractor;
    private int noLandPad;



    private float energyPlusMinus;
    //private float energy_addition;
    //private float energy_subtraction;
    //private float energy_add;
    //private float energy_subtract;
    //private float energyPlus;

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
        energyDeficit = 1f;
        energyPlusMinus = energyProduceRate - energyDeficit;

        
        //energy_subtract = energySubtract();
        //energyDeficit = 1f;
        //energyUsageRate = (solar_pan.GetComponent<solarPanelBehavior>()).energyUsage;

        //oxy_processor = GameObject.FindWithTag("oxyGen");
        //noOxyGen = GameObject.FindGameObjectsWithTag("oxyGen").Length;

        // hydro_build = GameObject.FindWithTag("hydroPonics");
        // noHydro = GameObject.FindGameObjectsWithTag("hydroPonics").Length;

        //water_extract = GameObject.FindWithTag("waterExtract");
        // noWaterExractor = GameObject.FindGameObjectsWithTag("waterExtract").Length;

        //land_pad = GameObject.FindWithTag("landingPad");
        //noLandPad = GameObject.FindGameObjectsWithTag("landingPad").Length;
        //calculateEnergyUsage();
        //energy_addition = energyAddition();
        //energy_subtraction = energySubtract();

        //energyLevel = energyLevel + totSolarPanelEnergy;
        if (energyLevel > maxEnergyLevel)
        {
            energyLevel = maxEnergyLevel;
        }
        //finalEnergyLevel = energyLevel;
        //energy_addition-energy_subtraction;

        //finalEnergyLevel = energyLevel + (energy_subtract);
        if (finalEnergyLevel < minEnergyLevel)
        {
            finalEnergyLevel = minEnergyLevel;
        }else if (finalEnergyLevel > maxEnergyLevel)
        {
            finalEnergyLevel = maxEnergyLevel;
        }
        //-energySubtract();
        energyLevel = energyLevel +- (energyPlusMinus);
        return energyLevel;

    }
    //public float energySum()
    //{

    //   // energy_add = energySurplus();


    //    //energy_subtract = energySubtract();
    //    finalEnergyLevel = energyLevel + (energy_add);
    //    return finalEnergyLevel;
    //    //finalEnergyLevel = energy_add - (energy_subtract);
    //    //return finalEnergyLevel;
    //}
    //private float energySurplus()
    //{
    //    energyPlus = energyLevel + totSolarPanelEnergy;
    //    return energyPlus;
    //}
    //private float energySubtract()
    //{
    //    energyDeficit = energyDeficit + 1;
    //    return energyDeficit;
    //}
    //private float energyCal()
    //{

    //    finalEnergyLevel = energyLevel - (energyDeficit);
    //    return finalEnergyLevel;
    //}
    //private float energyCal()
    //{

    //}
    // method to add energy 
    //private float energyAddition()
    //{



    //    //finalEnergyLevel=energyLevel-energyDeficit;
    //    return energyLevel;
    //}
    ////method to subtract energy
    //private float energySubtract()
    //{
    //    energyDeficit = energyDeficit + 1f;
    //    return energyDeficit;
    //}

    //  private float calculateEnergyUsage()
    // {
    // 02 Gen
    //oxygenEnergyDeficit = noOxyGen * 2f;

    // hydroponics
    //hydroponicsEnergyDeficit = noHydro * 0.2f;

    // water extractor
    //waterExtractorEnergyDeficit = noWaterExractor * 0.4f;

    // landing pad
    //landingpadEnergyDeficit = noLandPad * 0.2f;


    // overall deficit

    //energyDeficit = oxygenEnergyDeficit + hydroponicsEnergyDeficit + waterExtractorEnergyDeficit + landingpadEnergyDeficit;

    //return energyDeficit;

    // }
}
