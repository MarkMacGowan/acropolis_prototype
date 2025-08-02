using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingAvailability : MonoBehaviour
{
    [SerializeField] public List<GameObject> buildingInfo = new List<GameObject>();
    [SerializeField] public int price;
    // Start is called before the first frame update
    void Start()
    {
        
        
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
}
