using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{

    public Vector2 circlePosition;
    private float diameter = 1f;
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Background(0);


        //Få cirkeln att flyga iväg när du släpper musknappen
        if (Input.GetMouseButtonUp(0))
        {
            direction = new Vector2(MouseX - circlePosition.x, MouseY - circlePosition.y);
            Debug.Log(direction);

        }

        //Flytta cirkeln när du trycker på musknappen
        if (Input.GetMouseButtonDown(0))
        {
            circlePosition.x = MouseX;
            circlePosition.y = MouseY;

        }

        //dra linjen från cirkeln
        if (Input.GetMouseButton(0))
        {
            Line(circlePosition.x, circlePosition.y, MouseX, MouseY);
        }

        //få cirkeln att flyga 
        circlePosition += direction * Time.deltaTime;
        //Rita cirkeln
        Circle(circlePosition.x, circlePosition.y, diameter);


        //Får cirkeln att byta riktning när den träffar väggen.
        if (!Input.GetMouseButton(0))
        {
            if (circlePosition.y >= Height || circlePosition.y <= 0)
            {
                direction.y *= -1;
            }
            if (circlePosition.x >= Width || circlePosition.x <= 0)
            {
                direction.x *= -1;
            }
        }


    }
}
