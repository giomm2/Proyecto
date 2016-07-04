using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReadyClue : MonoBehaviour {
    public Text checkClueOne;
    public GameObject picture;
    public GameObject key;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    private bool objectiveOne;
    private bool objectiveTwo;
    //GameObject frame = Instantiate(Resources.Load("Frame", typeof(GameObject))) as GameObject;
    //GameObject picture = Instantiate(Resources.Load("pictureDamian", typeof(GameObject))) as GameObject;
    // Use this for initialization
    void Start () {
           }
	
	// Update is called once per frame
	void Update () {
        //if (picture.activeInHierarchy || frame.activeInHierarchy ||( picture.activeInHierarchy && frame.activeInHierarchy))
        //{
        //    checkClueOne.text = "On Progress";
        //}
        //else {
        //    checkClueOne.text = "Done!!";
        //}
        if (picture.activeInHierarchy && key.activeInHierarchy)
        {
            checkClueOne.text = "Look it well in the rooms";
            objectiveOne = false;
            objectiveTwo = false;
        }
        if (picture.activeInHierarchy == false && key.activeInHierarchy)
        {
            checkClueOne.text = "Done Mission 1";
            objectiveOne = true;
            objectiveTwo = false;
            source.clip = audio;
            source.playOnAwake = false;
            source.PlayOneShot(audio);
        }

        if (objectiveOne == true && key.activeInHierarchy)
        {
            checkClueOne.text = "Look it well in the kitchen";
            objectiveOne = true;
            objectiveTwo = false;
        }
        if (objectiveOne == true && key.activeInHierarchy==false)
        {
            checkClueOne.text = "Done Mission 2";
            objectiveOne = true;
            objectiveTwo = true;
            source.clip = audio;
            source.playOnAwake = false;
            source.PlayOneShot(audio);
        }
       
    }
}
