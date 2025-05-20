using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayNightCycle : MonoBehaviour
{
    public float timeNum=1f;
    public float timeRate=.001f;

    // how many degress per second the object rotates
    public float rotationalNumZ;

    // number of days passed in float datatype
    public float dayNum;

    // number of days passed in int datatype
    public int dayNumConvert;

    // bool variable that stores day or night
    public bool dayTime;


    private float angleOfSun;
    private float angleOfSunOffset;
    private float timeOfDay;
    private float timeOfDayHour;
    private float timeOfDayMinute;
    private float timeOfDaySecond;

    public float timeOfDayHourCon;
    public float timeOfDayMinuteCon;
    private float timeOfDaySecondCon;


    public float displayHour;
    public float displayMinute;
    private float displaySec;

    public string displayTime;
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
        angleOfSun = gameObject.transform.localRotation.eulerAngles.z;
        // take angle and offset it by 180 degrees, so the 0 degree will be at midnight

        //angleOfSunOffset =angleOfSun + 180;
       // Debug.Log("AngleOfSun: " + angleOfSun);

        // calculate 1 hour of time in terms of degress
        // to make one rotation of 360 degrees, 24 hours must pass
        // this will equal 15 degrees
        timeOfDay = angleOfSun/ 24;



        // answer to this gives us a full day in base 10
        // 0.5 represents half a day, 0.25 a quarter etc
        timeOfDayHour = angleOfSun / 15;
        timeOfDayHourCon = Mathf.FloorToInt(timeOfDayHour);
        timeOfDayMinute = timeOfDayHour - (timeOfDayHourCon);
        timeOfDayMinuteCon = timeOfDayMinute * 60;

        displayHour = timeOfDayHourCon;
        displayMinute = timeOfDayMinuteCon;
        // convert number into 60 minute format.
       // timeOfDayHourCon = (timeOfDayHour / 40)*1000;
       // Debug.Log("timeOfDayHourCon"+timeOfDayHourCon);
        //displayHour = Mathf.FloorToInt(timeOfDayHourCon);
        
        
        
        //timeOfDayMinute = timeOfDayHourCon - displayHour;
        //Debug.Log("timeOfDayMinute: " + timeOfDayMinute);
        //timeOfDayMinuteCon = (timeOfDayMinute / 16.28f) * 1000;
        displayMinute = Mathf.FloorToInt(timeOfDayMinuteCon);
        displayTime = displayHour + "h " + displayMinute + "m";
        //Debug.Log("Time: " + displayHour+ "h "+displayMinute+"m");
       // Debug.Log(displayTime);
       // timeOfDayMinute = timeOfDayHour / 0.01666666666f;
        //timeOfDaySeconds = timeOfDayMinute / 0.00027777777f;

        
    }
}
