using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceOccupation : MonoBehaviour
{
    private bool isOccupied;
    private Collider myCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myCollider = gameObject.GetComponent<BoxCollider>();

    }
    private void OnTriggerEnter()
    {
        //other = myCollider;
        Debug.Log("Collision");
    }
}
