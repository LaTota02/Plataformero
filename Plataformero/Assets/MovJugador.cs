using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{

    public int velocidad;
    public Vector3 moverse;
    public bool Saltando;
    public int Saltar = 5;

    void Start()
    {
        
    }


    void Update()
    {
        float MovHorizontal = Input.GetAxisRaw("Horizontal");

        moverse = new Vector3(MovHorizontal, 0f, 0f);

        moverse = moverse * velocidad * Time.deltaTime;

        transform.position += moverse;

        if(Input.GetKeyDown(KeyCode.Space)&& Saltando == false)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, Saltar, 0);
            Saltando = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "piso")
        {
            Saltando = false;
        }
    }
}
