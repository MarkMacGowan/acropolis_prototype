using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTextStat : MonoBehaviour
{
    public float maxWater;
    public float water;

    public GameObject main_settlement;
    public string waterCon;

    [SerializeField] private waterManager water_manager;
    [SerializeField] private GameObject water_txt;

    void Start()
    {
        InvokeRepeating("WaterCheck", 1f, 0.5f);
    }


    private void WaterCheck()
    {
        water = (int)water_manager.waterLevel;
        waterCon = water.ToString();
        water_txt.GetComponent<TMPro.TextMeshProUGUI>().text = waterCon;
    }
}
