using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : ProcessingLite.GP21
{
    //Our class variables
    public Vector2 position; //Ball position
    Vector2 velocity; //Ball direction
    public float diameter = 0.3f;

    //Ball Constructor, called when we type new Ball(x, y);
    public Ball(float x, float y)
    {
        //Set our position when we create the code.
        position = new Vector2(x, y);

        //Create the velocity vector and give it a random direction.
        velocity = new Vector2();
        velocity.x = Random.Range(0, 11) - 5;
        velocity.y = Random.Range(0, 11) - 5;
    }

    //Draw our ball
    public void Draw()
    {
        Stroke(0, 255, 0);
        Circle(position.x, position.y, diameter);
    }

    //Update our ball
    public void UpdatePos()
    {
        position += velocity * Time.deltaTime;

        if (position.x > Width - diameter / 2 || position.x < 0 + diameter / 2)
        {
            velocity.x *= -1;
        }
        else if (position.y > Height - diameter / 2 || position.y < 0 + diameter / 2)
        {
            velocity.y *= -1;
        }

    }
}
