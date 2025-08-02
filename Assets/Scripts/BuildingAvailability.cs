using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingAvailability : MonoBehaviour
{
    [SerializeField] public List<GameObject> buttonList = new List<GameObject>();
    [SerializeField] public List<GameObject> buildingInfo = new List<GameObject>();
    [SerializeField] public int price;

    // variable stores main settlement as GameObject
    [SerializeField] private GameObject mSet;
    // variable to store supplyManager script
    [SerializeField] private suppliesManager supply_m;
    [SerializeField] private float priceButton;
    [SerializeField] private Button button_component;
    private float iPriceButton;
    private bool canAfford;

    private float currentSupply;
    //private boolean isInteractive;
    
     
    // Start is called before the first frame update
    void Start()
    {
        mSet= GameObject.FindWithTag("mainSettle");
        supply_m = mSet.GetComponent<suppliesManager>();

        //InvokeRepeating("CheckCurrentSupply", 2f, 1f);
        //InvokeRepeating("CompareSupplyPrice", 0f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        CompareSupplyPrice();
    }
    public int GetPrice(int indBuild)
    {

        price = buildingInfo[indBuild].GetComponent<oxygenGeneratorBehavior>().buildCost;
        return price;
    }

    public float CheckCurrentSupply()
    {
        currentSupply = supply_m.SuppliesInfo();
        //CompareSupplyPrice(currentSupply);
        return currentSupply;
        
    }


    private float ReadButton(int i)
    {

        priceButton = buttonList[i].GetComponent < ButtonInfo > ().buttonCost;
        return priceButton;
    }
    private bool CompareSupplyPrice()
    {
        // call method to check supply levels
        float cSupply = CheckCurrentSupply();

        // cycle through each button and retrieve price 
        // compare price to current supply levels
        //Debug.Log("buttonListSize: "+buttonList.Count);
        for (int counter=0; counter < buttonList.Count; counter++)
        {
           button_component = buttonList[counter].GetComponent<Button>();
            // get price of current button/ building
           iPriceButton= ReadButton(counter); 
           Debug.Log("Counter: "+counter);
            // compare the price against current supply levels

            // if the supplyLevel is more than or equal to building cost
           if (  cSupply >=iPriceButton)
            {
                //Debug.Log(buttonList[counter].name + " Cost: " + iPriceButton + " SupplyLvl: " + cSupply + ": Available");
                button_component.interactable.Equals(true);
                canAfford= true;
            }
           else if (cSupply<iPriceButton  )
            {
               // Debug.Log(buttonList[counter].name + " Cost: " + iPriceButton + " SupplyLvl: " + cSupply + ": Unavailable");
                button_component.interactable.Equals(false);
                canAfford= false;
            }
            else
            {
                canAfford = false;
                button_component.interactable.Equals(false);
            }
            
        }
        
        return canAfford;
        
    }
}
