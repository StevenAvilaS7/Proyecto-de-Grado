using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonEnviar : MonoBehaviour
{
    public GameObject plane;
    public GameObject CanvasObject;

    public void enviar()
    {   
        Debug.Log("Me pulsaste");
        plane.gameObject.SetActive(true);
        CanvasObject.SetActive(false);
    }

}
