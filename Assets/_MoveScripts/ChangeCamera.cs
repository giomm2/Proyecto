using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour
{
    public Camera firstCamera;
    public Camera thirdCamera;
    public GameObject firstLight;
    public GameObject thirdLight;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (thirdCamera.enabled == true)
            {

                thirdCamera.enabled = false;
                firstCamera.enabled = true;
                firstLight.SetActive(true);
                thirdLight.SetActive(false);
            }
            else
            {
                thirdCamera.enabled = true;
                firstCamera.enabled = false;
                firstLight.SetActive(false);
                thirdLight.SetActive(true);

            }
        }

    }
    public Camera cam() {

        return firstCamera;
    }
}