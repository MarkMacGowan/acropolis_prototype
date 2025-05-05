using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]

public class gameData 
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

    // how many days have passed
    public int daysPassed;
    // how much supplies there are
    public int supplyLevelCurrent;

    // position of any building placed
    public float [] buildingPosition;
    // position of buildings in x, y, z coordinates
    public float buildingPositionX;
    public float buildingPositionY;
    public float buildingPositionZ;

    // the current scene by scene index
    public int sceneIndex;

    // whether its day or night
    public bool dayStatus;

    // angles of dayNightCycleObject
    public float[] dayNightAngle;

    // angles of dayNightCycleObject in different axis 
    public float dayNightAngleX;
    public float dayNightAngleY;
    public float dayNightAngleZ;

    // what buildings are currently in the game
    public List<GameObject> currentBuildings;
    
    
    // constructor for game data
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

        this.buildingPosition =new float [3];

        this.dayNightAngle = new float[3];
        this.dayNightAngleX = 0f;
        this.dayNightAngleY = 180f;
        this.dayNightAngleZ = 270f;


        this.currentBuildings = new List<GameObject>();

    }
}
