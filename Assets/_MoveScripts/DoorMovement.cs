using UnityEngine;
using System.Collections;

public class DoorMovement : MonoBehaviour
{
    public float posX;
    public float posY;
    public float posZ;
    public float traY;
    public GameObject objects;
    public string nameTrigger;
    public AudioClip audioOpen;
    public AudioClip audioClose;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public int timer;

    private int flag = 3;
    private bool flag2 = true;
    private bool flag3 = true;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.name.Equals(nameTrigger))
        {

            if ((int)Time.time > timer)
            {
                flag = 1;
            }

            if (flag == 1)
            {




                if (flag2)
                {

                    objects.transform.localPosition = new Vector3(posX, posY, posZ);
                    objects.transform.localRotation = Quaternion.Euler(0, traY, 0);
                    gameObject.AddComponent<AudioSource>();
                    source.clip = audioOpen;
                    source.playOnAwake = false;
                    source.PlayOneShot(audioOpen);

                    flag2 = false;

                }


            }

        }

    }


    void OnTriggerExit(Collider collider)
    {


        if ((int)Time.time > timer && flag3 == true)
        {
            if (collider.name.Equals(nameTrigger))
            {


                objects.transform.localPosition = new Vector3(0, 0, 0);
                objects.transform.localRotation = Quaternion.Euler(0, 0, 0);

                gameObject.AddComponent<AudioSource>();
                source.clip = audioClose;
                source.playOnAwake = false;
                source.PlayOneShot(audioClose);
                flag = 3;

                flag3 = false;

            }
        }


    }
}