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
    private LayerMask lMask;
   
    void Awake()
    {
        lMask = LayerMask.GetMask("building");
       
    }
    void Start()
    {
      
        boxSize = new Vector3(1f,0.24f,1f);
        keyboard_input = gameObject.GetComponent<keyboardInput>();
        
        
    }

 
    void Update()
    {
       
        Collider[] hits = Physics.OverlapBox(transform.position,boxSize/2,transform.rotation,lMask);
        objectInterSect = false;
        foreach (Collider hit in hits)
        {   
            if (hit.gameObject==gameObject) continue;

            if (hit.gameObject!=this.gameObject)
            {
               Debug.Log("Intersecting with: " + hit.name);
                objectInterSect = true;
                
            }
          
                

            
            
            
        }
    
    }
    private void OnTriggerEnter(Collider other)
    {
       
        Debug.Log("Collision");
    }
}
