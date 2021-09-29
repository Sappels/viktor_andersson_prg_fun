using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment5 : ProcessingLite.GP21
{
    Ball bolliboll;
    Player myPlayer;

    // Start is called before the first frame update
    void Start()
    {
        bolliboll = new Ball(5, 5);
        myPlayer = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        Background(0);

        myPlayer.Draw();
        myPlayer.PlayerPos();
        myPlayer.PlayerMovement();
        bolliboll.Draw();
        bolliboll.UpdatePos();
    }
    
}





