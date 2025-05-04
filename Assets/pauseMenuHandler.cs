using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuHandler : MonoBehaviour
{
    [SerializeField] private GameObject pause_menu;
    [SerializeField] private GameObject game_hud;
    [SerializeField] private GameObject save_menu;
    [SerializeField] private GameObject load_menu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                    pauseMenuAppear();
                   
            }
       
    }
    public void pauseMenuAppear(){
        pause_menu.SetActive(true);
        game_hud.SetActive(false);
        save_menu.SetActive(false);
        load_menu.SetActive(false);
        Time.timeScale = 0;
    }
    public void pauseMenuDisappear()
    {
        pause_menu.SetActive(false);
        game_hud.SetActive(true);
        Time.timeScale = 1;
    }
}
