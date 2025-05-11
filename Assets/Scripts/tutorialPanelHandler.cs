using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialPanelHandler : MonoBehaviour
{
    [SerializeField] private List<GameObject> tutorialPages = new List<GameObject>();
    [SerializeField] private GameObject next_btn;
    [SerializeField] private GameObject prev_btn;
    [SerializeField] private GameObject exitTutorial_btn;
    [SerializeField] private GameObject currentPage;
    [SerializeField] private GameObject nextPage;
    [SerializeField] private GameObject previousPage;
    private int pageCounter;
    private int maxPageNumber;
    private int minPageNumber;

   
    void Start()
    {
        pageCounter = 0;
        maxPageNumber = tutorialPages.Count -1;
        minPageNumber = 0;
        currentPage = tutorialPages[pageCounter];
        currentPage.SetActive(true);
    }

   
    void Update()
    {
        //Debug.Log("Page: "+ pageCounter);
    }

  

    public void advanceToPage()
    {   
        pageCounter = pageCounter + 1;

        if (pageCounter>maxPageNumber)
        {
            pageCounter = maxPageNumber;
        }
        
        Debug.Log("Page: "+ pageCounter);
        pageHandler();
     
    }
    public void returnToPage()
    {   
        pageCounter = pageCounter - 1;
        if (pageCounter < minPageNumber)
        {
            pageCounter = minPageNumber;
        }
        Debug.Log("Page: " + pageCounter);
        pageHandler();
       
    }
    public void pageHandler()
    {
        currentPage = tutorialPages[pageCounter];
        nextPage = tutorialPages[pageCounter + 1];
        previousPage = tutorialPages[pageCounter - 1];
        if (pageCounter == maxPageNumber){
            nextPage = null;
        }
        if (pageCounter==minPageNumber)
        {
            previousPage = null;
        }

        currentPage.SetActive(true);
        nextPage.SetActive(false);
        previousPage.SetActive(false);
        
    }
}
