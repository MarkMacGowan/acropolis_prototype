using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayNightCycle : MonoBehaviour
{
    public float timeNum=1f;
    public float timeRate=.01f;

    // how many degress per second the object rotates
    public float rotationalNumZ;

    // number of days passed in float datatype
    public float dayNum;

    // number of days passed in int datatype
    public int dayNumConvert;

    // bool variable that stores day or night
    public bool dayTime;

    // Start is called before the first frame update
    void Start()
    {
        
        dayNum = 0.25f;
    }

   
    void Update()
    {
        rotationalNumZ = timeNum * timeRate;
        transform.Rotate(0f,0f,rotationalNumZ);
        dayNum += rotationalNumZ / 360;
        dayNumConvert = ((int)dayNum);

    }

    public bool TimeOfDay()
    {
        if (rotationalNumZ <= 90)
        {
            dayTime = true;
        }
        else if (rotationalNumZ >= 270)
        {
            dayTime = true;
        }
        else
        {
            dayTime = false;
        }
        return dayTime;
    }
}
