using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsMonitor : MonoBehaviour
{
    [SerializeField] private GameObject heads_up_display;
    [SerializeField] private GameObject game_over_object;
    [SerializeField] private GameOverPanelStorage game_overStorage;
    private GameObject specificPanel;

    [SerializeField] private foodManager food_manager;
    [SerializeField] private waterManager water_manager;
    [SerializeField] private oxygenManager oxygen_manager;
    [SerializeField] private energyManager energy_manager;


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

        game_overStorage = game_over_object.GetComponent<GameOverPanelStorage>();
      
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World");
        foodLevel = food_manager.foodInfo();
        waterLevel = water_manager.waterInfo();
        oxygenLevel = oxygen_manager.oxygenInfo();
        energyLevel = energy_manager.energyInfo();
        CheckLevels();
    }

    private void CheckLevels()
    {
        Debug.Log("Levels Checked");
        // check food levels
        if (foodLevel==0)
        {
            Debug.Log("Water levels are 0");
            specificPanel = game_overStorage.panelList[0];
            GameOver(specificPanel,heads_up_display);
        }


    }
    private void GameOver(GameObject chosenPanel,GameObject hDisplay)
    {
        hDisplay.SetActive(false);
        chosenPanel.SetActive(true);
    }
}
