using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracksPoints : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float Speed;
    public GameObject Check;
    private AudioSource Audio;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        if (GetComponent<AudioSource>() != null)
        {
            Audio = GetComponent<AudioSource>();
        }
    }

    void Update()
    {
        if(Check.activeSelf == false && Speed > 0)
        {
            if(Speed > 2f)
            {
                Speed = 2f;
            }
            Speed -= Time.deltaTime;
        }

        if (GetComponent<AudioSource>() != null && Check.activeSelf == false)
        {
            Audio.volume -= Time.deltaTime / 2;
        }

        if (Speed < 0.1 && Speed > -0.1)
        {
            Speed = 0;
        }
        else
        {
            Speed += Time.deltaTime / 60;
        }

        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obst in obstacles)
        {
            if (obst.GetComponent<Locomotive>() != null)
            {
                obst.GetComponent<Locomotive>().AlterSpeed(Speed);
            }
        }
    }

    void FixedUpdate()
    {
        Rb.velocity = new Vector2(Speed, 0f);
    }
}
