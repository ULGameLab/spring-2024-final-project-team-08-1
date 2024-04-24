using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awardTrigger : MonoBehaviour
{
    GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if(other.gameObject.tag == "Player")
        {
            foreach(GameObject x in enemies)
            {
                Destroy(x);
            }
        }
    }
}
