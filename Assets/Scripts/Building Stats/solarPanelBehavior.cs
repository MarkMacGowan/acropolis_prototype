using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class solarPanelBehavior : BuildingBehavior
{
   
    public float maxSolarHealth = 100f;
    public float solarHealth = 100f;

    public float maxSolarEnergy = 2f;
    public float minSolarEnergy = 0f;
    public float solarEnergy = 0f;
    // how much this object consumes energy
    
    public float energyProduce;
    public float maxEnergyProduce;


    
    private GameObject dayNight_CycleObject;

    private float sunAngleX;
    private float sunAngleY;
    private float sunAngleZ;
    private bool isDaytime;

 




    
    void Start()
    {
        solarEnergy = 0f;
        dayNight_CycleObject = GameObject.FindGameObjectWithTag("dayNight");
    }

    
    void Update()
    {          
       

        energyProduce=calculateEnergyProduction();
        
        solarEnergy = solarEnergy + energyProduce;
       


     
        if (energyProduce > maxEnergyProduce)
        {
            energyProduce = maxEnergyProduce;
        }


        if (solarEnergy > maxSolarEnergy)
        {
            solarEnergy = maxSolarEnergy;
        }



        
    }
 

    private float calculateEnergyProduction()
    {
       sunAngleX= dayNight_CycleObject.transform.rotation.eulerAngles.x;
       sunAngleY= dayNight_CycleObject.transform.rotation.eulerAngles.y;
       sunAngleZ =dayNight_CycleObject.transform.rotation.eulerAngles.z;
       
      
       checkTimeOfDay();
       if (isDaytime==true)
        {
            energyProduce = 2f;
            //Debug.Log("Producing Energy!");
        }
        else if(isDaytime==false)
        {   
            energyProduce = 0;
            //Debug.Log("No Energy To Be Found");
        }
        return energyProduce;
    }
    private bool checkTimeOfDay()
    {   
        
       
       if (sunAngleZ <= 90)
        {
            isDaytime = true;
        }
        else if (sunAngleZ>=270)
        {
            isDaytime = true;
        }
        else
        {
            isDaytime = false;
        }
        return isDaytime;
    }
    private void checkCloudCover()
    {

    }
}
