using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour
{
    private Transform Player;

    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if(-0.5f < Player.position.y)
        {
            gameObject.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Obstacle 2");
        }
        else
        {
            gameObject.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Obstacle 1");
        }
    }
}
