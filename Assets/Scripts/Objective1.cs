using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Objective1 : MonoBehaviour {
    public GameObject picture;
    public Text txtInformation;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public Image imgObjective;
    public Sprite img;

    private void OnTriggerEnter(Collider other) {
        GameObject.Find("Milagro");
        gameObject.AddComponent<AudioSource>();
        source.clip = audio;
        source.playOnAwake = false;
        source.PlayOneShot(audio);
       
        picture.SetActive(false);
    }
}
