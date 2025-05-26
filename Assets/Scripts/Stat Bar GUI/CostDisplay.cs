using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CostDisplay : MonoBehaviour
{
    [SerializeField] private GameObject parentObject;
    private GameObject currentObj;
    private float objectCost;
    private string objectCostCon;

    [SerializeField]private GameObject info_text;
    // Start is called before the first frame update
    void Start()
    {
        currentObj = this.gameObject;
        parentObject = currentObj.transform.parent.gameObject;
        objectCost = parentObject.GetComponent<BuildingBehavior>().buildCost;

        Debug.Log("Object Cost Info: " + objectCost);

        objectCostCon = objectCost.ToString();
        



    }

    // Update is called once per frame
    void Update()
    {
        info_text.GetComponent<TMPro.TextMeshProUGUI>().text = objectCostCon;
    }
}
