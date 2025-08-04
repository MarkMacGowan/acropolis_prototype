using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygenManager : MonoBehaviour
{
    // OXYGEN
    // oxygen level of mainDome
    public float oxygenLevel = 0;
    // maximum oxygen level of mainDome
    private float maxOxygenLevel = 100f;
    // minimum oxygen level of mainDome
    // private float minOxygenLevel = 0f;
    // rate at which oxygenLevel regenerates
    private float oxygenProduceRate;
    // rate at which oxygen is used up
    // private float oxygenUsageRate;
    // counts number of oxygen generators placed in level
    // oxygen generator produce oxygen from the thin atmosphere around it
    // during clear weather
    public int noOxyGens;
    // variable that stores each oxygen processor instance
    private GameObject oxygen_processor;
    // total oxygen gathered from each oxygen processor instance
    private float totOxygenAmount;
    public float totOxygenProduce;
    public int noOxygenGens;




    private float acropolisOxygenConsumption;
    private float oxygenConsumption;
    private float oxygenDeficit;
    private float oxygenPlusMinus;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public float oxygenInfo()
    {
        GameObject[] oxygenProcessorList = GameObject.FindGameObjectsWithTag("oxyGen");
        totOxygenProduce = 0f;

        foreach (GameObject oxygenPro in oxygenProcessorList)
        {
            if (oxygenPro!=null)
            {
                oxygenGeneratorBehavior oxBehviour = oxygenPro.GetComponent<oxygenGeneratorBehavior>();
                if (oxBehviour!=null)
                {
                    totOxygenProduce += oxBehviour.oxygenProduce;
                }
            }
        }

        // oxygen_processor = GameObject.FindWithTag("oxyGen");
        //  totOxygenAmount = oxygen_processor.GetComponent<oxygenGeneratorBehavior>().oxygenAmount;
        //totOxygenProduce = oxygen_processor.GetComponent<oxygenGeneratorBehavior>().oxygenProduce;
        // noOxyGens = GameObject.FindGameObjectsWithTag("oxyGen").Length;
        //  oxygenProduceRate = totOxygenAmount;
        //  oxygenLevel = oxygenLevel + oxygenProduceRate;
        noOxyGens = oxygenProcessorList.Length;
        oxygenDeficit = CalculateOxygenConsumption();
        oxygenPlusMinus = totOxygenProduce - oxygenDeficit;

        oxygenLevel += oxygenPlusMinus;
        oxygenLevel = Mathf.Clamp(oxygenLevel,0,maxOxygenLevel);


        //if (oxygenLevel > maxOxygenLevel)
        //{
        //    oxygenLevel = maxOxygenLevel;
        //}
        return oxygenLevel;
    }

    private float CalculateOxygenConsumption()
    {
        acropolisOxygenConsumption = 0.1f;

        oxygenConsumption = acropolisOxygenConsumption;
        return oxygenConsumption;
    }
}
