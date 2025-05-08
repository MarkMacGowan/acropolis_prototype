using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Globalization;
using System;
using System.Linq;

public class saveLoadManager : MonoBehaviour
{

    [SerializeField] GameObject mSettlement;
    [SerializeField] GameObject dNCycleObject;
    [SerializeField] GameObject building_counter_object;


    // [SerializeField] GameObject inbuilding_storage;
    //private GameObject iBuilding;
    //private GameObject aBuilding;
    [SerializeField] private int totAllBuildings;

    private List<BuildingData> everyBuilding;
    private List<GameObject> all_buildings;

    private List<GameObject> oxyGenExtractors;
    private List<GameObject> solarPanels;
    private List<GameObject> hydroPonics;
    private List<GameObject> waterExtractors;
    private List<GameObject> supplyPads;


    private GameObject[] buildingArray;
   // private GameObject myBuilding;

    private static string path;

    //private gameData game_data;
    private EnvironmentData environment_Data;
    private BuildingData building_Data;
    private StatData stat_Data;

    private string myEnvironmentData;
    private string myBuildingData;
    private string myStatData;
    private string allBuildingStates;

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
        all_buildings=RetrieveAllActiveBuildings();
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
        //building_Data.buildingHealth=
        for (int i=0;i<all_buildings.Count;i++)
        {
            everyBuilding[i].buildingId = all_buildings[i].gameObject.GetInstanceID();
            
            everyBuilding[i].buildingTag = all_buildings[i].gameObject.tag;
            everyBuilding[i].buildingPosition[0] = all_buildings[i].transform.position.x;
            everyBuilding[i].buildingPosition[1] = all_buildings[i].transform.position.y;
            everyBuilding[i].buildingPosition[2] = all_buildings[i].transform.position.z;
            everyBuilding[i].buildingH = all_buildings[i].gameObject.GetComponent<BuildingBehavior>().buildingHealth;
            everyBuilding[i].buildingEn = all_buildings[i].gameObject.GetComponent<BuildingBehavior>().buildingEnergy;
            everyBuilding[i].buildingOx = all_buildings[i].gameObject.GetComponent<BuildingBehavior>().buildingOxygen;
        }
       ;
        // building position
        // x coordinate
        //building_Data.buildingPosition[0] = 3f;
        // y coordinate
       // building_Data.buildingPosition[1]= 4f;
        // z coordinate
        //building_Data.buildingPosition[2] = 4f;
        
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
        allBuildingStates = everyBuilding.ToString();
        myEnvironmentData = JsonUtility.ToJson(environment_Data);
        myBuildingData = JsonUtility.ToJson(allBuildingStates);
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
    private List<GameObject> RetrieveAllActiveBuildings()
    {   

        int oxygenArrayLength= GameObject.FindGameObjectsWithTag("oxyGen").Length;
        for (int i = 0; i < oxygenArrayLength; i++)
        {
            oxyGenExtractors[i] = GameObject.FindGameObjectsWithTag("oxyGen")[i];
        }
        
        int solarPanelArrayLength = GameObject.FindGameObjectsWithTag("solarPan").Length;
        for (int i = 0; i < solarPanelArrayLength; i++)
        {
            solarPanels[i] = GameObject.FindGameObjectsWithTag("solarPanel")[i];
        }

        int hydroPonicsArrayLength= GameObject.FindGameObjectsWithTag("hydroPonics").Length;
        for (int i = 0; i < hydroPonicsArrayLength; i++)
        {
            hydroPonics[i] = GameObject.FindGameObjectsWithTag("hydroPonics")[i];
        }

        int waterExtractArrayLength= GameObject.FindGameObjectsWithTag("waterExtract").Length;
        for (int i = 0; i < waterExtractArrayLength; i++)
        {
            waterExtractors[i] = GameObject.FindGameObjectsWithTag("waterExtract")[i];
        }

        int landingPadArrayLength= GameObject.FindGameObjectsWithTag("landingPad").Length;
        for (int i = 0; i < landingPadArrayLength; i++)
        {
            supplyPads[i] = GameObject.FindGameObjectsWithTag("landingPad")[i];
        }



        //oxyGenExtractors = GameObject.FindGameObjectsWithTag("oxyGen").toList();
        List<GameObject> allBuildings = new List<GameObject>();
        allBuildings = oxyGenExtractors.Concat(solarPanels).Concat(hydroPonics).Concat(waterExtractors).Concat(supplyPads).ToList();
        return allBuildings;
        //CombineToSaveList(oxyGenExtractors, allBuildings);
        //CombineToSaveList(solarPanels, allBuildings);
        //CombineToSaveList(hydroPonics, allBuildings);
        //CombineToSaveList(waterExtractors,allBuildings);
        //CombineToSaveList(supplyPads, allBuildings);


        //buildingArray = GameObject.FindGameObjectsWithTag("solarPan");
       // foreach (GameObject iBuilding in buildingArray)
       // {
            //solarPan aB = iBuilding.GetComponent<>();
            //building_Data
       // }
        
           //solarList[i] = GameObject.FindGameObjectsWithTag("solarPan");
        
    }

    private void CombineToSaveList(List<GameObject>buildingsList,List<BuildingData>saveList)
    {
        foreach (GameObject go in buildingsList)
        {
            
        }
    }
    private void buildingLoop()
    {
        //int i = 0;
        //foreach (var building in buildList)
            
            //i++;
            //buildList=GameObject.FindGameObjectsWithTag("solarPan")).
    }
}
