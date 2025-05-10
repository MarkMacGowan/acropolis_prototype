using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Globalization;
using System;
using System.Linq;

public class saveLoadManager : MonoBehaviour
{
    
    [SerializeField] private GameObject mSettlement;
    [SerializeField] private GameObject bSpawner;
    [SerializeField] GameObject dNCycleObject;
    [SerializeField] GameObject building_counter_object;
    [SerializeField] buildingManager myBuildingManager;
    //private GameObject chosenBuilding;

    // [SerializeField] GameObject inbuilding_storage;
    //private GameObject iBuilding;
    //private GameObject aBuilding;
    [SerializeField] private int totAllBuildings;
    // list of type BuildingData
    
    // List of type GameObject which hold all buildings instansiated 
    //private List<GameObject> all_buildings;

      
    //private List<GameObject> oxyGenExtractors;

    

  
    private static string path;
    private static string newPath;

    //private gameData game_data;
    private EnvironmentData environment_Data;
    private BuildingData building_Data;
    private StatData stat_Data;
    private AllData all_data;

    private string allBuildingStates;
    private string myEnvironmentData;
    private string myBuildingData;
    private string myStatData;
    private string myAllData;
    GameSaveData gameData;
    private string allData;

    private string myCombinedData;
    //private string allBuildingStates;

    //private string myJson;
    private DateTime localDate; 
    private string fileName;
    // the number of all buildings placed in the scene
    private List<GameObject> all_buildings;
    public void Awake()
    {
        environment_Data = new EnvironmentData();
        building_Data = new BuildingData();
        stat_Data = new StatData();
        gameData = new GameSaveData();
        mSettlement = GameObject.FindGameObjectWithTag("mainSettle");
        bSpawner = GameObject.FindGameObjectWithTag("buildSpawn");
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
        all_buildings =RetrieveAllActiveBuildings();
        // all stats 
        //stat_Data.healthLevelCurrent = mSettlement.gameObject.GetComponent<healthManager>().healthInfo();
        stat_Data.oxygenLevelCurrent = mSettlement.gameObject.GetComponent<oxygenManager>().oxygenInfo();
        stat_Data.energyLevelCurrent = mSettlement.gameObject.GetComponent<energyManager>().energyInfo();
        stat_Data.foodLevelCurrent = mSettlement.gameObject.GetComponent<foodManager>().foodInfo();
        stat_Data.waterLevelCurrent = mSettlement.gameObject.GetComponent<waterManager>().waterInfo();
        stat_Data.supplyLevelCurrent = ((int)mSettlement.gameObject.GetComponent<suppliesManager>().suppliesInfo());
        
        // all environment information
        environment_Data.daysPassed = dNCycleObject.gameObject.GetComponent<dayNightCycle>().dayNumConvert;
        Debug.Log("All Buildings List Length: "+all_buildings.Count);
        List<BuildingData> everyBuilding=new List<BuildingData>();
        Debug.Log("EveryBuilding Length: "+everyBuilding.Count);
        //building object
        //building_Data.buildingHealth=
        int count = Mathf.Min(everyBuilding.Count, all_buildings.Count);
        for (int i=0;i<all_buildings.Count; i++)
        {
            
            GameObject gObject = all_buildings[i];
            BuildingBehavior b = gObject.GetComponent<BuildingBehavior>();
            if (b == null) continue;
            BuildingData myData = new BuildingData
            {

                buildingId = gObject.GetInstanceID(),
                buildingTag = gObject.tag,
                buildingPosition = new float[]
                {
                    gObject.transform.position.x,
                    gObject.transform.position.y,
                    gObject.transform.position.z
                },
                bHealth=b.buildingHealth,
                bEnergy=b.buildingEnergy,
                bOxygen=b.buildingOxygen
            
            };
            everyBuilding.Add(myData);
            //Debug.Log("Index: " + i);
            //Debug.Log("Instance ID: " + all_buildings[i].GetInstanceID());
            //Debug.Log("Buildings Count: "+all_buildings.Count);
            //int tempID;
            //tempID= all_buildings[i].GetInstanceID();
            //Debug.Log("TempID: " + tempID);
            //everyBuilding[i].buildingId = all_buildings[i].GetInstanceID();
            
            //everyBuilding[i].buildingTag = all_buildings[i].gameObject.tag;
            //everyBuilding[i].buildingPosition[0] = all_buildings[i].transform.position.x;
            //everyBuilding[i].buildingPosition[1] = all_buildings[i].transform.position.y;
            //everyBuilding[i].buildingPosition[2] = all_buildings[i].transform.position.z;
            //everyBuilding[i].buildingH = all_buildings[i].gameObject.GetComponent<BuildingBehavior>().buildingHealth;
            //everyBuilding[i].buildingEn = all_buildings[i].gameObject.GetComponent<BuildingBehavior>().buildingEnergy;
            //everyBuilding[i].buildingOx = all_buildings[i].gameObject.GetComponent<BuildingBehavior>().buildingOxygen;
        }
        Debug.Log("EveryBuilding List Size: "+everyBuilding.Count);
       
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
        BuildingSaveData buildingSaveData = new BuildingSaveData();
        buildingSaveData.allBuildings = everyBuilding;

        
        gameData.environment = environment_Data;
        gameData.sData = stat_Data;
        //gameData.building = building_Data;
        gameData.buildingStates = buildingSaveData;
        
        

        allData = JsonUtility.ToJson(gameData, true);
        //allBuildingStates = JsonUtility.ToJson(saveData,true);
        //myEnvironmentData = JsonUtility.ToJson(environment_Data,true);
        //myBuildingData = JsonUtility.ToJson(allBuildingStates,true);
        //myStatData = JsonUtility.ToJson(stat_Data,true);
        //myJson = JsonUtility.ToJson(game_data);
        //gameData.environment=
        // date and time at present
        localDate = DateTime.Now;
        // fileName takes in localDate, turns it into a string and concatenates it with with
        // first and last strings in fileName
        fileName = "save-" +localDate.ToString("yyyy-MM-dd_HH-mm-ss") +".json";
        path = Application.persistentDataPath + "/"+fileName;
        // json file created and written using path variable and dataJson string variable
        myCombinedData = myEnvironmentData + myBuildingData + myStatData + allBuildingStates;
        File.WriteAllText(path, allData);
        Debug.Log("Saving to: " + path);
        
    }
    public void LoadGame()
    {

        AllData all_data =new AllData();

        // stores int value of index of latest item
        int indexOfLatestFile;


        string myFileName;


        string myFile;


        string latestFileDate;


        path = Application.persistentDataPath + "/" + fileName;


        List<string> saveFileNames = new List<string>();


        string[] files = Directory.GetFiles(path, "*.json");


        List<string> saveFile = new List<string>();


        List<DateTime> fileDates = new List<DateTime>();



        DateTime fileCreationTime;




        //float angleSun;

        foreach (string file in files)
        {
            Debug.Log("Save Files: "+Path.GetFileName(file));
            fileCreationTime = File.GetCreationTime(file).AddSeconds(1);
            fileDates.Add(fileCreationTime);
            myFileName=Path.GetFileName(file);
            saveFileNames.Add(myFileName);
        }



        latestFileDate = fileDates.Max().ToString();


        indexOfLatestFile = fileDates.IndexOf(fileDates.Max());

        
        myFile =saveFileNames[indexOfLatestFile];
        Debug.Log("Latest File: "+latestFileDate);
        Debug.Log("Latest File Name: "+ myFile);


        newPath = Application.persistentDataPath + "/" + myFile;
        string retrievedData = System.IO.File.ReadAllText(newPath);
        //string myGameData;
        gameData = JsonUtility.FromJson<GameSaveData>(retrievedData);


        // load environment data
        

        int lSceneIndex = gameData.environment.sceneIndex;
        bool lDayStatus = gameData.environment.dayStatus;
        float[] lDayNightAngle =new float[3];
                lDayNightAngle[0]=gameData.environment.dayNightAngle[0];
                lDayNightAngle[1] = gameData.environment.dayNightAngle[1];
                lDayNightAngle[2] = gameData.environment.dayNightAngle[2];
        int lDaysPassed = gameData.environment.daysPassed;
        //GameObject lWeather = gameData.environment.weather;

        // load stats data
        float lHealthLevel = gameData.sData.healthLevelCurrent;
        float lOxygenLevel = gameData.sData.oxygenLevelCurrent;
        float lEnergyLevel = gameData.sData.energyLevelCurrent;
        float lFoodLevel = gameData.sData.foodLevelCurrent;
        float lWaterLevel = gameData.sData.waterLevelCurrent;
        float lSupplyLevel = gameData.sData.energyLevelCurrent;

        // load building data

        //List<GameObject> myIBuildingObject = new List<GameObject>();
        List<BuildingData> everyBuilding = new List<BuildingData>();
        int allBuildingsLength= gameData.buildingStates.allBuildings.Count;
        for (int i = 0; i < allBuildingsLength; i++)
        {       
            
            int lBuildingID = gameData.buildingStates.allBuildings[i].buildingId;
            string lBuildingTag = gameData.buildingStates.allBuildings[i].buildingTag;
            float[] lBuildingPosition = new float[3];

            lBuildingPosition[0] = gameData.buildingStates.allBuildings[i].buildingPosition[0];
            lBuildingPosition[1] = gameData.buildingStates.allBuildings[i].buildingPosition[1];
            lBuildingPosition[2] = gameData.buildingStates.allBuildings[i].buildingPosition[2];
            Vector3 mylBuildingPositon = new Vector3(lBuildingPosition[0],lBuildingPosition[1],lBuildingPosition[2]);
            Quaternion lBuildingAngles = new Quaternion(0,0,0,0);
            float lBHealth = gameData.buildingStates.allBuildings[i].bHealth;
            float lBEnergy = gameData.buildingStates.allBuildings[i].bEnergy;
            float lBOxygen = gameData.buildingStates.allBuildings[i].bOxygen;

            GameObject lBuildingObject = gameData.buildingStates.allBuildings[i].buildingObject;
            //BuildingBehavior b = lBuildingObject.GetComponent<BuildingBehavior>();
            //if (b == null) continue;
            BuildingData lData = new BuildingData
            {
                buildingObject = lBuildingObject,
                buildingId = lBuildingID,
                buildingTag = lBuildingTag,
                buildingPosition = new float[]
                {
                    lBuildingPosition[0],
                    lBuildingPosition[1],
                    lBuildingPosition[2]

                    //lBuildingObject[0]=lBuildingPosition[0];
                    //lBuildingObject.transform.position.y=lBuildingPosition[1],
                    //lBuildingObject.transform.position.z=lBuildingPosition[2],
                },
                bHealth=lBHealth,
                bEnergy=lBEnergy,
                bOxygen=lBHealth
            };
            everyBuilding.Add(lData);

           // myIBuildingObject.AddRange()
        }


        // set game data to load data
        //environment
        dayNightCycle dnScript= dNCycleObject.gameObject.GetComponent<dayNightCycle>();

        dnScript.dayTime = lDayStatus;
        dnScript.rotationalNumZ = lDayNightAngle[2];
        dnScript.dayNumConvert = lDaysPassed;
        


        environment_Data.sceneIndex = lSceneIndex;
        environment_Data.dayStatus = lDayStatus;
        environment_Data.dayNightAngle = lDayNightAngle;
        environment_Data.daysPassed = lDaysPassed;
        //environment_Data.weather = lWeather;

        // stats
        healthManager hManager= mSettlement.gameObject.GetComponent<healthManager>();
        oxygenManager oxManager = mSettlement.gameObject.GetComponent<oxygenManager>();
        energyManager enManager = mSettlement.gameObject.GetComponent<energyManager>();
        foodManager   fManager= mSettlement.gameObject.GetComponent<foodManager>();
        waterManager wManager= mSettlement.gameObject.GetComponent<waterManager>();
        suppliesManager sManager= mSettlement.gameObject.GetComponent<suppliesManager>();

        hManager.healthLevel = lHealthLevel;
        oxManager.oxygenLevel = lOxygenLevel;
        enManager.energyLevel = lEnergyLevel;
        fManager.foodLevel = lFoodLevel;
        wManager.waterLevel = lWaterLevel;
        sManager.supplyLevel = lSupplyLevel;
        //stat_Data.healthLevelCurrent = lHealthLevel;

        //stat_Data.energyLevelCurrent = mSettlement.gameObject.GetComponent<energyManager>().energyInfo();
        //stat_Data.foodLevelCurrent = mSettlement.gameObject.GetComponent<foodManager>().foodInfo();
        //stat_Data.waterLevelCurrent = mSettlement.gameObject.GetComponent<waterManager>().waterInfo();
        //stat_Data.supplyLevelCurrent = ((int)mSettlement.gameObject.GetComponent<suppliesManager>().suppliesInfo());

        // buildings (instansiate)

        Debug.Log("Length of everyBuildingList: "+everyBuilding.Count);
        int buildingsListLength = bSpawner.GetComponent<buildingManager>().buildingsListSize;
        for (int i=0;i< everyBuilding.Count; i++) {
            float xPosition = everyBuilding[i].buildingPosition[0];
            float yPositon = everyBuilding[i].buildingPosition[1];
            float zPosition = everyBuilding[i].buildingPosition[2];
            Vector3 loadedObjectPosition = new Vector3(xPosition,yPositon,zPosition);
            GameObject chosenBuilding=new GameObject();
            string bTag= everyBuilding[i].buildingTag;
            Debug.Log("bTag: " + bTag);
            Debug.Log("Building Tag: " + bSpawner.gameObject.GetComponent<buildingManager>().buildings[i].tag);
            
            for (int j = 0; j < buildingsListLength; j++)
            {   
                string cTag = bSpawner.GetComponent<buildingManager>().buildings[j].tag;
                if (bTag.Equals(cTag))
                {
                
                    chosenBuilding = bSpawner.GetComponent<buildingManager>().buildings[j];
                }
            }
          
            
            GameObject buildingToInstansiate = chosenBuilding;
            Debug.Log("Building to Instansiate: " + buildingToInstansiate);
            buildingToInstansiate.GetComponent<objectMovementBehavior>().enabled = false;
            Instantiate(buildingToInstansiate,loadedObjectPosition, Quaternion.identity);
            

        }



















        //GameObject lBuilding = new GameObject();
        //for (int i = 0; i < allBuildingsLength; i++)
        //{
        //    BuildingData lBuildingData = new BuildingData()
        //    {






        //    };
        //    //lBuildingObject
        //    //all_Buildings[i]=


        //}





        Debug.Log(gameData.buildingStates.allBuildings[1].buildingTag);
        //foreach (string line in gameData)
        //{
        //    Debug.Log(myAllData);
        //}
        //angleSun=myAllData.iDayNightAngle[3];
        // Debug.Log("Angle Of Sun: "+angleSun);
        //myEnvironmentData = JsonUtility.FromJson<EnvironmentData>(myFile.);


        //if (this.environment_Data == null&&this.building_Data==null&&this.stat_Data==null)
        //{
        //    NewGame();
        //}
        //gameData saveObject = JsonUtility.FromJson<gameData>(myJson);
        //Debug.Log("Data loaded: "+saveObject);
    }
    private List<GameObject> RetrieveAllActiveBuildings()
    {
        Debug.Log("Retrieve Buildings Accessed");
       
        GameObject[] oxygenArray = GameObject.FindGameObjectsWithTag("oxyGen");
        //int oxygenArrayLength= GameObject.FindGameObjectsWithTag("oxyGen").Length;
        List <GameObject>oxyGenExtractors= GameObject.FindGameObjectsWithTag("oxyGen").ToList();
        Debug.Log("All Oxygen Objects added to List");
        //int solarPanelArrayLength = GameObject.FindGameObjectsWithTag("solarPan").Length;
        GameObject[] solarPanelArray= GameObject.FindGameObjectsWithTag("solarPan");
        
        List<GameObject> solarPanels = GameObject.FindGameObjectsWithTag("solarPan").ToList();
        Debug.Log("All Solar arrays added to List");

        GameObject[] hydroArray = GameObject.FindGameObjectsWithTag("hydroPonics");
        List<GameObject> hydroPonics= GameObject.FindGameObjectsWithTag("hydroPonics").ToList();
        Debug.Log("All HydroPonicsArrays added to List");
        GameObject[] waterArray = GameObject.FindGameObjectsWithTag("waterExtract");
        List<GameObject> waterExtractors = GameObject.FindGameObjectsWithTag("waterExtract").ToList();
        Debug.Log("All Water ExtractorsArrays added to List");
        GameObject[] supplyArray = GameObject.FindGameObjectsWithTag("landingPad");
        List <GameObject> supplyPads= GameObject.FindGameObjectsWithTag("landingPad").ToList();
        Debug.Log("All Supply pad Arrays added to List");

        //GameObject[] buildingArray;
        // private GameObject myBuilding;


        //int hydroPonicsArrayLength= GameObject.FindGameObjectsWithTag("hydroPonics").Length;




        // int waterExtractArrayLength= GameObject.FindGameObjectsWithTag("waterExtract").Length;




        //int landingPadArrayLength= GameObject.FindGameObjectsWithTag("landingPad").Length;

        //supplyPads.AddRange(GameObject.FindGameObjectsWithTag("landingPad"));




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
    private void SetToSaveValues()
    {   
        //environment_Data.sceneIndex=lSce
        //mSettlement.gameObject.GetComponent<oxygenManager>().oxygenLevel=;
        
        mSettlement.gameObject.GetComponent<energyManager>().energyInfo();
        mSettlement.gameObject.GetComponent<foodManager>().foodInfo();
        mSettlement.gameObject.GetComponent<waterManager>().waterInfo();
        //(int)mSettlement.gameObject.GetComponent<suppliesManager>().suppliesInfo();
    }
}
