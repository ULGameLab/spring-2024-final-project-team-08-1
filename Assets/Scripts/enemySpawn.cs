using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject[] enemiesToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNow", 2, 1);
    }

    Vector3 getRandomPos()
    {
        float _x = Random.Range(-480, 480);
        float _y = 11.3f;
        float _z = Random.Range(-380, 380);

        Vector3 newPos = new Vector3(_x, _y, _z);
        return newPos;
    }

    void SpawnNow()
    {
        Instantiate(enemiesToSpawn[Random.Range(0, 2)], getRandomPos(), Quaternion.identity);
    }
}
