using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public wave[] waves;
    public EnemyController enemy;
    public EnemyHealthManager enemyHealth;
    public float waveDelay = 5f;
    public SerializeField enemyCount;

    wave currentWave;
    int currentWaveNumber;

    int enemiesRemainingToSpawn;

    float nextSpawnTime;

    public int killed;
    public int spawned;

    public ComputerText Computer;

    void Update()
    {
        //spawning the enemies according to wave settings

        if (enemiesRemainingToSpawn > 0 && Time.time > nextSpawnTime)
        {

            enemiesRemainingToSpawn--;
            nextSpawnTime = Time.time + currentWave.timeBetweenSpawns;
            EnemyController spawnedEnemy = Instantiate(enemy, transform.position, transform.rotation) as EnemyController;
        }
    }


    public void NextWave()
    {
        //resetting parameters and starting the next wave
        currentWaveNumber++;
        if (currentWaveNumber - 1 < waves.Length)
        {
            currentWave = waves[currentWaveNumber - 1];
            enemiesRemainingToSpawn = currentWave.enemyCount;
            spawned = currentWave.enemyCount;
        }
    }

    public void Play()
    {
        NextWave();
        killed = 0;
        spawned = currentWave.enemyCount;
    }

    [System.Serializable]
    public class wave
    {
        //parameters wave each wave to be accessed in editor 
        public int enemyCount;
        public float timeBetweenSpawns;

    }

}
