using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingAvailability : MonoBehaviour
{
    [SerializeField] public List<GameObject> buildingInfo = new List<GameObject>();
    [SerializeField] public int price;

    // variable stores main settlement as GameObject
    [SerializeField] private GameObject mSet;
    // variable to store supplyManager script
    [SerializeField] private suppliesManager supply_m;
    [SerializeField] private float priceButton;


    private float currentSupply;
    // Start is called before the first frame update
    void Start()
    {
        mSet= GameObject.FindWithTag("mainSettle");
        supply_m = mSet.GetComponent<suppliesManager>();
        InvokeRepeating("CheckCurrentSupply", 2f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int GetPrice(int indBuild)
    {

        price = buildingInfo[indBuild].GetComponent<oxygenGeneratorBehavior>().buildCost;
        return price;
    }

    public void CheckCurrentSupply()
    {
        currentSupply = supply_m.SuppliesInfo();
        CheckSupplyPrice(currentSupply);
    }

    private bool CheckSupplyPrice(float inSupply)
    {

    }
    private void ReadButton()
    {

    }
     
}
