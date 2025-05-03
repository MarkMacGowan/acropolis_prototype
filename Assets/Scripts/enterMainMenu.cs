using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterMainMenu : MonoBehaviour
{
    public GameObject landing_menu;
    public GameObject main_menu_panel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            main_menu_panel.SetActive(true);
            landing_menu.SetActive(false);
        }
        
    }
}
