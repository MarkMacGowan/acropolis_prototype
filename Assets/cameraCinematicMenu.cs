using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCinematicMenu : MonoBehaviour
{
    public Vector3 camMove;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 camMove = new Vector3(2,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(camMove*Time.deltaTime);
        if (transform.position.x>10)
        {
            transform.position= new Vector3(0,0,-0.5333334f);
        }
    }
}
