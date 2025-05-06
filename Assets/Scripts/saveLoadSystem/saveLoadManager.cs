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
    [SerializeField] GameObject building_counter_object;
    [SerializeField] GameObject inbuilding_storage;
    [SerializeField] private int totAllBuildings;
    private static string path;

    //private gameData game_data;
    private EnvironmentData environment_Data;
    private BuildingData building_Data;
    private StatData stat_Data;

    private string myEnvironmentData;
    private string myBuildingData;
    private string myStatData;

    //private string myJson;
    private DateTime localDate; 
    private string fileName;
    // the number of all buildings placed in the scene
    
    public void Awake()
    {
        environment_Data = new EnvironmentData();
        building_Data = new BuildingData();
        stat_Data = new StatData();
       
        //game_data = new gameData();
        totAllBuildings = 0;
    }
    public void NewGame()
    {
        environment_Data = new EnvironmentData();
        building_Data = new BuildingData();
        stat_Data = new StatData();
        //game_data = new gameData();
    }
    public void SaveGame()
    {   
        Debug.Log("Save Method Acessed");
        // all stats 
        //stat_Data.healthLevelCurrent = mSettlement.gameObject.GetComponent<healthManager>().healthInfo();
        stat_Data.oxygenLevelCurrent = mSettlement.gameObject.GetComponent<oxygenManager>().oxygenInfo();
        stat_Data.energyLevelCurrent = mSettlement.gameObject.GetComponent<energyManager>().energyInfo();
        stat_Data.foodLevelCurrent = mSettlement.gameObject.GetComponent<foodManager>().foodInfo();
        stat_Data.waterLevelCurrent = mSettlement.gameObject.GetComponent<waterManager>().waterInfo();
        stat_Data.supplyLevelCurrent = ((int)mSettlement.gameObject.GetComponent<suppliesManager>().suppliesInfo());
        
        // all environment information
        environment_Data.daysPassed = dNCycleObject.gameObject.GetComponent<dayNightCycle>().dayNumConvert;
        
        
        //building object


        // building position
        // x coordinate
        building_Data.buildingPosition[0] = 3f;
        // y coordinate
        building_Data.buildingPosition[1]= 4f;
        // z coordinate
        building_Data.buildingPosition[2] = 4f;
        
        // index of scene set to 1
        environment_Data.sceneIndex = 1;

        // day status set to night time
        // to do: to get status dynamically get solarPanelmanager script and read status boolean there 
        environment_Data.dayStatus = dNCycleObject.gameObject.GetComponent<dayNightCycle>().TimeOfDay();

        // x angle
        environment_Data.dayNightAngle[0] = 0f;
        // y angle
        environment_Data.dayNightAngle[1] = 180f;
        // z angle 
        environment_Data.dayNightAngle[2] = dNCycleObject.gameObject.GetComponent<dayNightCycle>().rotationalNumZ;
        
        totAllBuildings = building_counter_object.gameObject.GetComponent<buildingCounter>().CountBuildings();
        //for (int i=0;i<totAllBuildings-1;i++)
        //{
        //    game_data.currentBuildings[i] =inbuilding_storage.GetComponent<buildingStorage>().buildingsStored[i];
        //}
        // game_data.currentBuildings[0]
        // instance of gameData class called game_data is added to a variable of type string called dataJson

        myEnvironmentData = JsonUtility.ToJson(environment_Data);
        myBuildingData = JsonUtility.ToJson(building_Data);
        myStatData = JsonUtility.ToJson(stat_Data);
        //myJson = JsonUtility.ToJson(game_data);
        
        // date and time at present
        localDate = DateTime.Now;
        // fileName takes in localDate, turns it into a string and concatenates it with with
        // first and last strings in fileName
        fileName = "save-" +localDate.ToString("yyyy-MM-dd_HH-mm-ss") +".json";
        path = Application.persistentDataPath + "/"+fileName;
        // json file created and written using path variable and dataJson string variable
        File.WriteAllText(path, myEnvironmentData+myBuildingData+myStatData);
        Debug.Log("Saving to: " + path);

    }
    public void LoadGame()
    {
        if (this.environment_Data == null&&this.building_Data==null&&this.stat_Data==null)
        {
            NewGame();
        }
        //gameData saveObject = JsonUtility.FromJson<gameData>(myJson);
        //Debug.Log("Data loaded: "+saveObject);
    }
}
