using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{
    public void practica1()
    {   
        SceneManager.LoadScene(1);
        Debug.Log("Practica 1");

    }
    public void practica2()
    {   
        SceneManager.LoadScene(2);
        Debug.Log("Practica 2");

    }
    public void practica3()
    {   
        SceneManager.LoadScene(3);
        Debug.Log("Practica 3");

    }
}
