using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waggon : MonoBehaviour
{
    private Animator Anim;

    private Rigidbody2D Rb;
    public float Speed;

    public float Swerve;
    public Transform[] Track;
    private int Pos = 1;

    public float Delay;
    public GameObject Check;

    void Start()
    {
        Anim = GetComponent<Animator>();
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && Pos > 0)
        {
            StartCoroutine(StartSwerve(true));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && Pos < 2)
        {
            StartCoroutine(StartSwerve(false));
        }
    }

    void FixedUpdate()
    {
        if (Check.activeSelf)
        {
            transform.position = Vector3.MoveTowards(transform.position, Track[Pos].position, Swerve);
        }
    }

    IEnumerator StartSwerve(bool Direction)
    {
        yield return new WaitForSeconds(Delay);
        if(Direction)
        {
            Pos--;
            Anim.SetTrigger("Left");
        }
        else
        {
            Pos++;
            Anim.SetTrigger("Right");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Check.SetActive(false);
        }
    }
}
