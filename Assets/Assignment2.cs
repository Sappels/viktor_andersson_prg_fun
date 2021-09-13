using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : ProcessingLite.GP21
{

    float spaceBetweenLines = 0.5f;
    //int Lines = 10;


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //Clear background
        Background(50, 166, 240);

        //Draw our art, or in this case a rectangle
        Rect(1, 1, 3, 3);

        Stroke(0, 0, 0);
        StrokeWeight(0.5f);
        // pCurves();

        for(int i = 0; i < 10; i++)
        {
            Line(0, 10 - i, i, 0);
        }

    }

    

   //public void pCurves()
   //{
   //    for (int i = 0; i < Lines / spaceBetweenLines; i++)
   //    {
   //        //Increase y-cord each time loop run
   //        float y = i * spaceBetweenLines;
   //        float x = i * spaceBetweenLines;
   //
   //        //Draw a line from left side of screen to the right
   //        //this time modify the height depending on time passed
   //        Line(0, (y + Time.time) % Height, Width - x , (y + Time.time) % Height);
   //        
   //    }
   //}
}
