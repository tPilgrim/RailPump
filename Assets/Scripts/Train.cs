using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    private Rigidbody2D Rb;

    public float Speed;
    public float Swerve;
    private int Pos = 1;

    public Transform[] Tracks;

    public GameObject Check;
    private bool CanChange;

    private AudioSource Audio;
    public AudioClip Swoosh;

    public GameObject Menu;
    public GameObject GameOver;
    public AudioReverbFilter Reverb;
    public AudioSource Music;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
        Rb.velocity = new Vector2(Speed, 0f);
        Audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Menu.activeSelf)
        {
            if(Music.volume != 0)
            {
                Music.volume = 0.4f;
            }
            Reverb.enabled = true;
        }
        else
        {
            if (Music.volume != 0)
            {
                Music.volume = 0.8f;
            }
            Reverb.enabled = false;
        }

        if(Input.GetKey(KeyCode.Space) && GameOver.activeSelf == false)
        {
            Menu.SetActive(true);
            Time.timeScale = 0f;
        }

        if (Check.activeSelf == false)
        {
            Speed = 0;
            Swerve = 0;
        }
        else
        {
            Speed += Time.deltaTime / 60;
        }
    }

    void FixedUpdate()
    {
        
        if (CanChange == true && Check.activeSelf == true)
        {
            if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && Pos > 0)
            {
                Audio.PlayOneShot(Swoosh);
                Pos--;
                CanChange = false;
                if (transform.position.y < Tracks[Pos].position.y)
                {
                    Rb.velocity = new Vector2(Speed, Swerve);
                }
            }
            else if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && Pos < 2)
            {
                Audio.PlayOneShot(Swoosh);
                Pos++;
                CanChange = false;
                if (transform.position.y > Tracks[Pos].position.y)
                {
                    Rb.velocity = new Vector2(Speed, -Swerve);
                }
            }
        }

        if(transform.position.y > Tracks[Pos].position.y - 0.05f && transform.position.y < Tracks[Pos].position.y + 0.05f)
        {
            //transform.position = new Vector2(transform.position.x, Tracks[Pos].position.y);
            Rb.velocity = new Vector2(Speed, 0f);
            CanChange = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Check.SetActive(false);
            GameOver.SetActive(true);
        }
    }
}
