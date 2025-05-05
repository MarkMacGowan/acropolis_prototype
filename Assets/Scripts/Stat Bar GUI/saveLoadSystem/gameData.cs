using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class gameData 
{
    public float healthLevelCurrent;
    public float oxygenLevelCurrent;
    public float energyLevelCurrent;
    public float foodLevelCurrent;
    public float waterLevelCurrent;

    public int daysPassed;
    public int supplyLevelCurrent;

    public int sceneIndex;

    public gameData()
    {
        this.healthLevelCurrent = 100f;
        this.oxygenLevelCurrent = 100f;
        this.energyLevelCurrent = 100f;
        this.foodLevelCurrent = 100f;
        this.waterLevelCurrent = 100f;

        this.daysPassed = 0;
        this.supplyLevelCurrent = 0;

        this.sceneIndex = 1;
    }
}
