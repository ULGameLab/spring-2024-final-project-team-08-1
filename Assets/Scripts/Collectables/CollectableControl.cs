using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int shellCount;
    public GameObject shellCountDisplay;

    // Update is called once per frame
    void Update()
    {
        shellCountDisplay.GetComponent<Text>().text = "" + shellCount;
    }
}
