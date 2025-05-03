using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectTransparency : MonoBehaviour
{
    private Material material;
    private float materialRed;
    private float materialGreen;
    private float materialBlue;
    private float materialAlpha;
    public float transparencyStrength;
    
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().materials[0];
        
        materialRed = material.color.r;
        materialGreen = material.color.g;
        materialBlue = material.color.b;
        materialAlpha = material.color.a;
        transparencyStrength = materialAlpha / 10;
    }

    // Update is called once per frame
    void Update()
    {
        material.color=new Color(materialRed,materialGreen,materialBlue,transparencyStrength);
    }
}
