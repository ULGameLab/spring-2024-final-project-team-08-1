using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
using UnityEngine.SceneManagement; // Required for loading scenes

=======
>>>>>>> origin/kelly

public class CollectableControl : MonoBehaviour
{
    public static int shellCount;
    public GameObject shellCountDisplay;

    // Update is called once per frame
    void Update()
    {
        shellCountDisplay.GetComponent<Text>().text = "" + shellCount;
<<<<<<< HEAD
        if(shellCount == 15)
        {
            SceneManager.LoadScene("GameOver");
        }

        if(shellCount == -1)
        {
            SceneManager.LoadScene("GameOver");
        }
    
=======
>>>>>>> origin/kelly
    }
}
