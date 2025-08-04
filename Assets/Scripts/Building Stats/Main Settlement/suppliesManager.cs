using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suppliesManager : MonoBehaviour
{
    [SerializeField] private GameObject dnObject;
    private dayNightCycle dnCycle;
    private float sunAngle;
    private float supplyDeliveryTime;
    bool dayCheck;




    private keyboardInput key_board;
    public float incomingSupplySubtract;
    public float finalSTotal;

    public float incoming_supply;
    public float supplyLevel;

    private float maxSupplyLevel = 1000;



    private float supplyDeliveryRate;
    //public int startingSupply = 100;




    public int noLandingPads;

    private GameObject land_pad;

    private float totSuppliesAmount;
    private float totSuppliesDelivery;

    public float supplyPlusMinus;
    private float finalSupplyLevel;

    
    public float sMinus=0;
    float fSupply=0;
    float maxFSupply=1000;








    private void Start()
    {
       // fSupply = 200f;
    }
    private void Update()
    {
        
        //Debug.Log("Supply Minus: " + sMinus);


        SuppliesInfo();
       // Debug.Log("Supplies Manager Update Function");
       //Debug.Log("Supplies: "+fSupply);


        SumLandingPad();
        //SuppliesInfo();


        Debug.Log("Supply Level: "+fSupply);
        //SuppliesInfo();
    }
    public float SuppliesInfo()
    {

        fSupply = supplyLevel;
        fSupply = Mathf.Clamp(fSupply,0,maxFSupply);
        return fSupply;
    }
    //method to gather incoming supply levels from all landing pads
    public void SumLandingPad()
    {
        
        land_pad = GameObject.FindWithTag("landingPad");

        totSuppliesDelivery = land_pad.GetComponent<landingPadBehavior>().suppliesProduce;
        noLandingPads = GameObject.FindGameObjectsWithTag("landingPad").Length;
        
        totSuppliesAmount = land_pad.GetComponent<landingPadBehavior>().SupplyDeliver();

        SupplyAddition(totSuppliesAmount);
   


    }
    //  method to check if building placed

    public void SupplyAddition(float amount)
    {
        supplyLevel += amount;
    }
    public void SupplySpend(float amount)
    {
       
           supplyLevel -= amount;
        
        Debug.Log("Supply Spend: "+amount);
    }









}
