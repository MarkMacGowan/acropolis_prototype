using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Globalization;
using System;

public class saveLoadManager : MonoBehaviour
{

    [SerializeField] GameObject mSettlement;
    [SerializeField] GameObject dNCycleObject;
    private static string path;
    private gameData game_data;
    private string myJson;
    private DateTime localDate; 
    private string fileName;

    public void Awake()
    {
        
        
        game_data = new gameData();
    }
    public void NewGame()
    {
        game_data = new gameData();
    }
    public void SaveGame()
    {   
        Debug.Log("Save Method Acessed");
        // all stats set to experiment levels
        game_data.healthLevelCurrent = mSettlement.gameObject.GetComponent<healthManager>().healthInfo();
        game_data.oxygenLevelCurrent = mSettlement.gameObject.GetComponent<oxygenManager>().oxygenInfo();
        game_data.energyLevelCurrent = mSettlement.gameObject.GetComponent<energyManager>().energyInfo();
        game_data.foodLevelCurrent = mSettlement.gameObject.GetComponent<foodManager>().foodInfo();
        game_data.waterLevelCurrent = mSettlement.gameObject.GetComponent<waterManager>().waterInfo();
        game_data.daysPassed = dNCycleObject.gameObject.GetComponent<dayNightCycle>().dayNumConvert;
        game_data.supplyLevelCurrent = ((int)mSettlement.gameObject.GetComponent<suppliesManager>().suppliesInfo());

        // x coordinate
        game_data.buildingPosition[0] = 3f;
        // y coordinate
        game_data.buildingPosition[1] = 4f;
        // z coordinate
        game_data.buildingPosition[2] = 4f;
        // index of scene set to 1
        game_data.sceneIndex = 1;
        // day status set to night time
        // to do: to get status dynamically get solarPanelmanager script and read status boolean there 
        game_data.dayStatus = false;

        // x angle
        game_data.dayNightAngle[0] =0f;
        // y angle
        game_data.dayNightAngle[1] = 180f;
        // z angle 
        game_data.dayNightAngle[2] = 0f;
        

        // instance of gameData class called game_data is added to a variable of type string called dataJson
        myJson = JsonUtility.ToJson(game_data);
        
        // date and time at present
        localDate = DateTime.Now;
        // fileName takes in localDate, turns it into a string and concatenates it with with
        // first and last strings in fileName
        fileName = "save-" +localDate.ToString("yyyy-MM-dd_HH-mm-ss") +".json";
        path = Application.persistentDataPath + "/"+fileName;
        // json file created and written using path variable and dataJson string variable
        File.WriteAllText(path, myJson);
        Debug.Log("Saving to: " + path);

    }
    public void LoadGame()
    {
        if (this.game_data == null)
        {
            NewGame();
        }
        gameData saveObject = JsonUtility.FromJson<gameData>(myJson);
        Debug.Log("Data loaded: "+saveObject);
    }
}
