using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : ProcessingLite.GP21
{


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

        Stroke(0, 0, 0);
        StrokeWeight(0.5f);

        for(int i = 0; i < 10; i++)
        {

            if (i % 3 == 0) 
            {
                Stroke(0, 0, 0);
            }
            else
            {
                Stroke(128, 128, 128);
            }


            Line(0, 10 - i, i, 0);

        }

    }

    //public float Clamp(float min, float max, float value)
    //{
        //if (value < min)
        //{
            //value = min;
        //}
        //else if (value > max)
        //{
            //value = max;
        //}
        //return value;
    //}

    //Denna if sats clampar v�rdet av value. Det finns bara tv� m�jliga values "egentligen",
    //Skulle value bli l�gre en min s� kommer den h�ja v�rdet till ett min value
    //Skulle value bli h�gre �n max s� kommer den s�nka till ett max value

    //Exempel: min == 1, max == 4
    // om value == -1, s� blir value 1
    // om value == 5+, s� blir value 4
    // annars om value == 2 eller 3, s� stannar v�rdet.

}
