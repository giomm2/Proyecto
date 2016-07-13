using UnityEngine;
using System.Collections;
using System.Threading;

public class EnemyProximity : MonoBehaviour
{

    // Use this for initialization
    public GameObject objects;
    public string nameTrigger;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    private int timers;
    private int randomTime;
    private bool flagEnemy = true;
    private int enemyEntry;
    private ChangeCamera camera = new ChangeCamera();
    public Camera firstCamera;
    public Camera thirdCamera;
    private System.Random random = new System.Random();

    // Update is called once per frame

    void Start()
    {
        RandomTime();

    }
    void Update()
    {


    }



    void OnTriggerEnter(Collider collider)
    {


        if (collider.name.Equals(nameTrigger))
        {

            if ((int)Time.time >= timers && flagEnemy == true)
            {
                if (thirdCamera.enabled == true)
                {
                    thirdCamera.enabled = false;
                    firstCamera.enabled = true;

                }
                enemyEntry = (int)Time.time + 7;
                objects.SetActive(true);
                gameObject.AddComponent<AudioSource>();
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
                flagEnemy = false;


                if (randomTime == 1)
                {

                    timers = random.Next((int)Time.time, 350);

                }

                else if (randomTime == 2)
                {
                    timers = random.Next((int)Time.time, 230);
                }
                else
                {
                    timers = random.Next((int)Time.time, 60);

                }
            }

        }
    }

    void OnTriggerStay(Collider collider)
    {

        if (collider.name.Equals(nameTrigger))
        {

            if ((int)Time.time == enemyEntry && flagEnemy == false)
            {
                objects.SetActive(false);




            }
        }

    }



    public void RandomTime() {
        Level level = new Level();
        randomTime = level.GetTimers();

        if (randomTime == 1)
        {

            timers = 130;

        }

        else if (randomTime == 2)
        {
            timers = 120;
        }
        else
        {
            timers = 20;

        }


    }
}


