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

    // Start is called before the first frame update
    void Start()
    {
        pageCounter = 0;
        maxPageNumber = tutorialPages.Count -1;
        minPageNumber = 0;
        currentPage = tutorialPages[pageCounter];
        currentPage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Page: "+ pageCounter);
    }

    //private GameObject findCurrentPage()
    //{
        
        
    //        currentPage = tutorialPages[pageCounter];
    //        if (pageCounter==0)
    //        {
    //            nextPage = tutorialPages[pageCounter + 1];
    //            previousPage = null;
    //        }


    //        if (pageCounter ==tutorialPages.Count-1)
    //        {
    //            nextPage = null;
    //            previousPage = tutorialPages[pageCounter - 1];
    //        }

    //        //nextPage = tutorialPages[i + 1];
    //        //previousPage = tutorialPages[i - 1];
        
    //    return currentPage;
    //}

    public void advanceToPage()
    {   
        pageCounter = pageCounter + 1;

        if (pageCounter>maxPageNumber)
        {
            pageCounter = maxPageNumber;
        }
        
        Debug.Log("Page: "+ pageCounter);
        pageHandler();
        //currentPage = tutorialPages[pageCounter];
        //nextPage = tutorialPages[pageCounter+1];
        
        //currentPage.SetActive(false);
        //currentPage = nextPage;
        //currentPage.SetActive(true);
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
        //currentPage = tutorialPages[pageCounter];
        
        //previousPage = tutorialPages[pageCounter-1];

        //currentPage.SetActive(false);
        //currentPage = previousPage;
        //currentPage.SetActive(true);
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
