using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MoveObjects : MonoBehaviour
{

    float y;
    float x;
    float z;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public int rdn;
   private bool flag;
    void Start()
    {

       
    }


   
    void Update()

        
    {

    if((int)Time.time == rdn)
        {
            flag = true;
        }


        if (flag)
        {

            PictureMovement();
        }

    }


   

    public void PictureMovement()
    {
       
        y += -1f * ((int)Time.time-rdn);
        x += 2 * ((int)Time.time - rdn);
        
        if (y > -5)
        {

            transform.localPosition = new Vector3(0, y, 0);
            transform.localRotation = Quaternion.Euler(x, 0, 0);


            if ((y - 1) == -5)
            {
                gameObject.AddComponent<AudioSource>();
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
            }

        }
    }


   
}
