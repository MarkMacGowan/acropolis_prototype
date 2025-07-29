using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landingPadHealthDisplay : MonoBehaviour
{
    public float maxHealthStat = 100f;
    public float health;



    [SerializeField] private landingPadBehavior landingpad_behaviour;
    [SerializeField] private GameObject health_txt;


    public string healthCon;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("HealthCheck", 0.5f, 0.5f);
    }

    private void HealthCheck()
    {
        health = landingpad_behaviour.landingPadHealth;
        healthCon = health.ToString();
        health_txt.GetComponent<TMPro.TextMeshProUGUI>().text = healthCon;

    }
}
