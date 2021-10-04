using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforos : MonoBehaviour
{
 
    public List<GameObject> SemaforoDer;
    public List<GameObject> SemaforoIzq;
    public List<GameObject> SemaforoArr;
    public List<GameObject> SemaforoAbj;
    public List<GameObject> Parar;
    public List<GameObject> Seguir;
    public List<GameObject> Destruir;

    void Start()
    {
        StartCoroutine(ControlSemaforos(3f));
    }


    void Update()
    {

    }

    void SemaforoVerdeDerIzq()
    {
        SemaforoDer[0].SetActive(true);
        SemaforoDer[1].SetActive(false);
        SemaforoDer[2].SetActive(false);

        SemaforoIzq[0].SetActive(true);
        SemaforoIzq[1].SetActive(false);
        SemaforoIzq[2].SetActive(false);

        Parar[0].SetActive(false);
        Parar[1].SetActive(false);

        Seguir[0].SetActive(true);
        Seguir[1].SetActive(true);

        Destruir[0].SetActive(false);
        Destruir[1].SetActive(false);

    }

    void SemaforoAmarilloDerIzq()
    {
        SemaforoDer[0].SetActive(false);
        SemaforoDer[1].SetActive(true);
        SemaforoDer[2].SetActive(false);

        SemaforoIzq[0].SetActive(false);
        SemaforoIzq[1].SetActive(true);
        SemaforoIzq[2].SetActive(false);

        Parar[0].SetActive(true);
        Parar[1].SetActive(true);

        Seguir[0].SetActive(false);
        Seguir[1].SetActive(false);

        Destruir[0].SetActive(false);
        Destruir[1].SetActive(false);

    }

    void SemaforoRojoDerIzq()
    {
        SemaforoDer[0].SetActive(false);
        SemaforoDer[1].SetActive(false);
        SemaforoDer[2].SetActive(true);

        SemaforoIzq[0].SetActive(false);
        SemaforoIzq[1].SetActive(false);
        SemaforoIzq[2].SetActive(true);

        Parar[0].SetActive(true);
        Parar[1].SetActive(true);

        Seguir[0].SetActive(false);
        Seguir[1].SetActive(false);

        Destruir[0].SetActive(true);
        Destruir[1].SetActive(true);

    }

    void SemaforoVerdeArrAbj()
    {
        SemaforoArr[0].SetActive(true);
        SemaforoArr[1].SetActive(false);
        SemaforoArr[2].SetActive(false);

        SemaforoAbj[0].SetActive(true);
        SemaforoAbj[1].SetActive(false);
        SemaforoAbj[2].SetActive(false);

        Parar[2].SetActive(false);
        Parar[3].SetActive(false);

        Seguir[2].SetActive(true);
        Seguir[3].SetActive(true);

        Destruir[2].SetActive(false);
        Destruir[3].SetActive(false);
    }

    void SemaforoAmarilloArrAbj()
    {
        SemaforoArr[0].SetActive(false);
        SemaforoArr[1].SetActive(true);
        SemaforoArr[2].SetActive(false);

        SemaforoAbj[0].SetActive(false);
        SemaforoAbj[1].SetActive(true);
        SemaforoAbj[2].SetActive(false);

        Parar[2].SetActive(true);
        Parar[3].SetActive(true);

        Seguir[2].SetActive(false);
        Seguir[3].SetActive(false);

        Destruir[2].SetActive(false);
        Destruir[3].SetActive(false);
    }

    void SemaforoRojoArrAbj()
    {
        SemaforoArr[0].SetActive(false);
        SemaforoArr[1].SetActive(false);
        SemaforoArr[2].SetActive(true);

        SemaforoAbj[0].SetActive(false);
        SemaforoAbj[1].SetActive(false);
        SemaforoAbj[2].SetActive(true);

        Parar[2].SetActive(true);
        Parar[3].SetActive(true);

        Seguir[2].SetActive(false);
        Seguir[3].SetActive(false);

        Destruir[2].SetActive(true);
        Destruir[3].SetActive(true);
    }


    IEnumerator ControlSemaforos(float Tiempo)
    {
        while (true)
        {

            SemaforoRojoArrAbj();
            SemaforoVerdeDerIzq();
            yield return new WaitForSeconds(Tiempo);
            SemaforoAmarilloDerIzq();
            yield return new WaitForSeconds(1f);
            SemaforoRojoDerIzq();
            SemaforoVerdeArrAbj();
            yield return new WaitForSeconds(Tiempo);
            SemaforoAmarilloArrAbj();
            yield return new WaitForSeconds(1f);

        }    
    }
}
