using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveLoadManager : MonoBehaviour
{
    private gameData game_data;

    public void NewGame()
    {
        game_data = new gameData();
    }
    public void SaveGame()
    {   
        // all stats set to experiment levels
        game_data.healthLevelCurrent = 100f;
        game_data.oxygenLevelCurrent = 100f;
        game_data.energyLevelCurrent = 100f;
        game_data.foodLevelCurrent = 100f;
        game_data.waterLevelCurrent = 100f;
        game_data.daysPassed = 3;
        game_data.supplyLevelCurrent = 50;

        // x coordinate
        game_data.buildingPosition[0] = 3f;
        // y coordinate
        game_data.buildingPosition[1] = 4f;
        // z coordinate
        game_data.buildingPosition[2] = 4f;
        // index of scene set to 1
        game_data.sceneIndex = 1;
        // day status set to night time
        game_data.dayStatus = false;

        // x angle
        game_data.dayNightAngle[0] =0f;
        // y angle
        game_data.dayNightAngle[1] = 180f;
        // z angle 
        game_data.dayNightAngle[2] = 0f;
        
        // instance of gameData class called game_data is written to a json file
        string json = JsonUtility.ToJson(game_data);
    }
    public void LoadGame()
    {
        if (this.game_data == null)
        {
            NewGame();
        }

    }
}
