using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RaycastPlane : MonoBehaviour
{
    // have raycast use ui as mask
    Plane plane = new Plane(Vector3.down, 0);
    Ray ray;
    float distance;
    public Vector3 gamePosition;
    public bool uiIntersect;
    
    public void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out  distance))
        {
            transform.position = ray.GetPoint(distance);
           // Debug.Log(ray.GetPoint(distance));
            getRayPos();

            OnMouseDown();
        }
    }

    public void getRayPos()
    {
       gamePosition = ray.GetPoint(distance);
     //  Debug.Log("getRayPosMethod: " + gamePosition);
    }
    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject()) { 
            
           // Debug.Log("UI Intersect");
            uiIntersect = true;
            return;
        }
        else
        {
            uiIntersect = false;
        }
        
    }
}
