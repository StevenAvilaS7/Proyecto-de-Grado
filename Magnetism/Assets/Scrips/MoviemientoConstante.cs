﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviemientoConstante : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad=10f;

    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= new Vector3(0,0,velocidad *Time.deltaTime);
    }
}
