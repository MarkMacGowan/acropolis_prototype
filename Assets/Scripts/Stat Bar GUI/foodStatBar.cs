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
   
    [SerializeField] private foodManager food_manager;
  

    
    void Update()
    {
        food = food_manager.foodInfo();
        if (foodSlider.value != food)
        {
            foodSlider.value = food;
        }
    }
}
