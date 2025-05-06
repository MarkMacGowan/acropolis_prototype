using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingStorage : MonoBehaviour
{
    [SerializeField] GameObject building_spawner;
    public List<GameObject> buildingsStored;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < buildingsStored.Count; i++)
        {
            buildingsStored[i] = building_spawner.GetComponent<buildingManager>().currentBuilding;
        }
    }
    //public List<GameObject> BuildingRetrieve(int x)
    //{
        
    //    return buildingsStored[x];
    //}
}
