using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountCoins : MonoBehaviour
{
    private int numCoinsCollected = 0;
    private int numFruitsCollected = 0;
    private string coinsCollectedString = "Coins = ";
    private string fruitsCollectedString = "Fruits = ";
    private int score = 0;

    public TextMeshProUGUI countText;
    
    // Start is called before the first frame update
    void Start()
    {
        countText.text = coinsCollectedString + numCoinsCollected.ToString() +"\n";
        countText.text = countText.text  + fruitsCollectedString + numFruitsCollected.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        //score = numCoinsCollected + numFruitsCollected;
        /*
        if (other.gameObject.CompareTag("Coin")) 
        { 
            numCoinsCollected += 1;
            score = numCoinsCollected + numFruitsCollected;

            countText.text = coinsCollectedString + numCoinsCollected.ToString() + "\n";
            countText.text = countText.text + fruitsCollectedString + numFruitsCollected.ToString();
            countText.text = countText.text + "\n" + "Score : " + score.ToString();

        }
        if (other.gameObject.CompareTag("Fruit"))
        {
            numFruitsCollected += 2;
            score = numCoinsCollected + numFruitsCollected;

            countText.text = coinsCollectedString + numCoinsCollected.ToString() + "\n";
            countText.text = countText.text + fruitsCollectedString + numFruitsCollected.ToString();
            countText.text = countText.text + "\n" + "Score : " + score.ToString();

        }
        if (other.gameObject.CompareTag("Bad"))
        {
            numFruitsCollected -= 2;
            score = numCoinsCollected + numFruitsCollected;

            countText.text = coinsCollectedString + numCoinsCollected.ToString() + "\n";
            countText.text = countText.text + fruitsCollectedString + numFruitsCollected.ToString();
            countText.text = countText.text + "\n" + "Score : " + score.ToString();

        }
        */
    }
}
