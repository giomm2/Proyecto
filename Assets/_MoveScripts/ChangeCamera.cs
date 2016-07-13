using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour
{
    public Camera firstCamera;
    public Camera thirdCamera;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (thirdCamera.enabled == true)
            {

                thirdCamera.enabled = false;
                firstCamera.enabled = true;
            }
            else
            {
                thirdCamera.enabled = true;
                firstCamera.enabled = false;

            }
        }

    }
    public Camera cam() {

        return firstCamera;
    }
}