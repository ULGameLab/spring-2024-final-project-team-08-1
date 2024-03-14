using UnityEngine;
using System.Collections;

public class OakTree : MonoBehaviour {
    public MeshRenderer oaktree1;
    public MeshRenderer oaktree2;
    private IEnumerator coroutine;
	// Use this for initialization
	void Start () {
    oaktree1 = GetComponent<MeshRenderer>();
    oaktree1.enabled = false;
        oaktree2.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("left"))
        {
            oaktree1.enabled = true;
            oaktree2.enabled = false;
            StartCoroutine("hideoak");
            hideoak();
        }
        if (Input.GetKey("right"))
        {
            oaktree1.enabled = false;
            oaktree2.enabled = true;
            StartCoroutine("hideoak");
            hideoak();
        }
        if (Input.GetKey(KeyCode.W))
        {
            oaktree1.enabled = false;
            oaktree2.enabled = false;
        }
        if (Input.GetKey(KeyCode.E))
        {
            oaktree1.enabled = false;
            oaktree2.enabled = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            oaktree1.enabled = false;
            oaktree2.enabled = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            oaktree1.enabled = false;
            oaktree2.enabled = false;
        }
	}
    IEnumerator hideoak()
    {
        yield return new WaitForSeconds(2.7f);
        oaktree1.enabled = false;
        oaktree2.enabled = false;
    }
}
