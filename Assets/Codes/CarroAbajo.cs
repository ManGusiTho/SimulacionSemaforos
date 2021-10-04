using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroAbajo : MonoBehaviour
{
    [Range(0f, 10f)]
    public float velocidad = 4f;

    private Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.up * velocidad;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "DestructorArri")
        {
            Destroy(gameObject);
        }

        if (collider2D.gameObject.tag == "ParaAbj")
        {
            rigidbody2D.velocity = Vector2.up * 0;
        }

        if (collider2D.gameObject.tag == "SeguirAbj")
        {
            rigidbody2D.velocity = Vector2.up * velocidad;
        }

        if (collider2D.gameObject.tag == "Destruir")
        {
            Destroy(gameObject);
        }
    }
}
