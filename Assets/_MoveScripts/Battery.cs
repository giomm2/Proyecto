using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{


    public GameObject firstLight;
    public GameObject thirdLight;
    public Scrollbar batteryBar;
    private int levels=0;
    private double battery = 100;
    private double value=0;
    private double levelOne = 0.05;
    private double levelTwo = 0.1;
    private double levelThree = 0.5;
    private bool flag = true;
    private bool flag2 = true;
    private int time = 0;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Use this for initialization
    void Start()
    {
        Level level = new Level();
        levels = level.GetTimers();
    }

    // Update is called once per frame
    void Update()
    {

        if ((firstLight.active == true || thirdLight.active == true) && flag)
        {
            if (levels == 1)
            {
                value = (levelOne + (int)Time.time) - (int)Time.time;
                LessBattery(value);
            }
            else if (levels == 2)
            {
                value = (levelTwo + (int)Time.time) - (int)Time.time;
                LessBattery(value);
            }
            else
                value = (levelThree + (int)Time.time) - (int)Time.time;
            LessBattery(value);

        }
        else if (flag)
        {
            value = (levelTwo + (int)Time.time) - (int)Time.time;
            MoreBattery(value);
        }
        else
        {
            if (flag2)
            {
                time = (int)Time.time;

            }
            TurnOffLight();
        }



    }

    public void LessBattery(double value)
    {
        if (battery > 0)
        {

            battery -= value;
            float p = (float)battery;
            batteryBar.size = p / 100f;
        }
        if (battery <= 0)
        {

            flag = false;
            gameObject.AddComponent<AudioSource>();
            source.clip = audio;
            source.playOnAwake = false;
            source.PlayOneShot(audio);

        }
    }

    public void MoreBattery(double value)
    {
        if (battery < 100f)
        {
            battery += value;
            float p = (float)battery;
            batteryBar.size = (p / 100f);
        }

        if (battery > 100f)
        {
            battery = 100f;
        }
    }

    public void TurnOffLight()
    {

        if ((time + 5) >= (int)Time.time)
        {
            battery = 0f;
            firstLight.SetActive(false);
            thirdLight.SetActive(false);
            flag = false;
            flag2 = false;
        }
        else
        {

            flag = true;
            flag2 = true;
        }
    }
}
