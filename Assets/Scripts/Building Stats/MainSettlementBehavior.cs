using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSettlementBehavior : MonoBehaviour
{
    [SerializeField] public GameObject sand_storm;
    [SerializeField] private GameObject currentBuilding;

    // health stat of main settlement 
    public float maxSettlementHealth = 100f;
    public float settlementHealth = 100f;
    public float healthDecreaseRate = 0.01f;

    // environmental concerns
    public bool isSandStorm = false;

    // particle concerns
    [SerializeField] private GameObject explosion_fx;
    public float destroyTiming; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sand_storm = GameObject.FindWithTag("sandstorm2");
        isSandStorm = sand_storm.activeInHierarchy;
        HealthDecrease(isSandStorm);
    }

    public void HealthDecrease(bool sStorm)
    {


        if (sStorm == true)
        {
            Debug.Log("Sandstorm!");
            settlementHealth -= healthDecreaseRate;
            if (settlementHealth <= 0)
            {
                Debug.Log("Health is 0");
                StartExplosion();
            }
        }
    }

    public void StartExplosion()
    {
        explosion_fx.SetActive(true);
        //   if (explosion_fx.GetComponent<explosiveShockwaveBehavior>().shockWaveDestroy.Equals(true))
        //   {
        // Debug.Log("OxyBehavior: Explosion Has Occured");
        BuildingRemove();
        //health_text.SetActive(false);
        //  }

    }
    private void BuildingRemove()
    {
        Object.Destroy(currentBuilding,destroyTiming);
        //Object.Destroy(parentBuildingObject, 3);
    }
}
