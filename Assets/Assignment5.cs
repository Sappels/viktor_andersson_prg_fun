using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment5 : ProcessingLite.GP21
{
    Ball bolliboll;
    Ball[] balls;
    Player myPlayer;
    int numberOfBalls = 10;



    // Start is called before the first frame update
    void Start()
    {
        bolliboll = new Ball (5, 5);
        balls = new Ball[numberOfBalls];
        myPlayer = new Player();

        for (int i = 0; i < balls.Length; i++)
        {
            balls[i] = new Ball(5, 5);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Background(0);

        myPlayer.Draw(balls);
        myPlayer.PlayerPos();
        myPlayer.PlayerMovement();
        bolliboll.Draw();
        bolliboll.UpdatePos();

        for (int i = 0; i < balls.Length; i++)
        {
            balls[i].UpdatePos();
            balls[i].Draw();
        }

        
    }



    
}





