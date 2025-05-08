using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BuildingData 
{
    public GameObject buildingObject;
    public int buildingId;
    public string buildingTag;
    public float [] buildingPosition;
    public float bHealth;
    public float bEnergy;
    public float bOxygen;

 public BuildingData()
    {
        this.buildingObject = null;
        this.buildingId = 0;
        this.buildingTag = "";
        this.buildingPosition = new float[3];
        this.bHealth = 100f;
        this.bEnergy = 100f;
        this.bOxygen = 100f;
    }
}
