using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class supplyStatBar : MonoBehaviour
{
    //public Slider supplySlider;
    public int maxSupplies;
    public int supplies;

    public GameObject main_settlement;
    public string suppliesCon;

    [SerializeField] private suppliesManager supplies_manager;
    [SerializeField] private GameObject supplies_txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    // Update is called once per frame
    void Update()
    {   
        supplies = (int)supplies_manager.suppliesInfo();
        suppliesCon = supplies.ToString();
        supplies_txt.GetComponent<TMPro.TextMeshProUGUI>().text = suppliesCon;
        Debug.Log("Supplies: "+ suppliesCon);

        //if (supplySlider.value!=supplies)
        //{
        //    supplySlider.value = supplies;
        //}
    }
}
