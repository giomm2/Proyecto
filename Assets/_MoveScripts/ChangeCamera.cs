using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour
{
    public Camera firstCamera;
    public Camera thirdCamera;
    public GameObject firstLight;
    public GameObject thirdLight;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

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
        
        if (Input.GetMouseButtonDown(0))
        {
            if (firstCamera.enabled == true && firstLight.active == true)
            {
                gameObject.AddComponent<AudioSource>();
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
                firstLight.SetActive(false);
              

            }
            else if (firstCamera.enabled == true && firstLight.active == false)
            {
                gameObject.AddComponent<AudioSource>();
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
                firstLight.SetActive(true);
               
            }
            else if(thirdCamera.enabled == true && thirdLight.active == true) {
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
                thirdLight.SetActive(false);
                gameObject.AddComponent<AudioSource>();
               
               
            }

            else if (thirdCamera.enabled == true && thirdLight.active == false)
            {
                gameObject.AddComponent<AudioSource>();
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
                thirdLight.SetActive(true);
              
            }

        }

    }
    public Camera cam()
    {

        return firstCamera;
    }

    public void Music()
    {

        gameObject.AddComponent<AudioSource>();
        source.clip = audio;
        source.playOnAwake = false;
        source.PlayOneShot(audio);
    }
}