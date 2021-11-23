using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance { get; private set; }

    public GameObject enemyPrefab;

    public float spawnTimer = 2f;

    void Awake()
    {
        Instance = this;
    }

    // Iniciar la generación
    public void StartSpawn()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnTimer);
    }

    // Encargado de generar el enemigo
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }

    // Parar la generación
    public void StopSpawn()
    {
        
    }

}
