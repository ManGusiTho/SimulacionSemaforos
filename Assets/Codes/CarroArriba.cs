using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroArriba : MonoBehaviour
{
    [Range(0f, 10f)]
    public float velocidad = 4f;

    private Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.down * velocidad;
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "DestructorAbaj")
        {
            Destroy(gameObject);
        }

        if (collider2D.gameObject.tag == "ParaArr")
        {
            rigidbody2D.velocity = Vector2.down * 0;
        }

        if (collider2D.gameObject.tag == "SeguirArr")
        {
            rigidbody2D.velocity = Vector2.down * velocidad;
        }

        if (collider2D.gameObject.tag == "DestruirArr")
        {
            Destroy(gameObject);
        }
    }
}
