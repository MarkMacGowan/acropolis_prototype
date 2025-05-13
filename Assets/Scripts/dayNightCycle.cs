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


    public float angleOfSun;
    public float timeOfDay;
    public float timeOfDayHour;
    public float timeOfDayMinute;
    public float timeOfDaySeconds;

    private float timeOfDayHourCon;
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
        ConvertAngleToTime();

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
    public void ConvertAngleToTime()
    {
        // angel of sun in terms of degrees
        angleOfSun = gameObject.transform.rotation.eulerAngles.z;

        // calculate 1 hour of time in terms of degress
        // to make one rotation of 360 degrees, 24 hours must pass
        // this will equal 15 degrees
        timeOfDay = angleOfSun/ 24;

        // answer to this gives us a full day in base 10
        // 0.5 represents half a day, 0.25 a quarter etc
        timeOfDayHour = timeOfDay / 15;

        // convert number into 60 minute format.
        timeOfDayHourCon = (timeOfDayHour / 40)*1000;


       // timeOfDayMinute = timeOfDayHour / 0.01666666666f;
        //timeOfDaySeconds = timeOfDayMinute / 0.00027777777f;
        Debug.Log("Time: " +"H: "+ timeOfDayHourCon);
    }
}
