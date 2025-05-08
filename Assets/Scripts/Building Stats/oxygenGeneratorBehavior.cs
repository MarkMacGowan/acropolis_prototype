using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygenGeneratorBehavior : BuildingBehavior
{   
    [SerializeField]public GameObject main_dome;
    private float mainDomeEnergy;
    public float maxOxygenGenHealth=100f;
    public float oxygenGenHealth = 100f;

    public float maxOxygenAmount=100f;
    public float oxygenAmount;

    // the amount of oxygen produced in a given time
    public float oxygenProduce = 0.2f;
    // the maximum amount of oxygen that can produced
    // by a generator in a given time 
    public float maxOxygenProduce = 1f;
    //variable that takes in energy of main 
    public bool isMainDomeEnergy = true;
    


    //public int noOxygenGens;

    // Start is called before the first frame update
    void Start()
    {
        main_dome = GameObject.FindGameObjectWithTag("mainSettle");
        
        oxygenAmount=0f;
    }

    // Update is called once per frame
    void Update()
    {
        mainDomeEnergy = main_dome.gameObject.GetComponent<energyManager>().energyLevel;
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
    private void continueProcess()
    {
        //if (mainDomeEnergy <= 0)
        //{
            
        //}
    }
}
