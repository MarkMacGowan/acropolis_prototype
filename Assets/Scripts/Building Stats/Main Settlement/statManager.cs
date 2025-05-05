using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statManager : MonoBehaviour
{
    //public oxygenManager oxygen_manager;
   //[SerializeField] private oxygenManager oxygen_manager;
   //[SerializeField] private energyManager energy_manager;
   //public float oxygenLvl;
   //public float energyLvl;
    //[SerializeField] private UnityEngine.UI.Slider oxygenSlider;

    // HEALTH
    // healthLevel of mainDome
    //public float healthLevel;
    // maximum health level of mainDome
    //private float maxHealthLevel = 100f;
    // minimum health level of mainDome
   // private float minHealthLevel = 0f;
    // rate at which the healthLevel regenerates
   // private float healthRechargeRate;

    // OXYGEN
    //// oxygen level of mainDome
    //public float oxygenLevel = 0;
    //// maximum oxygen level of mainDome
    //private float maxOxygenLevel = 1000f;
    //// minimum oxygen level of mainDome
    //private float minOxygenLevel = 0f;
    //// rate at which oxygenLevel regenerates
    //private float oxygenProduceRate;
    //// rate at which oxygen is used up
    //private float oxygenUsageRate;
    //// counts number of oxygen generators placed in level
    //// oxygen generator produce oxygen from the thin atmosphere around it
    //// during clear weather
    //public int noOxyGens;
    //// variable that stores each oxygen processor instance
    //private GameObject oxygen_processor;
    //// total oxygen gathered from each oxygen processor instance
    //private float totOxygenAmount;
    //public float totOxygenProduce;
    //public int noOxygenGens;

    //// ENERGY
    //// energy level of mainDome

    ////public energyManager energy_manager;
    //// public float energy_Level;

    //public float energyLevel = 0;
    //// maximum energy level of mainDome
    //private float maxEnergyLevel = 1000f;
    //// minimum energy level of mainDome
    //private float minEnergyLevel = 0f;
    //// rate at which energyLevel regenerates
    //private float energyProduceRate;
    //// rate at which energy is used up
    //private float energyUsageRate;
    //// counts number of solar panels placed in level
    //// solar panels provide energy from sun during daytime;
    //public int noSolarPanels;
    //// variable that stores each solar panel instance
    //private GameObject solar_pan;

    //// total energy gathered from each solar panel instance
    //private float totSolarPanelEnergy;
    //private float totSolarProduce;
    //private float tot_energy_produce;

    //// FOOD
    //// food level of mainDome
    //public float foodLevel;
    //// maximum food level of mainDome
    //private float maxFoodLevel;
    //// minimum food level of mainDome
    //private float minFoodLevel;
    //// rate at which food level is regenerated
    //private float foodProduceRate;
    //// rate at which food is consumed
    //private float foodUsageRate;
    //// counts number of hydrophonics placed in level
    //// hydroponic building grows food
    //public int noHydroPonics;
    //private GameObject hydro_ponic;
    //private float totFoodAmount;
    //private float totFoodProduce;
    //private float tot_food_produce;




    // WATER
    // water level of mainDome
    //public float waterLevel;
    // maximum water level of mainDome
    //private float maxWaterLevel = 100f;
    // minimum water level of mainDome
   // private float minWaterLevel = 0f;
    // rate at which water level is regenerated
   // public float waterProduceRate;
    // rate at which water is used up
   // private float waterUsageRate;
    // counts number of water purifers placed in level
    // water purifers purify water from ice
   // public int noWaterPurifers;

    // SUPPLIES (currency)
    // supply level of mainDome
    //public float supplyLevel;
    // maximum supply level of mainDome
    // private float maxSupplyLevel;
    // minimum supply level of mainDome
    //private float minSupplyLevel;
    // rate at which supply level is regenerated
    //private float supplyRate;
    // rate at which suppl level is depleted
    //private float supplyUsageRate;
    // counts number of landing pads placed in level
    // landing pads import supplies when weather is clear
    //public int noLandingPads;
    // counts number of storage buildings placed in level
    // storage buildings store food, water, oxygen or supplies
   // public int noStorageBuildings;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // resourceManager();
    }
    public void resourceManager()
    {
       // healthManager();
        //oxygenLvl =oxygen_manager.oxygenInfo();
        //energyLvl =energy_manager.energyInfo();
        //oxygenManager();
       // energyManager();
        //foodManager();
        //waterManager();
        //suppliesManager();
    }
    public void healthManager()
    {

    }
    public void oxygenManager()
    {
        //oxygen_processor = GameObject.FindWithTag("oxyGen");
        //totOxygenAmount = oxygen_processor.GetComponent<oxygenGeneratorBehavior>().oxygenAmount;
        //totOxygenProduce = oxygen_processor.GetComponent<oxygenGeneratorBehavior>().oxygenProduce;
        //noOxyGens = GameObject.FindGameObjectsWithTag("oxyGen").Length;
        //oxygenProduceRate = totOxygenAmount;
        //oxygenLevel = oxygenLevel + oxygenProduceRate;
        //if (oxygenLevel > maxOxygenLevel)
        //{
        //    oxygenLevel = maxOxygenLevel;
        //}
    }
    public void energyManager()
    {
        //solar_pan = GameObject.FindWithTag("solarPan");
        //totSolarPanelEnergy = solar_pan.GetComponent<solarPanelBehavior>().solarEnergy;
        //totSolarProduce = solar_pan.GetComponent<solarPanelBehavior>().energyProduce;
        //noSolarPanels = GameObject.FindGameObjectsWithTag("solarPan").Length;
        //energyProduceRate = totSolarPanelEnergy;
        ////energyUsageRate = (solar_pan.GetComponent<solarPanelBehavior>()).energyUsage;
        //energyLevel = energyLevel + energyProduceRate;
        //if (energyLevel > maxEnergyLevel)
        //{
        //    energyLevel = maxEnergyLevel;
        //}


    }
    public void foodManager()
    {
        //hydro_ponic = GameObject.FindWithTag("hydroPonics");
        //totFoodAmount = hydro_ponic.GetComponent<hydroPonicsBehavior>().foodAmount;
        //totFoodProduce = hydro_ponic.GetComponent<hydroPonicsBehavior>().foodProduce;
        //noHydroPonics = GameObject.FindGameObjectsWithTag("hydroPonics").Length;
        //foodProduceRate = totFoodAmount;
        ////energyUsageRate = (solar_pan.GetComponent<solarPanelBehavior>()).energyUsage;
        //foodLevel = foodLevel + foodProduceRate;
        //if (foodLevel > maxFoodLevel)
        //{
        //    foodLevel = maxFoodLevel;
        //}
    }
    public void waterManager()
    {

    }

    public void suppliesManager()
    {

    }
}
