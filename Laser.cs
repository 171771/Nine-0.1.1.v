﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]

public class Laser : MonoBehaviour
{
    private LineRenderer lr;
    static public RaycastHit hit;
    static public Ray ray;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }
    
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.collider)
            {
                lr.SetPosition(1, new Vector3(0, 0, hit.distance));
            }
        }
        else
        {
            lr.SetPosition(1, new Vector3(0, 0, 5000));
        }
    }

    
}