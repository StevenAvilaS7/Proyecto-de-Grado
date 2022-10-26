using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargedParticle : MonoBehaviour
{
    public float charge=1;

    void Start(){
        UpdateColor();
    }

    public void UpdateColor(){
        Color color = charge > 0 ? Color.red : Color.blue;
        GetComponent<Renderer>().material.color = color;



    }

        public void readString(string inputLabel){
        charge = float.Parse(inputLabel);
        Start();
        Debug.Log("Se entra carga esfera");
    }

    public void readChargeBar1(string inputLabel){
        charge = float.Parse(inputLabel);
        Start();
        Debug.Log("Se entra barra 1");
    }
    public void readChargeBar2(string inputLabel){
        charge = float.Parse(inputLabel);
        Start();
        Debug.Log("Se entra barra 2");
    }

}


