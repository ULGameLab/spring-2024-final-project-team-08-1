using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Required for loading scenes


public class CollectableControl : MonoBehaviour
{
    public static int shellCount;
    public GameObject shellCountDisplay;

    // Update is called once per frame
    void Update()
    {
        shellCountDisplay.GetComponent<Text>().text = "" + shellCount;
        if(shellCount == 15)
        {
            SceneManager.LoadScene("GameOver");
        }

        if(shellCount == -1)
        {
            SceneManager.LoadScene("GameOver");
        }
    
    }
}
