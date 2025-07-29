using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterExtractorHealthDisplay : MonoBehaviour
{
    public float maxHealthStat = 100f;
    public float health;



    [SerializeField] private waterExtractorBehavior waterextractor_behavior;
    [SerializeField] private GameObject health_txt;


    public string healthCon;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("HealthCheck", 0.5f, 0.5f);
    }

    private void HealthCheck()
    {
        health = waterextractor_behavior.waterExtractorHealth;
        healthCon = health.ToString();
        health_txt.GetComponent<TMPro.TextMeshProUGUI>().text = healthCon;

    }
}
