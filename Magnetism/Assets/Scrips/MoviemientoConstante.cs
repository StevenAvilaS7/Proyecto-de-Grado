using System.Collections;
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
        transform.position+= new Vector3(velocidad *Time.deltaTime,0,0);
    }
    public void SetVelocidadEsfera(float value)
	{
		velocidad=value;
	}
}
