using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class EnvironmentData 
{
    
    public int sceneIndex;

    public bool dayStatus;
    public float[] dayNightAngle;
    public int daysPassed;
    public GameObject weather;


    public EnvironmentData()
    {
        this.sceneIndex = 1;
        this.dayStatus = true;
        this.dayNightAngle = new float[3];
        this.daysPassed = 0;
        this.weather = new GameObject();
    }
}
