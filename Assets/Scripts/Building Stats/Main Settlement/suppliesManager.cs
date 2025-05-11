using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suppliesManager : MonoBehaviour
{

    //[SerializeField] public int suppliesSpent;


    //private float suppliesDeficit;


    //public float supplies_deficit;
    // [SerializeField] private GameObject dnCycleObject;
    // private dayNightCycle d_cycle; 
    private keyboardInput key_board;
    public float incomingSupplySubtract;
    public float finalSTotal;
    // public float final_supply;
    public float incoming_supply;
    public float supplyLevel;

    private float maxSupplyLevel = 1000;

    // private float minSupplyLevel = 0f;

    private float supplyDeliveryRate;

    //  private float supplyUsageRate;



    public int noLandingPads;

    private GameObject land_pad;

    private float totSuppliesAmount;
    private float totSuppliesDelivery;

    public float supplyPlusMinus;

    // private float finalSupplyTotal;
    public static suppliesManager Instance;
    public int currentSupply = 1000;
    //private void Awake()
    //{
    //    if (Instance == null) Instance = this;
    //    else Destroy(gameObject);


    //}
    //public bool SpendSupply(int amount)
    //{
    //    if (currentSupply>=amount)
    //    {
    //        currentSupply -= amount;
    //        return true;
    //    }
    //    return false;
    //}

    //public void AddSupply(int amount)
    //{
    //    currentSupply += amount;
    //}
    // Start is called before the first frame update
    // void Start()
    // {
    //dnCycleObject = GameObject.FindGameObjectWithTag("dayNight");

    //incomingSupplySubtract = 0f;
    //supplyLevel = 500f;
    // supplies_deficit = incomingSupplySubtract;

    // }

    // Update is called once per frame
    //  void Update()
    // {
    //Debug.Log("Subtract Amount: " + incomingSupplySubtract);
    //d_cycle = dnCycleObject.GetComponent<dayNightCycle>();
    //}
    private void Update()
    {

        
    }
    public float suppliesInfo()
    {
        //supplyLevel = 0;
        //incomingSupplySubtract=0f;
        //supplyPlusMinus = 0f
        land_pad = GameObject.FindWithTag("landingPad");
        
        totSuppliesDelivery = land_pad.GetComponent<landingPadBehavior>().suppliesProduce;
        noLandingPads = GameObject.FindGameObjectsWithTag("landingPad").Length;
        //supplyDeliveryRate = totSuppliesAmount;
        //supplyLevel = supplyLevel + supplyDeliveryRate;
        //supplyLevel =supplyLevel+1;
        //supplies_deficit = CalculateSuppliesDeficit();
        //supplyPlusMinus = totSuppliesDelivery - supplies_deficit;
        //supplyLevel = supplyLevel + supplyPlusMinus;

        //incomingSupplySubtract = key_board.bCost;
        
        //Debug.Log("Angle Z: "+ dnCycleObject.transform.rotation.eulerAngles.z);
        // int rotZ;
        // if (dnCycleObject.transform.rotation.eulerAngles.z==315)
        // {
        //    supplyLevel = supplyLevel + (totSuppliesAmount*noLandingPads);
        //    Debug.Log("Delivery is Here!");
        //}

        totSuppliesAmount = land_pad.GetComponent<landingPadBehavior>().suppliesAmount;

        //incomingSupplySubtract = 0;
       // supplyPlusMinus = totSuppliesAmount - incomingSupplySubtract;



        supplyLevel += supplyLevel + totSuppliesAmount;
        // return supplyLevel;

        Debug.Log("SupplyLevel: " + supplyLevel);
        Debug.Log("SupplyPLus: " + supplyPlusMinus);

        //finalSupplyTotal = supplyLevel+(supplyPlusMinus);
        Debug.Log("Total: " + supplyLevel);





        if (supplyLevel > maxSupplyLevel)
        {
            supplyLevel = maxSupplyLevel;
        }
        if (supplyLevel < 0)
        {
            supplyLevel = 0;
        }
        // supplyLevel-
        //finalSupplyTotal = supplyLevel + (supplyPlusMinus);
        //if (finalSupplyTotal>maxSupplyLevel)
        //{
        //    finalSupplyTotal = maxSupplyLevel;
        //}
        //if (finalSupplyTotal < 0)
        //{
        //    finalSupplyTotal = 0;
        //}
        //finalSupplyTotal = CalculateSuppliesDeficit(totSuppliesDelivery,incomingSupplySubtract);
        // supplyPlusMinus = CalculateSuppliesDeficit(supplyLevel,incomingSupplySubtract);
        //finalSupplyTotal = finalSupplyTotal + (supplyPlusMinus);
        // supplies_deficit = CalculateSuppliesDeficit();

        return supplyLevel;
    }
   // public float CalculateSupplyDeficit()
   // {

        //Debug.Log("Calculate Method Called");
        //float finalSTotal;
        //supplyPlusMinus = supplyDeliveryRate - inSupplyDef;
       // return incomingSupplySubtract;
        //}
        // private float CalculateSuppliesDeficit()
        // {

        // Debug.Log("in Supply: "+inputSupply);
        // Debug.Log("Supply Minus: "+supplyMinus);
        // float newSupTotal;
        // float supplyDef;
        // Debug.Log("");
        // newSupTotal=inputSupply-supplyMinus;
        //Debug.Log("Supplies Spent: " + suppliesSpent);
        //incomingSupplySubtract = suppliesSpent;
        //Debug.Log("Supplies Subtract: "+incomingSupplySubtract);
        //suppliesDeficit =suppliesSpent;
        // suppliesDeficit=
        //suppliesDeficit = incomingSupplySubtract;
        //return suppliesDeficit;
        //return supplyDef;
        // }
    //}
}
