using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class StatData 
{
    // the health level of the main settlement
    public float healthLevelCurrent;

    // how much oxygen there is 
    public float oxygenLevelCurrent;

    // how much energy there is 
    public float energyLevelCurrent;

    // how much food there is
    public float foodLevelCurrent;

    // how much water there is
    public float waterLevelCurrent;

    // how much supplies there are
    public int supplyLevelCurrent;
    public StatData()
    {
        this.healthLevelCurrent = 100f;
        this.oxygenLevelCurrent = 100f;
        this.energyLevelCurrent = 100f;
        this.foodLevelCurrent = 100f;
        this.waterLevelCurrent = 100f;
        this.supplyLevelCurrent = 100;
    }
}
