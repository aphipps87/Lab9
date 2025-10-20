using CarnivalShooter2D.Targets;
using Unity.VisualScripting;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] float timeBetweenSpawns;
    float timer;

    public GameObject target;

    Vector3[] spawnPos;

    private void Awake()
    {
        ResetTimer();
        SetSpawns();
        
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnEnemies();
            ResetTimer();
        }
    }

    void ResetTimer()
    {
        timer = timeBetweenSpawns;
    }

    void SetSpawns()
    {
        spawnPos = new Vector3[6];

        spawnPos[0] = new Vector3(-10, 4, 0);
        spawnPos[1] = new Vector3(-10, 2.75f, 0);
        spawnPos[2] = new Vector3(-10, 1.5f, 0);
        spawnPos[3] = new Vector3(10, 4, 0);
        spawnPos[4] = new Vector3(10, 2.75f, 0);
        spawnPos[5] = new Vector3(10, 1.5f, 0);
    }


    void SpawnEnemies()
    {
        foreach (var spawn in spawnPos)
        {
            GameObject spawnedEnemy = Instantiate(target, spawn, Quaternion.identity);
        }
    }
}
