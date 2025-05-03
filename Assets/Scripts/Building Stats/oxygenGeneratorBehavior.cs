using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygenGeneratorBehavior : MonoBehaviour
{   
    public float maxOxygenGenHealth=100f;
    public float oxygenGenHealth = 100f;

    public float maxOxygenAmount=100f;
    public float oxygenAmount;

    // the amount of oxygen produced in a given time
    public float oxygenProduce = 0.2f;
    // the maximum amount of oxygen that can produced
    // by a generator in a given time 
    public float maxOxygenProduce = 1f;
    


    public int noOxygenGens;

    // Start is called before the first frame update
    void Start()
    {
        oxygenAmount=0f;
    }

    // Update is called once per frame
    void Update()
    {
        oxygenAmount = oxygenAmount + oxygenProduce;

        if (oxygenProduce > maxOxygenProduce)
        {
            oxygenProduce = maxOxygenProduce;
        }


        if (oxygenAmount> maxOxygenAmount)
        {
            oxygenAmount = maxOxygenAmount;
        }
    }
}
