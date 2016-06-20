using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DoorsMovements : MonoBehaviour
{
    private float y;
    private float x;
    private float z;
    public AudioClip audioOpen;
    public AudioClip audioClose;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public int timer;

    //Its a int becuase:
    //0:change position
    //1:Back position
    //3:Dont move
    private int flag=3;
    private bool flag2 = true;
    private bool flag3 = true;

    // Use this for initialization
    void Start()
    {

        gameObject.AddComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if ((int)Time.time - timer == 2)
        {
            source.Stop();

        }

        if ((int)Time.time == timer)
        {
            flag = 0;
        }

        if ((int)Time.time > timer)
        {
            flag = 1;
        }

        if (flag == 0 || flag == 1)
        {

            DoorsMovement();
        }



    }

    public void DoorsMovement()
    {


        if (flag2)
        {

            transform.localPosition = new Vector3(-206.2145f, 0, -238.7241f);
            transform.localRotation = Quaternion.Euler(0, 19.4667f, 0);
            gameObject.AddComponent<AudioSource>();
            source.clip = audioOpen;
            source.playOnAwake = false;
            source.PlayOneShot(audioOpen);

            flag2 = false;

        }

        if (flag == 1 && (int)Time.time - 5 == timer && flag3 == true)
        {

            transform.localPosition = new Vector3(0, 0, 0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);

            gameObject.AddComponent<AudioSource>();
            source.clip = audioClose;
            source.playOnAwake = false;
            source.PlayOneShot(audioClose);
            flag = 3;

            flag3 = false;

        }




    }



}

