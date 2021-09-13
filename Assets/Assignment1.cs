using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
    public float x;
    public float y;
    public float x2;
    public float y2;



    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Viktor());
       Background(0);
       Viktor();
    }

    // Update is called once per frame
    void Update()
    {
        //Background(0);
        //Viktor();

    }

    IEnumerator Viktor()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        //V
        Line(2.5f, 7, 4, 3);
        Line(5.5f, 7, 4, 3);

        yield return new WaitForSecondsRealtime(0.5f);
        //I
        Line(6.5f, 7, 6.5f, 3);

        yield return new WaitForSecondsRealtime(0.5f);
        //K
        Line(8, 7, 8, 3);
        Line(8, 5, 10, 3);
        Line(10, 7, 8, 5);

        yield return new WaitForSecondsRealtime(0.5f);
        //T
        Line(12.5f, 7, 12.5f, 3);
        Line(11, 7, 14, 7);

        yield return new WaitForSecondsRealtime(0.5f);
        //O
        Stroke(255, 255, 255);
        Ellipse(x, y, x2, y2);

        yield return new WaitForSecondsRealtime(0.5f);
        //R
        Stroke(255, 255, 255);
        Circle(20, 6, 2);
        Rect(19, 7, 20, 5);
        Line(19, 7, 19, 3);
        Stroke(0, 0, 0);
        Line(20, 6.95f, 20, 5.05f);
        Stroke(255, 255, 255);
        Line(19, 5, 21, 3);
    }

}
