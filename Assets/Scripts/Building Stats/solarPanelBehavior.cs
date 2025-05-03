using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class solarPanelBehavior : MonoBehaviour
{   
    //public keyboardInput key_board_input;
    //public bool is_placed;
    public float maxSolarHealth=100f;
    public float solarHealth=100f;

    public float maxSolarEnergy = 2f;
    public float minSolarEnergy = 0f;
    public float solarEnergy=0f;

    // how much this object consumes energy
    
    public float energyProduce = 0.00000002f;
    public float maxEnergyProduce = 1f;
    //public float energyUsage=0.00001f;

    
    // Start is called before the first frame update
    void Start()
    {
        solarEnergy = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //is_placed = key_board_input.isPlaced;
        solarEnergy = solarEnergy+ energyProduce;
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
        
   
        
    }
    private void checkLightLevels()
    {
        SphericalHarmonicsL2 harmonics = new SphericalHarmonicsL2();
    }
}
