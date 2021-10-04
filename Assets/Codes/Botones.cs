using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public bool Lento = false;
    public bool Normal = false;
    public bool Rapido = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

   public void Despacito()
    {
        
           Time.timeScale = 0.5f;
        
    }

    public void Nolmal()
    {

            Time.timeScale = 1f;

    }

    public void Duro()
    {

            Time.timeScale = 3f;

    }
    
}
