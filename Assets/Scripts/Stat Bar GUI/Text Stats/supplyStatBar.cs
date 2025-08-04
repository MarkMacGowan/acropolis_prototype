using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class supplyStatBar : MonoBehaviour
{
   
    public int maxSupplies;
    public float supplies;

    public GameObject main_settlement;
    public string suppliesCon;

    [SerializeField] private suppliesManager supplies_manager;
    [SerializeField] private GameObject supplies_txt;
   void Start()
    {
        supplies = supplies_manager.SuppliesInfo();
        suppliesCon = supplies.ToString();
        supplies_txt.GetComponent<TMPro.TextMeshProUGUI>().text = suppliesCon;
        InvokeRepeating("SupplyCheck",0f,0.1f);

    }

   
   
   // void Update()
  //  {   
  private void SupplyCheck()
    {
        
       
        


        supplies = (int)supplies_manager.SuppliesInfo();
        Debug.Log("Supply Check Levels: "+supplies);
        suppliesCon = supplies.ToString();
        supplies_txt.GetComponent<TMPro.TextMeshProUGUI>().text = suppliesCon;


    }
     
      
   // }
    

}
