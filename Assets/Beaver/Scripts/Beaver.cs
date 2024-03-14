using UnityEngine;
using System.Collections;

public class Beaver : MonoBehaviour {
    public Animator beaver;
    private IEnumerator coroutine;
	// Use this for initialization
	void Start () {
        beaver = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S))
        {
            beaver.SetBool("idle", true);
            beaver.SetBool("walk", false);
            beaver.SetBool("turnleft", false);
            beaver.SetBool("turnright", false);
            beaver.SetBool("run", false);
            beaver.SetBool("swim", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            beaver.SetBool("walk", true);
            beaver.SetBool("cutleft", false);
            beaver.SetBool("cutright", false);
            beaver.SetBool("idle", false);
            beaver.SetBool("run", false);
            beaver.SetBool("swim", false);
            beaver.SetBool("swimleft", false);
            beaver.SetBool("swimright", false);
            beaver.SetBool("idle2", false);
            beaver.SetBool("turnleft", false);
            beaver.SetBool("turnright", false);
        }
        if (Input.GetKey(KeyCode.E))
        {
            beaver.SetBool("run", true);
            beaver.SetBool("cutleft", false);
            beaver.SetBool("cutright", false);
            beaver.SetBool("walk", false);
            beaver.SetBool("turnleft", false);
            beaver.SetBool("turnright", false);
            beaver.SetBool("idle", false);
            beaver.SetBool("swim", false);
            beaver.SetBool("swimleft", false);
            beaver.SetBool("swimright", false);
            beaver.SetBool("idle2", false);
        }
        if (Input.GetKey(KeyCode.Space)) 
        {
            beaver.SetBool("swim", true);
            beaver.SetBool("swimleft", false);
            beaver.SetBool("swimright", false);
            beaver.SetBool("idle", false);
            beaver.SetBool("run", false);
            beaver.SetBool("walk", false);
            beaver.SetBool("turnleft", false);
            beaver.SetBool("turnright", false);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            beaver.SetBool("up", true);
            beaver.SetBool("idle", false);
            beaver.SetBool("walk", false);
            beaver.SetBool("turnleft", false);
            beaver.SetBool("turnright", false);
            beaver.SetBool("run", false);
            beaver.SetBool("down", false);
            StartCoroutine("idle2");
            idle2();
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            beaver.SetBool("down", true);
            beaver.SetBool("idle2", false);
            beaver.SetBool("run",false);
            beaver.SetBool("walk", false);
            StartCoroutine("idle");
            idle();
        }
        if (Input.GetKey(KeyCode.A))
        {
            beaver.SetBool("turnleft", true);
            beaver.SetBool("cutleft", false);
            beaver.SetBool("cutright", false);
            beaver.SetBool("swimleft", true);
            beaver.SetBool("swimright", false);
            beaver.SetBool("turnright", false);
            beaver.SetBool("walk", false);
            beaver.SetBool("run", false);
            beaver.SetBool("idle", false);
            beaver.SetBool("idle2", false);
            beaver.SetBool("swim", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            beaver.SetBool("turnright", true);
            beaver.SetBool("cutleft", false);
            beaver.SetBool("cutright", false);
            beaver.SetBool("swimright", true);
            beaver.SetBool("swimleft", false);
            beaver.SetBool("turnleft", false);
            beaver.SetBool("walk", false);
            beaver.SetBool("run", false);
            beaver.SetBool("idle", false);
            beaver.SetBool("idle2", false);
            beaver.SetBool("swim", false);
        }
        if (Input.GetKey("left"))
        {
            beaver.SetBool("cutleft", true);
            beaver.SetBool("cutright", false);
            beaver.SetBool("walk", false);
            beaver.SetBool("run", false);
            beaver.SetBool("turnleft", false);
            beaver.SetBool("turnright", false);
            beaver.SetBool("idle", false);
            beaver.SetBool("idle2", false);
            StartCoroutine("idle2");
            idle2();
        }
        if (Input.GetKey("right"))
        {
            beaver.SetBool("cutright", true);
            beaver.SetBool("cutleft", false);
            beaver.SetBool("walk", false);
            beaver.SetBool("run", false);
            beaver.SetBool("turnleft", false);
            beaver.SetBool("turnright", false);
            beaver.SetBool("idle", false);
            beaver.SetBool("idle2", false);
            StartCoroutine("idle2");
            idle2();
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            beaver.SetBool("eat", true);
            beaver.SetBool("idle2", false);
            StartCoroutine("idle2");
            idle2();
        }
        if (Input.GetKey(KeyCode.Keypad0)){
            beaver.SetBool("idle2", false);
            beaver.SetBool("die", true);
        }
        if (Input.GetKey(KeyCode.Keypad1))
        {
            beaver.SetBool("idle2", false);
            beaver.SetBool("hit", true);
            StartCoroutine("idle2");
            idle2();
        }
    }
    IEnumerator idle2()
    {
        yield return new WaitForSeconds(0.5f);
        beaver.SetBool("idle2", true);
        beaver.SetBool("up", false);
        beaver.SetBool("cutleft", false);
        beaver.SetBool("cutright", false);
        beaver.SetBool("eat", false);
        beaver.SetBool("hit", false);
    }
    IEnumerator idle()
    {
        yield return new WaitForSeconds(0.5f);
        beaver.SetBool("idle", true);
        beaver.SetBool("down", false);
    }
}
