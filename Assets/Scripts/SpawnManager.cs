using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject powerUp;

    public int enemyCount;
    public int waveCount = 1;
    private float spawnRange = 9;

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        
        if (enemyCount == 0)
        {
            SpawnWaveGenerator(waveCount);
            Instantiate(powerUp, SpawnPos(), powerUp.transform.rotation);
            waveCount++;
        }
    }

    void SpawnWaveGenerator(int emeiesToSpawn)
    {
        for (int i = 0; i < emeiesToSpawn; i++)
        {
            Instantiate(enemy, SpawnPos(), enemy.transform.rotation);
        }
    }

    private Vector3 SpawnPos()
    {
        float spawnX = Random.Range(-spawnRange, spawnRange);
        float spawnZ = Random.Range(-spawnRange, spawnRange);
        
        Vector3 spawnPos = new Vector3(spawnX, 0, spawnZ);

        return spawnPos;
    }
}
