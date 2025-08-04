using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weatherManager : MonoBehaviour
{
    public List<GameObject> weather = new List<GameObject>();
    public float timePassed;
    //public float startTime;
    public float intervalTime;
    public float weatherDuration;
    // Start is called before the first frame update
    void Start()
    {
        //startTime = 10f;
        intervalTime = 20f;


        weatherDuration = 17f;


        InvokeRepeating("TimeMeasure",0f,1f);
        StartCoroutine(Waiter());
        //InvokeRepeating("WeatherActive",startTime,intervalTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TimeMeasure()
    {
        timePassed++;
    }

    IEnumerator Waiter()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalTime);
            weather[0].SetActive(true);
            yield return new WaitForSeconds(weatherDuration);
            weather[0].SetActive(false);
            
        }
        

    }
}
