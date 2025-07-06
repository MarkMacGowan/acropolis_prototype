using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overcastHandler : MonoBehaviour
{
    //[SerializeField] private GameObject cloud_object;
    [SerializeField] private GameObject sunObject;
    [SerializeField] private GameObject overcast_object;
    //private float currentInstensity;
    //private float currentShadowStength;

    private float normalInstensity=1f;
    private float normalShadowStength=1f;

    void Start()
    {   
        //currentInstensity = sunObject.GetComponent<Light>().shadowStrength;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (overcast_object.activeInHierarchy)
        {
            sunObject.GetComponent<Light>().intensity = 0.5f;
            sunObject.GetComponent<Light>().shadowStrength =0.5f;
        }
        else
        {
            sunObject.GetComponent<Light>().intensity = normalInstensity;
            sunObject.GetComponent<Light>().shadowStrength = normalShadowStength;
        }
    }
}
