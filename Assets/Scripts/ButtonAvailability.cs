using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAvailability : MonoBehaviour
{
    // main settlement
    [SerializeField] private GameObject main_settle;
    [SerializeField] private suppliesManager supply_manager;
    [SerializeField] private ButtonInfo button_info;
    [SerializeField] private Button button_component;
    [SerializeField] private GameObject test_supply;
    [SerializeField] private SupplyControlExp supply_ex;


    public float currentSupply;
    public int bPrice;
    public bool isAvailable;
    

    // Start is called before the first frame update
    void Start()
    {
        supply_ex = test_supply.GetComponent<SupplyControlExp>();
        supply_manager = main_settle.GetComponent<suppliesManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSupply = supply_manager.SuppliesInfo();
        //currentSupply = supply_ex.supply;
        bPrice = button_info.buttonCost;

        if (currentSupply>=bPrice)
        {
            button_component.interactable=true;
            isAvailable = true;
        }
        else if (currentSupply<bPrice)
        {
            button_component.interactable = false;
            isAvailable = false;
        }
    }
}
