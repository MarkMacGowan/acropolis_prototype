using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHover : MonoBehaviour
{
    [SerializeField] private GameObject highlightGraphic;

    private void OnMouseEnter()
    {
        highlightGraphic.SetActive(true);
    }
    private void OnMouseExit()
    {
        highlightGraphic.SetActive(false);
    }
}
