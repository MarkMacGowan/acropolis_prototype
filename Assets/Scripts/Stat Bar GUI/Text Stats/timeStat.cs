using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeStat : MonoBehaviour
{


    //public GameObject main_settlement;
    //public string suppliesCon;

    //[SerializeField] private suppliesManager supplies_manager;
    // [SerializeField] private GameObject supplies_txt;
    [SerializeField] private GameObject dnObj;
    private dayNightCycle dnCyc;

    [SerializeField] private GameObject time_txt;

    private string dTime;


    
    void Update()
    {
        dTime = dnObj.GetComponent<dayNightCycle>().displayTime;
       // supplies = (int)supplies_manager.SuppliesInfo();
        //suppliesCon = supplies.ToString();
        time_txt.GetComponent<TMPro.TextMeshProUGUI>().text = dTime;
    }
}
