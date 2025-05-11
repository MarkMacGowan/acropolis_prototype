using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygenManager : MonoBehaviour
{
    // OXYGEN
    // oxygen level of mainDome
    public float oxygenLevel = 0;
    // maximum oxygen level of mainDome
    private float maxOxygenLevel = 1000f;
    // minimum oxygen level of mainDome
    // private float minOxygenLevel = 0f;
    // rate at which oxygenLevel regenerates
    private float oxygenProduceRate;
    // rate at which oxygen is used up
    // private float oxygenUsageRate;
    // counts number of oxygen generators placed in level
    // oxygen generator produce oxygen from the thin atmosphere around it
    // during clear weather
    public int noOxyGens;
    // variable that stores each oxygen processor instance
    private GameObject oxygen_processor;
    // total oxygen gathered from each oxygen processor instance
    private float totOxygenAmount;
    public float totOxygenProduce;
    public int noOxygenGens;


 

    public float oxygenInfo()
    {
        oxygen_processor = GameObject.FindWithTag("oxyGen");
        totOxygenAmount = oxygen_processor.GetComponent<oxygenGeneratorBehavior>().oxygenAmount;
        totOxygenProduce = oxygen_processor.GetComponent<oxygenGeneratorBehavior>().oxygenProduce;
        noOxyGens = GameObject.FindGameObjectsWithTag("oxyGen").Length;
        oxygenProduceRate = totOxygenAmount;
        oxygenLevel = oxygenLevel + oxygenProduceRate;
        if (oxygenLevel > maxOxygenLevel)
        {
            oxygenLevel = maxOxygenLevel;
        }
        return oxygenLevel;
    }
}
