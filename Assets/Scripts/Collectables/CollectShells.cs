using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectShells : MonoBehaviour
{
    public AudioSource shellFX;

    void OnTriggerEnter(Collider other)
    {
        shellFX.Play();
        CollectableControl.shellCount += 1;
        this.gameObject.SetActive(false);
    }
}
