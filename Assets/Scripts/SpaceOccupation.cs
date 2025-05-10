using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceOccupation : MonoBehaviour
{
    [SerializeField] keyboardInput keyboard_input;
    private bool isOccupied;
    private Collider myCollider;
    private Vector3 boxSize;
    public bool objectInterSect;
    // Start is called before the first frame update

    void Awake()
    {
        //keyboard_input.enabled = true;
    }
    void Start()
    {
        //boxSize = gameObject.transform.GetChild(0).GetComponent<BoxCollider>().size.normalized;
        boxSize = new Vector3(1f,0.24f,1f);
        keyboard_input = gameObject.GetComponent<keyboardInput>();
        //keyboard_input.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        //myCollider = gameObject.GetComponent<BoxCollider>();
        Collider[] hits = Physics.OverlapBox(transform.position,boxSize/2,transform.rotation);
        objectInterSect = false;
        foreach (Collider hit in hits)
        {   
            if (hit.gameObject==gameObject) continue;

            if (hit.gameObject!=this.gameObject)
            {
               // Debug.Log("Intersecting with: " + hit.name);
                objectInterSect = true;
                //keyboard_input.enabled = false;
            }
          
                

            
            
            
        }
    
    }
    private void OnTriggerEnter(Collider other)
    {
        //other = myCollider;
        Debug.Log("Collision");
    }
}
