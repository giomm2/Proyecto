using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReadyClue : MonoBehaviour {
    public Text checkClueOne;
    public GameObject picture;
    public GameObject frame1;
    public GameObject frame2;
    public GameObject frame3;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
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
        if (picture.activeInHierarchy || frame1.activeInHierarchy || frame2.activeInHierarchy || frame3.activeInHierarchy ||
            (picture.activeInHierarchy && frame1.activeInHierarchy && frame2.activeInHierarchy && frame3.activeInHierarchy))
        {
            checkClueOne.text = "Look it well in the rooms";
        }
        else
        {
            checkClueOne.text = "Done";
            source.clip = audio;
            source.playOnAwake = false;
            source.PlayOneShot(audio);
        }
    }
}
