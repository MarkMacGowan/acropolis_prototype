using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statBar : MonoBehaviour
{   
    public Slider oxygenSlider; 
    public float maxOxygen = 100f;
    public float oxygen;

    public Slider energySlider;
    public float maxEnergy = 100f;
    public float energy;

    public Slider healthSlider;
    public float maxHealth=100f;
    public float health;

    public Slider foodSlider;
    public float maxFood = 100f;
    public float food;

    // Start is called before the first frame update
    void Start()
    {
        oxygen = maxOxygen;
        energy = maxEnergy;
        health = maxHealth;
        food = maxFood;
    }

    // Update is called once per frame
    void Update()
    {
        if (oxygenSlider.value != oxygen)
        {
            oxygenSlider.value = oxygen;
        }

        if (energySlider.value != energy)
        {
            energySlider.value = energy;
        }
    }
}
