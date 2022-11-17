using System.Collections;
using System;
using UnityEngine;
using Random = System.Random;

public class SpawnSphere : MonoBehaviour
{
    public GameObject sphere;
    public GameObject heartB, clockB, shieldB;
    private int count;
    
    private void Start()
    {
        count = 0;
        var rnd = new Random();
        StartCoroutine(Spawn ());
        StartCoroutine(SpawnBonus(rnd));
    }

    IEnumerator Spawn()
    {
        for (;;)
        {  
            if (count >= 3 && !Game.arcadeMod)
                yield return new WaitForSeconds(4.7f);
            else yield return new WaitForSeconds(3f);
            if (!Game.lose)
                Instantiate(sphere, new Vector2(2f, 5.9f), Quaternion.identity);
            count++;
        }
    }

    IEnumerator SpawnBonus(Random rnd)
    { 
        for (;;)
        {
            yield return new WaitForSeconds(16f);

            var next = rnd.Next(0, 3);
            if (!Game.lose && Game.arcadeMod)
            {
                switch (next)
                {
                    case 0:
                        Instantiate(heartB, new Vector2(2f, 5.9f), Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(clockB, new Vector2(2f, 5.9f), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(shieldB, new Vector2(2f, 5.9f), Quaternion.identity);
                        break;
                }
                    
            } 
               
        }
    }
}
