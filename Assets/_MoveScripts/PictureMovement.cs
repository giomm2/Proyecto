using UnityEngine;
using System.Collections;

public class PictureMovement : MonoBehaviour
{

    public float x;
    public float y;
    public float z;
    public float rotation;
    public GameObject objects;
    public string nameTrigger;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    private int timer;
    private bool Flag = true;
    private int randomTime;
    private System.Random random = new System.Random();

    void Start() {

        RandomTime();

    }
    void OnTriggerEnter(Collider collider)
    {

        if (collider.name.Equals(nameTrigger))
        {

            if ((int)Time.time >= timer && Flag == true)
            {
                objects.transform.localPosition = new Vector3(x, y, z);
                objects.transform.localRotation = Quaternion.Euler(rotation, 0, 0);
                gameObject.AddComponent<AudioSource>();
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
                Flag = false;

                if (randomTime == 1)
                {

                    timer = random.Next((int)Time.time, 350);

                }

                else if (randomTime == 2)
                {
                    timer = random.Next((int)Time.time, 230);
                }
                else
                {
                    timer = random.Next((int)Time.time, 60);

                }

            }
        }

    }


    public void RandomTime() {

        Level level = new Level();
        randomTime = level.GetTimers();

        if (randomTime == 1)
        {

            timer = 120;

        }

        else if (randomTime == 2)
        {
            timer = 100;
        }
        else
        {
            timer = 30;

        }


    }

}

