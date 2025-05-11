using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygenStatBar : MonoBehaviour
{
    public Slider oxygenSlider;
    public float maxOxygen = 100f;
    public float oxygen;

    public GameObject main_settlement;
    
    [SerializeField] private oxygenManager oxygen_manager;
   

    
    void Update()
    {
        oxygen = oxygen_manager.oxygenInfo();
        if (oxygenSlider.value != oxygen)
        {
            oxygenSlider.value = oxygen;
        }
    }
}
