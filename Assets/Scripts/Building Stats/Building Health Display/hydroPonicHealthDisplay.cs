using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hydroPonicHealthDisplay : MonoBehaviour
{


    public float maxHealthStat = 100f;
    public float health;



    [SerializeField] private hydroPonicsBehavior hydroponic_behavior;
    [SerializeField] private GameObject health_txt;


    public string healthCon;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("HealthCheck", 0.5f, 0.5f);
    }

    private void HealthCheck()
    {
        health = Mathf.Round( hydroponic_behavior.hydroponicHealth*100f)*0.01f;
        healthCon = health.ToString();
        health_txt.GetComponent<TMPro.TextMeshProUGUI>().text = healthCon+"%";

    }






}
