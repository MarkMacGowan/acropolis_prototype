using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterTypingAnimation : MonoBehaviour
{
    [SerializeField] private GameObject welcome_text;
    public string welcome_text_Contents;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        welcome_text.GetComponent<TMPro.TextMeshProUGUI>().text =welcome_text_Contents;
    }
}
