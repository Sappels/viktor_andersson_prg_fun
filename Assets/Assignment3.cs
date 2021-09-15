using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{

    public Vector2 circlePosition;
    public float diameter = 0.2f;
    public float direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Background(0);

        if(Input.GetMouseButtonDown(0))
        {
            circlePosition.x = MouseX;
            circlePosition.y = MouseY;
        }
        if (Input.GetMouseButton(0))
        {
            Line(circlePosition.x, circlePosition.y, MouseX, MouseY);
        }

            Circle(circlePosition.x, circlePosition.y, diameter);

        Vector2 direction = new Vector2(circlePosition.x - MouseX, circlePosition.y - MouseY);

        Debug.Log(direction);
    }


    //void Circle()
    //{
    //    Background(0);
    //    Circle(CirclePositionX, CirclePositionY, diameter);
    //}



}
