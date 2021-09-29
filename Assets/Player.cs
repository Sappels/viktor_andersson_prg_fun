using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ProcessingLite.GP21

{
    public Vector2 playerPos;
    public float speed = 6;
    public float diameter = 1f;

    public Player()
    {
        playerPos = new Vector2(Width / 2, Height / 2);
    }

    public void PlayerMovement()
    {

        if (Input.GetKey(KeyCode.W))
        {   
            playerPos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerPos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerPos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerPos.x += speed * Time.deltaTime;
        }

    }


    // Update is called once per frame
    public void Draw(Ball[] balls)
    {
        
        Stroke(0, 0, 255);
        Circle(playerPos.x, playerPos.y, diameter);

        for (int i = 0; i < balls.Length; i++)
        {
            CircleCollision(playerPos.x, playerPos.y, diameter, balls[i].position.x, balls[i].position.y, balls[i].diameter);

        }

    }

    public void PlayerPos()
    {
        playerPos.x = (playerPos.x + Width) % Width;
        playerPos.y = (playerPos.y + Height) % Height;
    }
    //Check collision, 2 circles
    //x1, y1 is the position of the first circle
    //size1 is the radius of the first circle
    //then the same data for circle number two

    //function will return true (collision) or false (no collision)
    //bool is the return type

    bool CircleCollision(float x1, float y1, float size1, float x2, float y2, float size2)
    {
        float maxDistance = size1 / 2 + size2 / 2;

        //first a quick check to see if we are too far away in x or y direction
        //if we are far away we don't collide so just return false and be done.
        if (Mathf.Abs(x1 - x2) > maxDistance || Mathf.Abs(y1 - y2) > maxDistance)
        {
            return false;
        }
        //we then run the slower distance calculation
        //Distance uses Pythagoras to get exact distance, if we still are to far away we are not colliding.
        else if (Vector2.Distance(new Vector2(x1, y1), new Vector2(x2, y2)) > maxDistance)
        {
            return false;
        }
        //We now know the points are closer then the distance so we are colliding!
        else
        {
            Debug.Log("Yo");
            return true;
        }
    }
    //A better way to do this is to have a circle object and pass the objects in to the function,
    //then we just have to pass 2 objects instead of 6 different values.
}

