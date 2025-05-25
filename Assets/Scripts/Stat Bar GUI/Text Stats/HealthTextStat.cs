using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTextStat : MonoBehaviour
{
    public float maxHealth;
    public float health;

    public GameObject main_settlement;
    public string healthCon;

    [SerializeField] private healthManager health_manager;
    [SerializeField] private GameObject health_txt;
    
    void Start()
    {
        InvokeRepeating("HealthCheck",1f,0.5f);
    }

    
    private void HealthCheck()
    {
        health = (int)health_manager.healthInfo();
        healthCon = health.ToString();
        health_txt.GetComponent<TMPro.TextMeshProUGUI>().text = healthCon;
    }
}
