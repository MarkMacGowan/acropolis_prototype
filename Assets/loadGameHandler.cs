using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadGameHandler : MonoBehaviour
{
    [SerializeField] private GameObject load_button;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(load_button);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
