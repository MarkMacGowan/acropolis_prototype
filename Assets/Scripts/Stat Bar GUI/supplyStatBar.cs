using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class supplyStatBar : MonoBehaviour
{
    public Slider supplySlider;
    public float maxSupplies=100f;
    public float supplies;

    public GameObject main_settlement;

    [SerializeField] private suppliesManager supplies_manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    // Update is called once per frame
    void Update()
    {   
        supplies = supplies_manager.suppliesInfo();
        if (supplySlider.value!=supplies)
        {
            supplySlider.value = supplies;
        }
    }
}
