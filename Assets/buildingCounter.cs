using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingCounter : MonoBehaviour
{   
    private int numOxy;
    private int numSolar;
    private int numHydro;
    private int numWaterExt;
    private int numLanding;
    private int numTotal;


    // Start is called before the first frame update
    void Start()
    {
        numTotal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CountBuildings();
    }
    public int CountBuildings()
    {
        numOxy= GameObject.FindGameObjectsWithTag("oxyGen").Length;
        numSolar= GameObject.FindGameObjectsWithTag("solarPan").Length;
        numHydro= GameObject.FindGameObjectsWithTag("hydroPonics").Length;
        numWaterExt= GameObject.FindGameObjectsWithTag("waterExtract").Length;
        numLanding= GameObject.FindGameObjectsWithTag("landingPad").Length;
        numTotal = numOxy + numSolar + numHydro + numWaterExt + numLanding;
        if (numTotal==0)
        {
           // Debug.Log("There are no buildings");
        }
        return numTotal;
    }
}
