using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTextStat : MonoBehaviour
{
    public float maxFood;
    public float food;

    public GameObject main_settlement;
    public string foodCon;

    [SerializeField] private foodManager food_manager;
    [SerializeField] private GameObject food_txt;

    void Start()
    {
        InvokeRepeating("FoodCheck", 1f, 0.5f);
    }


    private void FoodCheck()
    {
        food = (int)food_manager.foodInfo();
        foodCon = food.ToString();
        food_txt.GetComponent<TMPro.TextMeshProUGUI>().text = foodCon;
    }
}
