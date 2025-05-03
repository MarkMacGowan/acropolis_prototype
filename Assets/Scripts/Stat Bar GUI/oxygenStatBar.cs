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
    //public mainDomeStats main_dome_stats;
    //[SerializeField] private statManager stat_manager;
    [SerializeField] private oxygenManager oxygen_manager;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        oxygen = oxygen_manager.oxygenInfo();
        if (oxygenSlider.value != oxygen)
        {
            oxygenSlider.value = oxygen;
        }
    }
}
