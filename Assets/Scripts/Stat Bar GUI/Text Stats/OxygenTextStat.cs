using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTextStat : MonoBehaviour
{
    public float maxOxygen;
    public float oxygen;

    public GameObject main_settlement;
    public string oxygenCon;

    [SerializeField] private oxygenManager oxygen_manager;
    [SerializeField] private GameObject oxygen_txt;

    void Start()
    {
        InvokeRepeating("OxygenCheck", 1f, 0.5f);
    }


    private void OxygenCheck()
    {
        oxygen = (int)oxygen_manager.oxygenInfo();
        oxygenCon = oxygen.ToString();
        oxygen_txt.GetComponent<TMPro.TextMeshProUGUI>().text = oxygenCon;
    }
}
