using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class solarPanelBehavior : MonoBehaviour
{
    //public keyboardInput key_board_input;
    //public bool is_placed;
    public float maxSolarHealth = 100f;
    public float solarHealth = 100f;

    public float maxSolarEnergy = 2f;
    public float minSolarEnergy = 0f;
    public float solarEnergy = 0f;
    // how much this object consumes energy
    //public float energyUsage=0.00001f;
    public float energyProduce;// = 0.00000002f;
    public float maxEnergyProduce = 1f;


    
    private GameObject dayNight_CycleObject;
    private float sunAngle;
    private bool isDaytime;

 




    // Start is called before the first frame update
    void Start()
    {
        solarEnergy = 0f;
        dayNight_CycleObject = GameObject.FindGameObjectWithTag("dayNight");
    }

    // Update is called once per frame
    void Update()
    {          
       

        energyProduce=calculateEnergyProduction();
        Debug.Log("Energy Production: "+energyProduce);
        //is_placed = key_board_input.isPlaced;
        solarEnergy = solarEnergy + energyProduce;
        //solarRate = solarRate + Time.deltaTime * 1;


        //if (solarRate>maxSolarRate)
        //   {
        //       solarRate = maxSolarRate;
        //   }
        if (energyProduce > maxEnergyProduce)
        {
            energyProduce = maxEnergyProduce;
        }


        if (solarEnergy > maxSolarEnergy)
        {
            solarEnergy = maxSolarEnergy;
        }



        //Debug.Log("Hello World");
    }
    //private void checkLightLevels()
    //{   
    //    // takes in current position of solar panel object
    //    Vector3 objPosition =gameObject.transform.position;

    //    Renderer renderer;
    //    SphericalHarmonicsL2 probe = new SphericalHarmonicsL2();
    //    LightProbes.GetInterpolatedProbe(objPosition,renderer,out probe);
    //}

    private float calculateEnergyProduction()
    {
        
       sunAngle=dayNight_CycleObject.transform.rotation.eulerAngles.z;
       Debug.Log("Is Day Time: "+checkTimeOfDay()+" Angle: "+sunAngle);
       checkTimeOfDay();
       if (isDaytime==true)
        {
            energyProduce = 0.00000002f;
            Debug.Log("Producing Energy!");
        }
        else if(isDaytime==false)
        {   
            energyProduce = 0;
            Debug.Log("No Energy To Be Found");
        }
        return energyProduce;
    }
    private bool checkTimeOfDay()
    {   
        
       
       if (sunAngle <= 90)
        {
            isDaytime = true;
        }
        else if (sunAngle>=270)
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
