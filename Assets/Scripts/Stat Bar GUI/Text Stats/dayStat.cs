using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dayStat : MonoBehaviour
{
    public GameObject day_night;

    public GameObject day_txt;

    public int day_Num;
    public string dayNumCon;
    // Start is called before the first frame update
    void Start()
    {   
       
    }

    // Update is called once per frame
    void Update()
    {    
        
        day_Num = day_night.GetComponent<dayNightCycle>().dayNumConvert;
        dayNumCon = day_Num.ToString();
        day_txt.GetComponent<TMPro.TextMeshProUGUI>().text = dayNumCon;
    }
}
