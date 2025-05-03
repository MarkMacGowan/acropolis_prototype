using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class objectMovementBehavior : MonoBehaviour
{

    Plane plane = new Plane(Vector3.down, 0);
    public Ray ray;
    float distance;
    public Vector3 gamePosition;
    public bool uiInter;

    // variable to store a pixelated version of the gamePositon coordinates
    // eg. 0.223, 4.33, 9.81 would be 0, 4, 10
    public Vector3 roundGamePos;
    public float roundX;
    public float roundY;
    public float moveIncrem;

    // Update is called once per frame
    void Update()
    {
       // roundX = (Mathf.Round((Input.mousePosition.x)*moveIncrem)*0.1f);
      //  roundY = (Mathf.Round((Input.mousePosition.y)*moveIncrem)*0.1f);
      //  roundGamePos = new Vector3(roundX,roundY,0);

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
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
    }
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        if (EventSystem.current.IsPointerOverGameObject())
        {

            
            uiInter = true;
            Debug.Log(this.name +" UI Intersect: "+ uiInter);
            
        }
        else
        {
            uiInter = false;
            Debug.Log(this.name + " UI Intersect: " + uiInter);
        }

        return;
    }

}
