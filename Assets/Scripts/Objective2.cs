using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Objective2 : MonoBehaviour {
    public GameObject key;
    public GameObject picture;
    public Text txtInformation;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    private void OnTriggerEnter(Collider other)
    {

        if (picture.active == false)
        {
            GameObject.Find("Milagro");
            gameObject.AddComponent<AudioSource>();
            source.clip = audio;
            source.playOnAwake = false;
            source.PlayOneShot(audio);
            txtInformation.text = "WELL DONE OBJECTIVE 2 COMPLETE";
            key.SetActive(false);
        }


    }
}
