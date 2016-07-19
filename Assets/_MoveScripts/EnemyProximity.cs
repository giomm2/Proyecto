using UnityEngine;
using System.Collections;
using System.Threading;
using UnityEngine.UI;

public class EnemyProximity : MonoBehaviour
{

    // Use this for initialization
    public GameObject objects;
    public GameObject damianLight;
   
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    private int timers;
    private int randomTime;
    private bool flagEnemy = true;
    private int enemyEntry;
    public Camera firstCamera;
    public Camera thirdCamera;
    private System.Random random = new System.Random();

   
    private float Health = 100;
    private int flagMove;
    public Text text;
    public Scrollbar scroll;
    HealthLifeBar HealthBar = new HealthLifeBar();

    // Update is called once per frame

    void Start()
    {
        HealthBar.setHealthLife(scroll);
        RandomTime();

    }
    void Update()
    {


    }



    void OnTriggerEnter(Collider collider)
    {


        if (collider.name.Equals("scareDamianKitchen")|| collider.name.Equals("scareDamianChildRoom") || collider.name.Equals("scareDamianPrincipalRoom")
            ||collider.name.Equals("scareDamianStairsRoom") || collider.name.Equals("scareDamianLivingroom"))
        {
             flagMove = random.Next(0, 50);
            text.text = ("" + flagMove);
            if ((int)Time.time >= timers && flagMove > 25)
            {
                if (thirdCamera.enabled == true)
                {
                    thirdCamera.enabled = false;
                    firstCamera.enabled = true;

                }
                enemyEntry = (int)Time.time + 4;
                objects.SetActive(true);
                damianLight.SetActive(true);
                gameObject.AddComponent<AudioSource>();
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
                

                if (randomTime == 1)
                {

                    Damage(10);

                }

                else if (randomTime == 2)
                {
                    Damage(20);
                }
                else
                {
                    Damage(50f); ;

                }


            }
            else
            {
                if (Health < 100f)
                {
                    Life(10f);
                }


            }

        }
    }

    void OnTriggerStay(Collider collider)
    {

        if (collider.name.Equals("scareDamianKitchen") || collider.name.Equals("scareDamianChildRoom") || collider.name.Equals("scareDamianPrincipalRoom")
            || collider.name.Equals("scareDamianStairsRoom") || collider.name.Equals("scareDamianLivingroom"))
        { 
            if ((int)Time.time >= timers)
            {
                if ((int)Time.time == enemyEntry )
                {
                    objects.SetActive(false);
                    damianLight.SetActive(true);
                }

            }
        }

    }

    void OnTriggerExit(Collider collider)
    {


        if (collider.name.Equals("scareDamianKitchen") || collider.name.Equals("scareDamianChildRoom") || collider.name.Equals("scareDamianPrincipalRoom")
             || collider.name.Equals("scareDamianStairsRoom") || collider.name.Equals("scareDamianLivingroom"))
        {
            objects.SetActive(false);
            damianLight.SetActive(true);
            flagMove = random.Next(0, 50);
            text.text = ("" + flagMove);
        }
    }
    public void Damage(float value)
    {
        if(Health > 0) {
            Health -= value;
            HealthBar.getHealthBar().size = Health / 100f;
        }
        if (Health < 0) {

            Health = 0f;
        }
    }

    public void Life(float value)
    {
        if (Health < 100f)
        {          
            Health += value;
            HealthBar.getHealthBar().size = (Health / 100f);
        }

        if (Health > 100f)
        {
            Health = 100f;
        }
        }
    public void RandomTime()
    {
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


