using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabASpawnear;
    public float minX = 54f;
    public float maxX = 50f;
    public float yPos = 15f;
    public float intervaloMinTiempoSpawn = 3f;
    public float intervaloMaxTiempoSpawn = 6f;

    private void Start()
    {
        StartCoroutine(spawnObstaculo(Random.Range(intervaloMinTiempoSpawn, intervaloMaxTiempoSpawn), prefabASpawnear));
    }

    private IEnumerator spawnObstaculo(float intervalo, GameObject obstaculo)
    {
        yield return new WaitForSeconds(intervalo);
        Instantiate(obstaculo, new Vector3(Random.Range(minX, maxX), yPos, -1.47f), Quaternion.identity);
        StartCoroutine(spawnObstaculo(intervalo, obstaculo));
    }
}