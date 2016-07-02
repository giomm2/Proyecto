using UnityEngine;
using System.Collections;
using System.Threading;

public class EnemyProximity : MonoBehaviour
{

    // Use this for initialization
    public GameObject objects ;
    public string nameTrigger;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public int timer;
    private bool flagEnemy = true;
    private int enemyEntry;
    private ChangeCamera camera = new ChangeCamera();
    public Camera firstCamera;
    public Camera thirdCamera;

    // Update is called once per frame
    void Update()
    {
      

        
        }




    void OnTriggerEnter(Collider collider)
    {


        if (collider.name.Equals(nameTrigger))
        {

            if ((int)Time.time >= timer && flagEnemy == true)
            {
                if (thirdCamera.enabled == true)
                {
                    thirdCamera.enabled = false;
                    firstCamera.enabled = true;

                }
                 enemyEntry = (int)Time.time+7;
                objects.SetActive(true);
                gameObject.AddComponent<AudioSource>();
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
                flagEnemy = false;

            }

        }
    }

    void OnTriggerStay(Collider collider)
    {

        if (collider.name.Equals(nameTrigger))
        {

            if ((int)Time.time ==enemyEntry && flagEnemy == false)
            {
                objects.SetActive(false);




            }
        }

    }

}


