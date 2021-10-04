using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDer : MonoBehaviour
{
    public GameObject CarroDer;

    [Range (1f, 10f)] 
    public float generacion = 2f;
    [Range (0f, 10f)] 
    public float reaccion = 2f;


    void Start()
    {
        Iniciador();
    }

    void Update()
    {
        
    }

    void CrearCarro()
    {
        Instantiate(CarroDer, transform.position, Quaternion.identity);    
    }

    public void Iniciador()
    {
        InvokeRepeating("CrearCarro", generacion, reaccion);
    }
}
