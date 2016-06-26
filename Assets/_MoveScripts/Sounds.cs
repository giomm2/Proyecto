using UnityEngine;
using System.Collections;

public class Sounds : MonoBehaviour
{

 
    public int timer;
    public string nameTrigger;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    private bool flag=true;
    // Use this for initialization
    void Start()
    {

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
                    flag = false;
                }

            }
        }
    }
}
