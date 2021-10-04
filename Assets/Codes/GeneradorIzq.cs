using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorIzq : MonoBehaviour
{
    public GameObject CarroIzq;

    [Range(1f, 10f)]
    public float generacion = 2f;
    [Range(0f, 10f)]
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
        Instantiate(CarroIzq, transform.position, Quaternion.identity);
    }

    public void Iniciador()
    {
        InvokeRepeating("CrearCarro", generacion, reaccion);
    }
}
