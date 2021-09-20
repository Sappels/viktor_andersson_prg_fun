using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment4 : ProcessingLite.GP21
{

    Vector2 playerPos;
    Vector2 enemyPos;
    public float speed = 3;
    public float accel = 0.01f;
    public int maxSpeed = 15;
    float diameter = 1f;
    Vector2 acceleration;



    // Start is called before the first frame update
    void Start()
    {
        playerPos = new Vector2(Width / 2, Height / 1.5f);
        enemyPos = new Vector2(Width / 2, Height / 3);
    }

    // Update is called once per frame
    void Update()
    {
        Background(0);

        Circle(playerPos.x, playerPos.y, diameter);
        Circle(enemyPos.x, enemyPos.y, diameter);


        enemyPos.x += acceleration.x;
        enemyPos.y += acceleration.y;


        if (Input.GetKey(KeyCode.W))
        {
            acceleration.y += 0.1f * Time.deltaTime;
            playerPos.y += speed * Time.deltaTime;


        }else if(acceleration.y >= 0)
        {
            acceleration.y -= 0.01f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            acceleration.x -= 0.1f * Time.deltaTime;
            playerPos.x -= speed * Time.deltaTime;
         
        }
        else if (acceleration.x >= 0)
        {
            acceleration.x += 0.01f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            acceleration.y -= 0.1f * Time.deltaTime;
            playerPos.y -= speed * Time.deltaTime;

        }
        else if (acceleration.y >= 0)
        {
            acceleration.y += 0.01f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            acceleration.x += 0.1f * Time.deltaTime;
            playerPos.x += speed * Time.deltaTime;

        }
        else if (acceleration.x >= 0)
        {
            acceleration.x -= 0.01f * Time.deltaTime;
        }

    }


}
