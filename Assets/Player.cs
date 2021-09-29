using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ProcessingLite.GP21

{
    public Vector2 playerPos;
    public float speed = 3;
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
    public void Draw()
    {
        
        Stroke(0, 0, 255);
        Circle(playerPos.x, playerPos.y, diameter);

    }

    public void PlayerPos()
    {
        playerPos.x = (playerPos.x + Width) % Width;
        playerPos.y = (playerPos.y + Height) % Height;
    }
}
