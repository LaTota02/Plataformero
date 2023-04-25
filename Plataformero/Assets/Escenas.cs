using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown("m"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
