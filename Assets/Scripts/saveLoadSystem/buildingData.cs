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
    

 public BuildingData()
    {
        this.buildingObject = null;
        this.buildingId = buildingObject.GetInstanceID();
        this.buildingTag = buildingObject.tag;
        this.buildingPosition = new float[3];
    }
}
