using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infoHover : MonoBehaviour
{
    [SerializeField] private Button currentButton;
    [SerializeField] private GameObject currentPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }   
    // for when cursor is over button
    public void overButton()
    {
        currentPanel.SetActive(true);
    }
    public void exitOverButton()
    {
        currentPanel.SetActive(false);
    }
}
