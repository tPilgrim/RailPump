using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Vector2 NewPos;
    public GameObject Object;
    public float Offset;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            NewPos = new Vector2(transform.position.x + Offset, transform.position.y);
            Instantiate(Object, NewPos, transform.rotation);
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
