using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolaFuego : MonoBehaviour
{
    public float tiempoInicialVivo = 0f;
    public float tiempoMaximoDeVida = 5f;
    public float velocidad = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, 0);
        tiempoInicialVivo += Time.deltaTime;

        if (tiempoInicialVivo >= tiempoMaximoDeVida)
        {
            Destroy(this.gameObject);
        }
    }
}