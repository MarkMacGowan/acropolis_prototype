using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CostDisplay : MonoBehaviour
{
    [SerializeField] private GameObject parentObject;
    [SerializeField] private GameObject build_list;
    [SerializeField] private BuildingAvailability build_avail;

    private string buttonName;
    private int bIndex;
    private int buildCost;

    private string textBody;

    //private GameObject currentObj;
    //private float objectCost;
    //private string objectCostCon;

    [SerializeField]private GameObject info_text;
    // Start is called before the first frame update
    void Start()
    {
        buttonName = parentObject.name;
        build_avail = build_list.GetComponent<BuildingAvailability>();
        
        //currentObj = this.gameObject;
        //parentObject = currentObj.transform.parent.gameObject;
        //objectCost = parentObject.GetComponent<BuildingBehavior>().buildCost;

        //Debug.Log("Object Cost Info: " + objectCost);

        //objectCostCon = objectCost.ToString();
        
        
        Debug.Log("Building: "+buttonName +" Cost: "+buildCost);
        info_text.GetComponent<TMPro.TextMeshProUGUI>().text= info_text.GetComponent<TMPro.TextMeshProUGUI>().text+= buildCost.ToString(); 
        //textBody.text = textBody += buildCost.ToString();
        //textBody = info_text.GetComponent<TMPro.TextMeshProUGUI>().text;

        textBody = textBody += buildCost.ToString();
        
    }

    // Update is called once per frame
    void Update()
    { 
        bIndex = parentObject.GetComponent<ButtonInfo>().buttonIndex;
       buildCost = build_avail.GetPrice(bIndex);
       //info_text.GetComponent<TMPro.TextMeshProUGUI>().SetText("Cost:"+objectCostCon);
    
    }
}
