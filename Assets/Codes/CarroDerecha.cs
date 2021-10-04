using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroDerecha : MonoBehaviour
{
    [Range(0f, 10f)]
    public float velocidad = 4f;

    private Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.left * velocidad;
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "DestructorIzq")
        {
            Destroy(gameObject);
        }

        if (collider2D.gameObject.tag == "ParaDer")
        {
            rigidbody2D.velocity = Vector2.left * 0;
        }

        if (collider2D.gameObject.tag == "SeguirDer")
        {
            rigidbody2D.velocity = Vector2.left * velocidad;
        }

        if (collider2D.gameObject.tag == "DestruirDer")
        {
            Destroy(gameObject);
        }
    }
}
