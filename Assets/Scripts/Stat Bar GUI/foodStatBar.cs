using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodStatBar : MonoBehaviour
{
    public Slider foodSlider;
    public float maxFood=100f;
    public float food;

    public GameObject main_settlement;
    //public mainDomeStats main_dome_stats;
    [SerializeField] private foodManager food_manager;
    // Start is called before the first frame update
    void Start()
    {
        //food = maxFood;
        
    }

    // Update is called once per frame
    void Update()
    {
        food = food_manager.foodInfo();
        if (foodSlider.value != food)
        {
            foodSlider.value = food;
        }
    }
}
