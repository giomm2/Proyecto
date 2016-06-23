using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {
    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;
	// Use this for initialization
	void Start () {
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("f1"))
        {
            firstPersonCamera.enabled = false;
            thirdPersonCamera.enabled = true;
        }

        if (Input.GetButtonDown("f2"))
        {
            firstPersonCamera.enabled =true;
            thirdPersonCamera.enabled = false;
        }
    }
}
