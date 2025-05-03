using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentManager : MonoBehaviour
{
    private MonoBehaviour refScript;
    // Start is called before the first frame update
    void Start()
    {
        refScript = GetComponent<RaycastPlane>();
    }

    // Update is called once per frame
    public void componentEnable()
    {
        refScript.enabled = false;
    }
}
