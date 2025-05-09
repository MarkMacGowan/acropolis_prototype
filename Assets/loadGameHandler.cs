using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadGameHandler : MonoBehaviour
{
    [SerializeField] private GameObject parentOfButton;
    [SerializeField] private GameObject load_button;
    private void OnEnable()
    {
        Instantiate(load_button,parentOfButton.transform);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
