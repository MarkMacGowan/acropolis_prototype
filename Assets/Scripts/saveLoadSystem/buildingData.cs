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
    public float buildingH;
    public float buildingEn;
    public float buildingOx;

 public BuildingData()
    {
        this.buildingObject = null;
        this.buildingId = 0;
        this.buildingTag = "";
        this.buildingPosition = new float[3];
        this.buildingH = 100f;
        this.buildingEn = 100f;
        this.buildingOx = 100f;
    }
}
