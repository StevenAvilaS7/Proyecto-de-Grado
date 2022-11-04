using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviemientoEnAngulo : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad=10f;

    private float angulo=5f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         transform.position+= new Vector3(angulo *Time.deltaTime,angulo *Time.deltaTime,0);
    }
}
