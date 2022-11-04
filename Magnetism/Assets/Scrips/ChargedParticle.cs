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

    public void SetMasaEsfera(float value)
	{
		OnValueChanged(value, 0);
	}
	
	public void SetCargaEsfera(float value)
	{
		OnValueChanged(value, 1);
	}
	
	public void SetCargaBarraSuperior(float value)
	{
		OnValueChanged(value, 2);
	}

    public void SetCargaBarraInferior(float value)
	{
		OnValueChanged(value, 3);
	}

    public void OnValueChanged(float value, int channel)
	{
		Color c = Color.white;

		if (channel==0){
        charge = value;
        Start();
        Debug.Log("Se entra a masa");
        }
        if(channel==1){
        charge = value;
        Start();
        Debug.Log("Se entra carga esfera");
        }
        if (channel==2){
        charge = value;
        Start();
        Debug.Log("Se entra a Barra Superior");
        }
        if(channel==3){
        charge = value;
        Start();
        Debug.Log("Se entra a barra Inferior");
        }
	}
}

	
	




