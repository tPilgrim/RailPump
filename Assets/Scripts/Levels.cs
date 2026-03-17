using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    private Vector2 NewPos;
    public GameObject Object;
    private int Rand;
    private bool HasSpawned;

    public GameObject[] Obstacle;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && HasSpawned == false)
        {
            NewPos = new Vector2(transform.position.x + 14f, transform.position.y);
            //Instantiate(Object, NewPos, transform.rotation);
            Rand = Random.Range(0, Obstacle.Length);

            switch(Rand)
            {
                case 0: Instantiate(Obstacle[0], NewPos, transform.rotation); HasSpawned = true; break;
                case 1: Instantiate(Obstacle[1], NewPos, transform.rotation); HasSpawned = true; break;
                case 2: Instantiate(Obstacle[2], NewPos, transform.rotation); HasSpawned = true; break;
                case 3: Instantiate(Obstacle[3], NewPos, transform.rotation); HasSpawned = true; break;
                case 4: Instantiate(Obstacle[4], NewPos, transform.rotation); HasSpawned = true; break;
                case 5: Instantiate(Obstacle[5], NewPos, transform.rotation); HasSpawned = true; break;
                case 6: Instantiate(Obstacle[6], NewPos, transform.rotation); HasSpawned = true; break;
                case 7: Instantiate(Obstacle[7], NewPos, transform.rotation); HasSpawned = true; break;
                case 8: Instantiate(Obstacle[8], NewPos, transform.rotation); HasSpawned = true; break;
                case 9: Instantiate(Obstacle[9], NewPos, transform.rotation); HasSpawned = true; break;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Waggon")
        {
            Destroy(gameObject);
        }
    }
}
