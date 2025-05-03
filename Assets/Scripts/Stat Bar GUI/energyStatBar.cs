using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyStatBar : MonoBehaviour
{
    public Slider energySlider;
    public float maxEnergy = 100f;
    public float energy;

    public GameObject main_settlement;
    public mainDomeStats main_dome_stats;
    //[SerializeField] statManager stat_manager;
    [SerializeField] energyManager energy_manager;
    // Start is called before the first frame update
    void Start()
    {
        //main_settlement = GameObject.Find("mainSettlement");
        //main_dome_stats = main_settlement.GetComponent<mainDomeStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        energy = energy_manager.energyInfo();
        if (energySlider.value != energy)
        {
            energySlider.value = energy;
        }
    }
}
