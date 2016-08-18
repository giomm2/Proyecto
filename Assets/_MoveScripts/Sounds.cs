using UnityEngine;
using System.Collections;

public class Sounds : MonoBehaviour
{

 
    public int timer;
    public string nameTrigger;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    private bool flag=true;
    private int randomTime;
    //private System.Random random = new System.Random();
    // Use this for initialization
    void Start()
    {
        Level level = new Level();
        randomTime = level.GetTimers();

        if (randomTime == 1)
        {

            timer = 50;

        }

        else if (randomTime == 2)
        {
            timer = 30;
        }
        else
        {
            timer = 15;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit(Collider collider)
    {

        if (collider.name.Equals(nameTrigger))
        {

            if ((int)Time.time >= timer)
            {

                if (flag) {
                    gameObject.AddComponent<AudioSource>();
                    source.clip = audio;
                    source.playOnAwake = false;
                    source.PlayOneShot(audio);
                    
                }

            }
        }
    }
}
