using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awardTrigger9 : MonoBehaviour
{
    GameObject[] enemies;
    public GameObject explo;
    public AudioSource awardFX;
    public AudioSource enemyblastFX;

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
        enemies = GameObject.FindGameObjectsWithTag("Enemy9");

        if(other.gameObject.tag == "Player")
        {
            foreach(GameObject x in enemies)
            {
                GameObject _explo = Instantiate(explo, x.transform.position, Quaternion.identity) as GameObject;
                Destroy(_explo, 2);
                Destroy(x);
            }
        }
        awardFX.Play();
        enemyblastFX.Play();
        this.gameObject.SetActive(false);
    }
}
