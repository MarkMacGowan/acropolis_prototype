using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatsMonitor : MonoBehaviour
{
    [SerializeField] private GameObject heads_up_display;
    [SerializeField] private GameObject game_info_panel;
    [SerializeField] private GameObject game_over_object;
    [SerializeField] private GameOverPanelStorage game_overStorage;
    private GameObject specificPanel;

    [SerializeField] private foodManager food_manager;
    [SerializeField] private waterManager water_manager;
    [SerializeField] private oxygenManager oxygen_manager;
    [SerializeField] private energyManager energy_manager;

    [SerializeField] private Scene game_over_screen;
    [SerializeField] private sceneLoader scene_loader;


    public float foodLevel;
    public float waterLevel;
    public float oxygenLevel;
    public float energyLevel;

    //private string statName;

    // Start is called before the first frame update
    void Start()
    {
        food_manager = GetComponent<foodManager>();
        water_manager = GetComponent<waterManager>();
        oxygen_manager = GetComponent<oxygenManager>();
        energy_manager = GetComponent<energyManager>();

        game_info_panel = GameObject.FindGameObjectWithTag("gameplayInfoPopUp");
        game_overStorage = game_over_object.GetComponent<GameOverPanelStorage>();
      
    }

    // Update is called once per frame
    void Update()
    {

        if (food_manager == null)
            Debug.LogError("food_manager is null!");
        if (water_manager == null)
            Debug.LogError("water_manager is null!");
        if (oxygen_manager == null)
            Debug.LogError("oxygen_manager is null!");
        if (energy_manager == null)
            Debug.LogError("energy_manager is null!");

        try
        {
            try
            {
                foodLevel = food_manager.foodInfo();
            }
            catch (System.Exception e)
            {
                Debug.LogError("foodInfo() failed: " + e.Message);
            }

            try
            {
                waterLevel = water_manager.waterInfo();
            }
            catch (System.Exception e)
            {
                Debug.LogError("waterInfo() failed: " + e.Message);
            }

            try
            {
                oxygenLevel = oxygen_manager.oxygenInfo();
            }
            catch (System.Exception e)
            {
                Debug.LogError("oxygenInfo() failed: " + e.Message);
            }

            try
            {
                energyLevel = energy_manager.energyInfo();
            }
            catch (System.Exception e)
            {
                Debug.LogError("energyInfo() failed: " + e.Message);
            }
           // Debug.Log("Hello World");
            CheckLevels();
        }
        catch(System.Exception e)
        {
            Debug.LogError("Update Failed: " + e.Message);
        }
   
    }

    private void CheckLevels()
    {
      //  Debug.Log("Levels Checked");
        // check food levels
        if (foodLevel==0)
        {
            // Debug.Log("Water levels are 0");
            //  specificPanel = game_overStorage.panelList[0];
            //GameOver(specificPanel,heads_up_display,game_info_panel);
            GameOver();
        }
        if (waterLevel == 0)
        {
            // Debug.Log("Water levels are 0");
            // specificPanel = game_overStorage.panelList[0];
            // GameOver(specificPanel, heads_up_display, game_info_panel);
            GameOver();
        }
        if (oxygenLevel == 0)
        {
            // Debug.Log("Water levels are 0");
            // specificPanel = game_overStorage.panelList[0];
            // GameOver(specificPanel, heads_up_display, game_info_panel);
            GameOver();
        }

    }
    private void GameOver()
    {
        SceneManager.LoadScene(2);
       // hDisplay.SetActive(false);
        //chosenPanel.SetActive(true);
        //Time.timeScale = (Time.timeScale == 0f) ? 1f : 0f;
       // Debug.Log("Time Scale: " + Time.timeScale);
        //if (game_info_panel.activeInHierarchy)
        //{
        //    game_info_panel.SetActive(false);
            
        //}
    }
}
