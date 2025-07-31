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





    //public static suppliesManager Instance;
    //public int currentSupply = 1000;

    private void Awake()
    {
        //fSupply = 200f;
        //startingSupply = 100;
        //SupplyPlus();
        //SupplyDeficit();
    }
    private void Start()
    {
       // fSupply = 200f;
    }
    private void Update()
    {
        
        //Debug.Log("Supply Minus: " + sMinus);


        SuppliesInfo();
       // Debug.Log("Supplies Manager Update Function");
       Debug.Log("Supplies: "+fSupply);


        SumLandingPad();
        SuppliesInfo();


        
        //SuppliesInfo();
    }
    public float SuppliesInfo()
    {
        //if (SupplyDeficit().GetType()==)
        //{

        //}
        //fSupply = SupplyFinal();
        //fSupply = startingSupply;
        //supplyPlusMinus = 0;
        // supplyPlusMinus = SupplyPlus() - SupplyDeficit();


        //Debug.Log("Starting Supply: "+fSupply);
        // Debug.Log("SupplyPlus: " + SupplyPlus());
        // Debug.Log("SupplyDeficit: " + SupplyDeficit());

        // Debug.Log("PlusMinus: "+supplyPlusMinus);
        //  Debug.Log("fSupply: " + fSupply);



        // fSupply = fSupply+supplyPlusMinus;
        //if (fSupply>0)
        //{
        //   // Debug.Log("fSupply bigger than 0");
        //    fSupply +=supplyLevel;
        //    if (fSupply < 0)
        //       {
        //          fSupply = 0;
        //       }
        //    if (fSupply > maxFSupply)
        //       {
        //          fSupply = maxFSupply;
        //       }

        //}
        fSupply = supplyLevel;
     
        return fSupply;
    }
    //method to gather incoming supply levels from all landing pads
    public void SumLandingPad()
    {
        
        land_pad = GameObject.FindWithTag("landingPad");

        totSuppliesDelivery = land_pad.GetComponent<landingPadBehavior>().suppliesProduce;
        noLandingPads = GameObject.FindGameObjectsWithTag("landingPad").Length;
        
        totSuppliesAmount = land_pad.GetComponent<landingPadBehavior>().SupplyDeliver();
        //supplyLevel = startingSupply;
        

       // if (totSuppliesAmount>0)
      // {
            //Debug.Log("Incoming Delivery Supply Level Above 0");
            //SupplyAdjustment(totSuppliesAmount);
        SupplyAddition(totSuppliesAmount);
       // }
        //if (totSuppliesAmount == 0)
        //{
        //    SupplyAddition(totSuppliesAmount);
        //}

        //if (supplyLevel>0)
        //{
            
        //}


    }
    //  method to check if building placed

    public void SupplyAddition(float amount)
    {
        supplyLevel += amount;
    }
    public void SupplySpend(float amount)
    {
        //Debug.Log("Not Enough Supplies");
        //if (supplyLevel >= amount)
        //{
           supplyLevel -= amount;
        //}
       
    }
    public void SupplyAdjustment(float amount)
    {
     // supply Addition

        //supplyLevel = supplyLevel + totSuppliesAmount;

        //if (supplyLevel > maxSupplyLevel)
        //{
        //    supplyLevel = maxSupplyLevel;
        //}
        //if (supplyLevel < 0)
        //{
        //    supplyLevel = 0;
        //}
        
        
     //supply subtraction






        //return supplyLevel;
    }
   // private float SupplyPlus()
   // {
        //Debug.Log("Supplies Start: " + supplyLevel);
     //   land_pad = GameObject.FindWithTag("landingPad");

    //    totSuppliesDelivery = land_pad.GetComponent<landingPadBehavior>().suppliesProduce;
      //  noLandingPads = GameObject.FindGameObjectsWithTag("landingPad").Length;


     //   totSuppliesAmount = land_pad.GetComponent<landingPadBehavior>().SupplyDeliver();


        // Debug.Log("TotSupplies Delivery: "+totSuppliesDelivery);
        // Debug.Log("TotSuppliesAmount: " + totSuppliesAmount);

        //supplyLevel += supplyLevel + 1;


        //Debug.Log("SupplyLevel: " + supplyLevel);
        //Debug.Log("SupplyPLus: " + supplyPlusMinus);


        //Debug.Log("Total: " + supplyLevel);
       // supplyLevel = startingSupply;
      //  supplyLevel = supplyLevel + totSuppliesAmount;




      //  if (supplyLevel > maxSupplyLevel)
       // {
       //     supplyLevel = maxSupplyLevel;
       // }
       // if (supplyLevel < 0)
       // {
       //     supplyLevel = 0;
       // }


       // return supplyLevel;






    //}

    //private float SupplyDeficit()
    //{
        
    //    return sMinus;
    //}
    //public float SupplyDeficit(float supplyMinus)
    //{
    //    sMinus = supplyMinus;
    //    return sMinus;
    //}

    //private float SupplyDeficit()
    //{
    //    sMinus = 0;
    //    return sMinus;
    //}
    //private float SupplyFinal()
    //{
    //    finalSupplyLevel = SupplyPlus() + sMinus;
    //    return finalSupplyLevel;
    //}
    //private float CheckTimeDay()
    //{
    //    dnObject = GameObject.FindGameObjectWithTag("dayNight");
    //    dnCycle = dnObject.GetComponent<dayNightCycle>();
    //    sunAngle = dnObject.transform.rotation.eulerAngles.z;
    //   //supplyDeliveryTime
    //    return supplyDeliveryTime;
    //}
}
