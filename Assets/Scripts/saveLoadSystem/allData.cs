using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AllData 
{
    
   
        public List <EnData> AllEnvironment;
        public List<LvlData> allLevels;
        public List<BuildData> allBuildings;
    
    
    [System.Serializable]
    public class EnData{
        // environment
        public int iSceneIndex;

        public bool iDayStatus;
        public float[] iDayNightAngle;
        public int iDaysPassed;
       
    }
    [System.Serializable]
    public class LvlData{
        // levels
        // the health level of the main settlement
        public float iHealthLevelCurrent;

        // how much oxygen there is 
        public float iOxygenLevelCurrent;

        // how much energy there is 
        public float iEnergyLevelCurrent;

        // how much food there is
        public float iFoodLevelCurrent;

        // how much water there is
        public float iWaterLevelCurrent;

        // how much supplies there are
        public int iSupplyLevelCurrent;
    }

    [System.Serializable]
    public class BuildData{
        // buildings
        public GameObject iBuildingObject;
        public int iBuildingId;
        public string iBuildingTag;
        public float[] iBuildingPosition;
        public float iBHealth;
        public float iBEnergy;
        public float iBOxygen;
    }
}
