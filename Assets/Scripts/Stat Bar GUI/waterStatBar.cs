using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterStatBar : MonoBehaviour
{
    public Slider waterSlider;
    public float maxWater=100f;
    public float water;
    [SerializeField] private GameObject main_settlement;
    [SerializeField] private waterManager water_manager;
    // Start is called before the first frame update
    void Start()
    {
        water = maxWater;
    }

    // Update is called once per frame
    void Update()
    {
        water = water_manager.waterInfo();
        if (waterSlider.value != water)
        {
            waterSlider.value = water;
        }
    }
}
