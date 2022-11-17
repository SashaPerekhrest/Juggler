using System;
using UnityEngine;
using System.Collections;

public class MoveSphere : MonoBehaviour
{
    public static float fallSpeed = 6f;
    public static bool shield;
    
    private float rot = 0;
    private float posX = 2f, posY, angle = 0f;
    public int direction = 0;
    private Transform chaild, trail;

    private void Start()
    {
        chaild = transform.GetChild(0);
        trail = transform.GetChild(1);
    }

    void Update()
    {
        if (!Game.pause)
        {


            if (direction == 0)
                transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
            if (direction == 1)
            {
                posY = -1.75f * posX * posX + 3f;
                transform.position = new Vector2(posX, posY);
                posX -= fallSpeed / 3f * Time.deltaTime;
            }

            if (direction == 2)
            {
                posY = -1.75f * posX * posX + 3f;
                transform.position = new Vector2(posX, posY);
                posX += fallSpeed / 3f * Time.deltaTime;
            }

            transform.rotation = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(0f, 0f, rot), Time.time);
            rot += 75f * Time.deltaTime * 4.5f;

            if (shield) chaild.gameObject.SetActive(true);
            else chaild.gameObject.SetActive(false);

            var barrier = this.GetComponent<Rigidbody>();
            Destroy(barrier);
            
            if (fallSpeed == 3f) trail.gameObject.GetComponent<TrailRenderer>().time = 0.24f;
            else trail.gameObject.GetComponent<TrailRenderer>().time = 0.17f;

            if (transform.position.y < -6)
            {
                if (!shield)
                {
                    if (Game.arcadeMod && !Game.lose)
                        Game.Lives--;
                    else
                        Game.lose = true;
                }

                Destroy(gameObject);
            }


            if (Game.arcadeMod && Game.Lives == 0) Game.lose = true;
        }
    } 
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "RightArm")
            direction = 2;
        if (other.gameObject.tag == "LeftArm")
        {
            posY = transform.position.y;
            direction = 1;
        }

        if (!Game.lose)
        {
            Game.Score++;
            if (Game.Score % 5 == 0)
                Game.Coin++;
        }

        if (Game.arcadeMod)
        {
            if(Game.Score > PlayerPrefs.GetInt("HighestArcade"))
                PlayerPrefs.SetInt("HighestArcade", Game.Score);
        }
        else if(Game.Score > PlayerPrefs.GetInt("Highest"))
            PlayerPrefs.SetInt("Highest", Game.Score);
    }
}
