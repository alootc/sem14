using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float timeSpawn;
    public GameObject prefabEnemy;
    public float range;

    public float x;

    void Start()
    {
        CreateEnemy();
    }

    private void CreateEnemy()
    {
        x = Random.Range(-range, range);

        Vector2 position = new Vector2(transform.position.x + x, transform.position.y);

        GameObject enemy = Instantiate(prefabEnemy, transform.position, Quaternion.identity);

        Invoke("CreateEnemy", timeSpawn);
    }
}
