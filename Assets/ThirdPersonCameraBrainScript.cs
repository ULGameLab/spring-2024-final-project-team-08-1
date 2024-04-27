using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Cinemachine;
public class ThirdPersonCameraBrainScript : MonoBehaviour
{
    [System.Obsolete]
    CinemachineFreeLook ThirdPersonCameraBrain;
    private float V;
    private float H;
    private float Activate = 1f;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        ThirdPersonCameraBrain = GetComponent<CinemachineFreeLook>();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        V = Activate * Input.GetAxis("Vertical");
        H = Activate * Input.GetAxis("Horizontal");

        ThirdPersonCameraBrain.m_RecenterToTargetHeading.m_enabled = V != 0 || H != 0;
    }
}