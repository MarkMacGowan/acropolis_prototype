using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;

public class loadGameButtonBehavior : MonoBehaviour
{
    private static string loadFilePath;
    private string nameOfFile;
    //[SerializeField] private 
    private string fileContents;
    private string allFiles;
    private string fileName;
    [SerializeField] private string game_load_text;
    [SerializeField] private GameObject load_Button_Label;
    
    // Start is called before the first frame update
    void Start()
    {
        ShowLoadGameFiles();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public string ShowLoadGameFiles()
    {   
        
        loadFilePath = Application.persistentDataPath + "/" + nameOfFile;
        // star before json means it is a wildcard, in other words: any file name.json
        string[] storedFiles = Directory.GetFiles(loadFilePath,"*.json");
        foreach (string file in storedFiles)
        {
            fileContents = Path.GetFileName(file);
            load_Button_Label.GetComponent<TMPro.TextMeshProUGUI> ().text = game_load_text;
        }
        return fileContents;
    }

}
