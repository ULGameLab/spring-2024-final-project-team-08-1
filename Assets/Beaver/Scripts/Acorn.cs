using UnityEngine;
using System.Collections;

public class Acorn : MonoBehaviour {
    public MeshRenderer acorn;
    private IEnumerator coroutine;
	// Use this for initialization
	void Start () {
        acorn = GetComponent<MeshRenderer>();
        acorn.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            
            StartCoroutine("hideacorn");
            hideacorn();
        }
	}
    IEnumerator hideacorn()
    {
        yield return new WaitForSeconds(0.2f);
        acorn.enabled = true;
        yield return new WaitForSeconds(1.7f);
        acorn.enabled = false;
    }
}
