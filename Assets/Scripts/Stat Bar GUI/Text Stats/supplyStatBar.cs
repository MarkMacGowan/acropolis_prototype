using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class supplyStatBar : MonoBehaviour
{
   
    public int maxSupplies;
    public int supplies;

    public GameObject main_settlement;
    public string suppliesCon;

    [SerializeField] private suppliesManager supplies_manager;
    [SerializeField] private GameObject supplies_txt;
   void Start()
    {
        InvokeRepeating("SupplyCheck",2f,0.5f);

    }

   
   
   // void Update()
  //  {   
  private void SupplyCheck()
    {
        supplies = (int)supplies_manager.SuppliesInfo();
        suppliesCon = supplies.ToString();
        supplies_txt.GetComponent<TMPro.TextMeshProUGUI>().text = suppliesCon;


    }
     
      
   // }
    

}
