using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supplyAmountTest : MonoBehaviour
{
    [SerializeField] private GameObject mSettlement;
    [SerializeField] private suppliesManager sManager;

    public float currentSupply;

    public float additionValue=1;
    public float subValue=1;
    // Start is called before the first frame update
    public void Start()
    {
        //mSettlement = GameObject.FindGameObjectWithTag(mainSettle);
        sManager = mSettlement.GetComponent <suppliesManager> ();
        //mSettlement=GameObject.get
        //currentSupply = 1;
        //currentSupply = 1;
    }

    // Update is called once per frame
    void Update()
    {
      // Debug.Log("Supplies Amount Test: " + currentSupply);
       // currentSupply = sManager.SuppliesInfo();
       //Debug.Log("Supplies: " + currentSupply);

    }

    //private void GetSupplyAmount()
    //{
    //    currentSupply = AddSupply();

    //}
    public void UpdateSupply(int amount)
    {
        currentSupply += amount;
       // return currentSupply;
    }



   // private void AddSupply()
   // {
      //  //currentSupply += additionValue;
        //currentSupply++;
      //  Debug.Log("Added by: " + additionValue);
      //  //Debug.Log("Supplies: " + currentSupply);
      //  // return currentSupply;
      //  //Debug.Log($"{gameObject.name}" + "Incremented: " +currentSupply);
      //  Debug.Log($"{gameObject.name} called Increment. New value: {currentSupply}");
      //  //UpdateSupply();
   // }
   // private void SubSupply()
    //{
     //   //currentSupply -=  subValue;
      //  currentSupply--;
     //  Debug.Log("Subtracted by: " + subValue);
     //   // Debug.Log("Supplies: " + currentSupply);
     //   //return currentSupply;
      //  //Debug.Log($"{gameObject.name}" + "Decremented: " + currentSupply);
     //   Debug.Log($"{gameObject.name} called Decrement. New value: {currentSupply}");
     //   //UpdateSupply();
   // }
    

    //private void UpdateSupply()
    //{
    //    Debug.Log("Supply Updated");
    //    currentSupply = currentSupply;
    //}
    
}
