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
    public float buildingHealth;
    public float buildingEnergy;
    public float buildingOxygen;

 public BuildingData()
    {
        this.buildingObject = null;
        this.buildingId = 0;
        this.buildingTag = "";
        this.buildingPosition = new float[3];
        this.buildingHealth = 100f;
        this.buildingEnergy = 100f;
        this.buildingOxygen = 100f;
    }
}
