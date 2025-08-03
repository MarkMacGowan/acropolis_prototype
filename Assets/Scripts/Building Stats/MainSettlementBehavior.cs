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
    public float healthRegenRate =0.1f;

 

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
        //sand_storm = GameObject.FindWithTag("sandstorm2");
        bool isSandStorm = sand_storm.activeInHierarchy;
        HealthCalculate(isSandStorm);
        //HealthRegen(isSandStorm);
    }

    public void HealthCalculate(bool sStorm)
    {


        if (sStorm)
        {
            Debug.Log("Sandstorm!");
            settlementHealth -= healthDecreaseRate;
            if (settlementHealth <= 0)
            {
                Debug.Log("Health is 0");
                StartExplosion();
            }
        }else  

        {
            Debug.Log("Clear Skies");
            if (settlementHealth<maxSettlementHealth)
            {
                settlementHealth += healthRegenRate;
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

    //private void HealthRegen(bool sStorm)
    //{
    //    //Debug.Log("HealthRegen");
    //    if (sStorm == false)
    //    {
    //        Debug.Log("No Storm");
    //        Debug.Log("Sandstorm ended!");
            
            
       
    //    }
    //}
}
