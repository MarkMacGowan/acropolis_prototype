using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyTextStat : MonoBehaviour
{
    public float maxEnergy;
    public float energy;

    public GameObject main_settlement;
    public string energyCon;

    [SerializeField] private energyManager energy_manager;
    [SerializeField] private GameObject energy_txt;

    void Start()
    {
        InvokeRepeating("EnergyCheck", 1f, 0.5f);
    }


    private void EnergyCheck()
    {
        energy = (int)energy_manager.energyInfo();
        energyCon = energy.ToString();
        energy_txt.GetComponent<TMPro.TextMeshProUGUI>().text = energyCon;
    }
}
