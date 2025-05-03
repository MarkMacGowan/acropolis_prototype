using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHover : MonoBehaviour
{
    [SerializeField] private GameObject highlightGraphic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        highlightGraphic.SetActive(true);
    }
    private void OnMouseExit()
    {
        highlightGraphic.SetActive(false);
    }
}
