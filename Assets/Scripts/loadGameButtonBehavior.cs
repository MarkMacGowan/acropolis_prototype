using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadGameButtonBehavior : MonoBehaviour
{   
    //[SerializeField] private 
    private string fileContents;
    [SerializeField] private GameObject game_load_text;
    
    // Start is called before the first frame update
    void Start()
    {
        fileContents = (gameObject.GetInstanceID()).ToString();
        game_load_text.GetComponent<TMPro.TextMeshProUGUI>().text = fileContents;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
