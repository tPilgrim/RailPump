using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotive : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float Speed;
    public bool SpeedUp;
    private bool AlterOnce = true;
    private AudioSource Audio;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        if (GetComponent<AudioSource>() != null)
        {
            Audio = GetComponent<AudioSource>();
        }
    }

    void FixedUpdate()
    {
        Rb.velocity = new Vector2(Speed, 0f);
    }

    void Update()
    {
        if(SpeedUp)
        {
            //Debug.Log(Speed);
            Speed -= Time.deltaTime / 60;
        }
    }

    public void AlterSpeed(float SpeedDif)
    {
        if(SpeedUp == true && AlterOnce == true)
        {
            Speed -= SpeedDif;
            Speed += 2f;
            AlterOnce = false;
            //Debug.Log(SpeedDif + " " + Speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Track")
        {
            if (GetComponent<AudioSource>() != null)
            {
                Audio.Play();
            }
        }
    }
}
