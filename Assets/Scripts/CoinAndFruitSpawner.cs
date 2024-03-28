using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAndFruitSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject coinPrefab2;

    public GameObject fruitPrefab;
    public GameObject badPrefab;

    private GameObject parentObject;
    public int maxCoinsCount = 50;
    public int maxCoinsCount2 = 25;
    public int maxFruitsCount = 50;
    public int maxBadFruitsCount = 50;


    public float secondsBetweenSpawn = 2;

    float elapsedTimeForCoin = 0;
    float elapsedTimeForCoin2 = 0;
    float elapsedTimeForFruit = 0;
    float elapsedTimeForBad = 0;


    int currentCoinCount = 0;
    int currentCoinCount2 = 0;
    int currentFruitCount = 0;
    int currentBadFruitCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        currentCoinCount = CountCoin();
        currentCoinCount2 = CountCoin2();

        currentFruitCount = CountFruit();
        currentBadFruitCount = CountBadFruit();

        parentObject = transform.gameObject;
    }

    private int CountCoin()
    {
        int count = 0;
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        count = coins.Length;
        return count;
    }
    private int CountCoin2()
    {
        int count = 0;
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin2");
        count = coins.Length;
        return count;
    }

    private int CountFruit()
    {
        int count = 0;
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Fruit");
        count = coins.Length;
        return count;
    }

    private int CountBadFruit()
    {
        int count = 0;
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Bad");
        count = coins.Length;
        return count;
    }


    // Update is called once per frame
    void Update()
    {
         elapsedTimeForCoin  += Time.deltaTime;
         elapsedTimeForCoin2 += Time.deltaTime;
         elapsedTimeForFruit += Time.deltaTime;
         elapsedTimeForBad  += Time.deltaTime;

        if (elapsedTimeForCoin > secondsBetweenSpawn & currentCoinCount < maxCoinsCount){
            elapsedTimeForCoin = 0;
            Vector3 spawnPosition = RandomPositionAroundPlayer();
            GameObject newCoin = (GameObject)Instantiate(coinPrefab, spawnPosition, Quaternion.Euler(0, 0, 0));
            newCoin.transform.SetParent(parentObject.transform);
            currentCoinCount = CountCoin();
        }

        if (elapsedTimeForCoin2 > secondsBetweenSpawn & currentCoinCount2 < maxCoinsCount2)
        {
            elapsedTimeForCoin2 = 0;
            Vector3 spawnPosition = RandomPositionAroundPlayer();
            GameObject newCoin = (GameObject)Instantiate(coinPrefab2, spawnPosition, Quaternion.Euler(0, 0, 0));
            newCoin.transform.SetParent(parentObject.transform);
            currentCoinCount = CountCoin2();
        }

        if (elapsedTimeForFruit > secondsBetweenSpawn && currentFruitCount < maxFruitsCount)
        {
            elapsedTimeForFruit = 0;
            Vector3 spawnPosition = RandomPositionAroundPlayer();
            GameObject newFruit = (GameObject)Instantiate(fruitPrefab, spawnPosition, Quaternion.Euler(0, 0, 0));
            newFruit.transform.SetParent(parentObject.transform);
            currentFruitCount = CountFruit();
        }

        if (elapsedTimeForBad > secondsBetweenSpawn && currentBadFruitCount < maxBadFruitsCount)
        {
            elapsedTimeForBad = 0;
            Vector3 spawnPosition = RandomPositionAroundPlayer();
            GameObject newBadFruit = (GameObject)Instantiate(badPrefab, spawnPosition, Quaternion.Euler(0, 0, 0));
            newBadFruit.transform.SetParent(parentObject.transform);
            currentFruitCount = CountBadFruit();
        }
        
    }

    private Vector3 RandomPositionAroundPlayer()
    {
        Vector3 randPos = new Vector3(Random.Range(-30.0f, 30.0f), 0, Random.Range(-30.0f, 30.0f));
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        randPos += playerPos;
        //randPos.x += 10.0f;
        //randPos.y = 0.11f;
        //randPos.z += 10.0f;
        return randPos;
    }

}
