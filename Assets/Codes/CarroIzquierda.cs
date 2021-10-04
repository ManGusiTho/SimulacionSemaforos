using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroIzquierda : MonoBehaviour
{
    [Range(0f, 10f)]
    public float velocidad = 4f;

    private Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.right * velocidad;
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "DestructorDer")
        {
            Destroy(gameObject);
        }

        if (collider2D.gameObject.tag == "ParaIzq")
        {
            rigidbody2D.velocity = Vector2.right * 0;
        }

        if (collider2D.gameObject.tag == "SeguirIzq")
        {
            rigidbody2D.velocity = Vector2.right * velocidad;
        }

        if (collider2D.gameObject.tag == "DestruitIzq")
        {
            Destroy(gameObject);
        }
    }
}
