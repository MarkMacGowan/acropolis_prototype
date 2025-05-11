using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyStatBar : MonoBehaviour
{
    public Slider energySlider;
    public float maxEnergy = 100f;
    public float energy;

    public GameObject main_settlement;
    
   
    [SerializeField] energyManager energy_manager;
   

   
    void Update()
    {
        energy = energy_manager.energyInfo();
        if (energySlider.value != energy)
        {
            energySlider.value = energy;
        }
    }
}
