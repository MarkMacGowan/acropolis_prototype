using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelHandler : MonoBehaviour
{
    public GameObject Panel;

    public void openPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
    public void closePanel()
    {
        if (Panel = null)
        {
            Panel.SetActive(false);
        }
    }

}
